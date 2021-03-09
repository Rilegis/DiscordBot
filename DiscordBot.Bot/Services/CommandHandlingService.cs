/**********************************************************************
    Author            : Rilegis
    Repository        : DiscordBot
    Project           : DiscordBot.Bot
    File name         : CommandHandlingService.cs
    Date created      : 01/04/2020
    Purpose           : This file contais the service needed to run the
                        built-in command handler.

    Revision History  :
    Date        Author      Ref     Revision 
    01/04/2020  Rilegis     1       First code commit.
    23/11/2020  Rilegis     2       Renamed '_client' to '_discordClient'
    08/02/2021  Rilegis     3       Switched logging to 'Microsoft.Extensions.Logging'
    22/02/2021  Rilegis     4       Switched logging to simple custom logger, because i do not like
                                    Microsoft's own.
    05/03/2021  Rilegis     5       Added command cooldown capabilities.
    08/03/2021  Rilegis     6       Added event call to 'CommandExecutedAsync', modified cooldown check
                                    and renamed 'MessageReceived' to 'MessageReceivedAsync'.
**********************************************************************/

using System;
using System.Reflection;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;
using Discord.WebSocket;
using DiscordBot.Models.Logging;
using Microsoft.Extensions.DependencyInjection;

namespace DiscordBot.Bot.Services
{
    public class CommandHandlingService
    {
        private readonly CommandService _commands;
        private readonly DiscordSocketClient _discordClient;
        private readonly IServiceProvider _services;
        private readonly CustomLogger _logger = new CustomLogger(new CustomLoggerConfig(), "CommandHandlingService");

        public CommandHandlingService(IServiceProvider services)
        {
            _discordClient = services.GetRequiredService<DiscordSocketClient>();
            _commands = services.GetRequiredService<CommandService>();
            _services = services;

            // Binding events for command checking
            _discordClient.MessageReceived += MessageReceivedAsync;
            _commands.CommandExecuted += CommandExecutedAsync;
        }

        public async Task InitializeAsync()
        {
            // Register modules that are public and inherit ModuleBase<T>.
            await _commands.AddModulesAsync(Assembly.GetEntryAssembly(), _services);
            // Add additional initialization code here...

            // Log service initialization completion
            _logger.LogInformation("Initialization complete.");
        }

        public async Task MessageReceivedAsync(SocketMessage rawMessage)
        {
            // Ignore system messages and messages from other bots
            if (rawMessage is not SocketUserMessage message) return;
            if (message.Source != MessageSource.User) return;

            // This value holds the offset where the prefix ends
            var argPos = 0;
            // Perform prefix check.
            if (!message.HasCharPrefix(Client.config.Bot.CommandPrefix[0], ref argPos)) return;
            // For a command syntax like '@botName command', replace previous line with: if (!message.HasMentionPrefix(_discord.CurrentUser, ref argPos)) return;
            else
            {
                var context = new SocketCommandContext(_discordClient, message);
                int i;
                DateTime dateTime = DateTime.Now; // Get current datetime
                TimeSpan span; // 'TimeSpan' used for 'DateTime' subtraction

                // Check is user has alredy executed a command before.
                if (!Client.stackCooldown.userStack.Contains(context.User))
                {
                    // If user never executed a command, add them to 'stackCooldown' object.
                    Client.stackCooldown.userStack.Add(context.User);
                    Client.stackCooldown.lastCommandAt.Add(dateTime);

                    // Perform the execution of the command.
                    await _commands.ExecuteAsync(context, argPos, _services);
                }
                else
                {
                    // If user is alredy saved on 'stackCooldown', check if they are inside command execution timespan.
                    i = Client.stackCooldown.userStack.IndexOf(context.User); // Get user index on 'userStack' (used to get correct timestamp for user's last command execution).
                    span = dateTime.Subtract(Client.stackCooldown.lastCommandAt[i]); // Get user's last command execution timestamp.
                    if (!(span.TotalSeconds > Client.config.Bot.CommandCooldown)) return; // If user is on cooldown, return without executing the command.
                    else await _commands.ExecuteAsync(context, argPos, _services); // Perform the execution of the command.
                }
            }
        }

        public async Task CommandExecutedAsync(Optional<CommandInfo> command, ICommandContext context, IResult result)
        {
            // Variables declaration
            int i;

            // command is unspecified when there was a search failure (command not found); we don't care about these errors
            if (!command.IsSpecified) return;

            // If the command failed, let's notify the user that something happened and log the result to the console.
            if (!result.IsSuccess)
            {
                _logger.LogWarning($"Command failed with result: {result}");
                await context.Channel.SendMessageAsync($"Error: {result}");
            }

            // Update user's 'stackCooldown' entry (I know for sure user exists in 'stackCooldown' because of the check on 'MessageReceivedAsync')
            i = Client.stackCooldown.userStack.IndexOf((SocketUser)context.User); // Get user index on 'userStack' (used to get correct timestamp for user's last command execution).
            Client.stackCooldown.lastCommandAt[i] = DateTime.Now; // If user is not on cooldown, update user's last command execution timestamp.
        }
    }
}
