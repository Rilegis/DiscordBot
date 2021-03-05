/**********************************************************************
    Author            : Rilegis
    Repository        : DiscordBot
    Project           : DiscordBot.Bot
    File name         : Client.cs
    Date created      : 23/03/2020
    Purpose           : This file contains the code needed to start the bot.

    Revision History  :
    Date        Author      Ref     Revision 
    23/03/2020  Rilegis     1       First code commit.
    01/04/2020  Rilegis     2       Updated code to fit built-in command handler.
    10/11/2020  Rilegis     3       Renamed from 'Bot' to 'Client'
    09/02/2021  Rilegis     4       Switched logging to 'Microsoft.Extensions.Logging'
                                    and removed event handlers.
    22/02/2021  Rilegis     5       Switched logging to simple custom logger, because i do not like
                                    Microsoft's own.
    05/03/2021  Rilegis     6       Added command cooldown capabilities.
**********************************************************************/

using System;
using System.IO;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;
using Discord.WebSocket;
using DiscordBot.Bot.Services;
using DiscordBot.Models.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;

namespace DiscordBot.Bot
{
    public class Client
    {
        public DiscordSocketClient discordClient;
        public static BotConfig config;
        public static StackCooldown stackCooldown = new StackCooldown();

        public async Task RunAsync()
        {
            config = JsonConvert.DeserializeObject<BotConfig>(File.ReadAllText("./etc/config.json")); // Configuration file deserialization
            discordClient = new DiscordSocketClient();

            var services = ConfigureServices();
            await services.GetRequiredService<CommandHandlingService>().InitializeAsync();
            await services.GetRequiredService<LoggingService>().InitializeAsync();

            // Binding event handlers
            // discordClient.Connected += EventHandlers.Connected;
            // No event handlers needed for now


            // Logs the bot in
            await discordClient.LoginAsync(TokenType.Bot, config.Bot.Token);
            await discordClient.StartAsync();

            // Run the program until the user stops it
            await Task.Delay(-1);
        }

        private IServiceProvider ConfigureServices()
        {
            return new ServiceCollection()
                // Base
                .AddSingleton<DiscordSocketClient>()
                .AddSingleton<CommandService>()
                .AddSingleton<CommandHandlingService>()
                .AddSingleton(discordClient)
                // Add additional services here...
                .AddSingleton<LoggingService>()
                .BuildServiceProvider();
        }
    }
}
