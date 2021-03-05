/**********************************************************************
    Author            : Rilegis
    Repository        : DiscordBot
    Project           : DiscordBot.Bot
    File name         : LoggingService.cs
    Date created      : 08/02/2021
    Purpose           : This file contais the definition for the logging service.

    Revision History  :
    Date        Author      Ref     Revision 
    08/02/2021  Rilegis     1       First code commit.
    22/02/2021  Rilegis     2       Switched logging to simple custom logger, because i do not like
                                    Microsoft's own.
**********************************************************************/

using System.Threading.Tasks;
using Discord;
using Discord.Commands;
using Discord.WebSocket;
using DiscordBot.Models.Logging;

namespace DiscordBot.Bot.Services
{
    public class LoggingService
    {
        // Variables declaration
        private readonly DiscordSocketClient _discordClient;
        private readonly CommandService _commandService;
        private readonly CustomLogger _logger = new CustomLogger(new CustomLoggerConfig(), "LoggingService");


        public LoggingService(DiscordSocketClient discordClient, CommandService commandService)
        {
            _discordClient = discordClient;
            _commandService = commandService;
        }

        public Task InitializeAsync()
        {
            // Binding 'Log' events for logging
            _discordClient.Log += LogAsync;
            _commandService.Log += LogAsync;

            // Log service initialization completion
            _logger.LogInformation("Initialization complete.");

            // Once all tasks have been completed, return 'Task.CompletedTask'
            return Task.CompletedTask;
        }

        public Task LogAsync(LogMessage msg)
        {
            // Variables declaration
            string message = msg.Exception?.ToString() ?? msg.Message;

            // Use different loggers for different severity levels
            switch (msg.Severity)
            {
                case LogSeverity.Critical:
                    _logger.LogCritical(message);
                    break;
                case LogSeverity.Error:
                    _logger.LogError(message);
                    break;
                case LogSeverity.Warning:
                    _logger.LogWarning(message);
                    break;
                case LogSeverity.Info:
                    _logger.LogInformation(message);
                    break;
                case LogSeverity.Debug:
                    _logger.LogDebug(message);
                    break;
                default:
                    _logger.LogDefault(message);
                    break;
            }

            // Log to filesystem.
            // W.I.P

            // Once all tasks have been completed, return 'Task.CompletedTask'
            return Task.CompletedTask;
        }
    }
}
