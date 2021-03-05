/**********************************************************************
    Author            : Rilegis
    Repository        : DiscordBot
    Project           : DiscordBot.Models
    File name         : CustomLogger.cs
    Date created      : 22/02/2021
    Purpose           : This file contains the definition for the custom
                        logger implementation.

    Revision History  :
    Date        Author      Ref     Revision 
    22/02/2021  Rilegis     1       First code commit.
    22/02/2021  Rilegis     2       Added '#if DEBUG' macro to 'LogDebug' and
                                    modified 'catch' statement on 'Log'.
**********************************************************************/

using System;

namespace DiscordBot.Models.Logging
{
    public class CustomLogger
    {
        // Variables declaration
        private readonly CustomLoggerConfig _config;
        private readonly string _name;

        public CustomLogger(CustomLoggerConfig config, string name)
        {
            _config = config;
            _name = name;
        }

        public void Log(LogLevel logLevel, string logMessage)
        {
            try
            {
                // Build 'outMessage'
                Console.Write($"[{DateTime.Now:dd/MM/yyyy - HH:mm:ss}] [");

                switch (logLevel)
                {
                    case LogLevel.Default:
                        Console.ForegroundColor = _config.DefaultColor;
                        Console.Write($"{(int)LogLevel.Default}:{LogLevel.Default.ToString().ToUpper()}");
                        break;
                    case LogLevel.Debug:
                        Console.ForegroundColor = _config.DebugColor;
                        Console.Write($"{(int)LogLevel.Debug}:{LogLevel.Debug.ToString().ToUpper()}");
                        break;
                    case LogLevel.Information:
                        Console.ForegroundColor = _config.InfoColor;
                        Console.Write($"{(int)LogLevel.Information}:{LogLevel.Information.ToString().ToUpper()}");
                        break;
                    case LogLevel.Warning:
                        Console.ForegroundColor = _config.WarnColor;
                        Console.Write($"{(int)LogLevel.Warning}:{LogLevel.Warning.ToString().ToUpper()}");
                        break;
                    case LogLevel.Error:
                        Console.ForegroundColor = _config.ErrorColor;
                        Console.Write($"{(int)LogLevel.Error}:{LogLevel.Error.ToString().ToUpper()}");
                        break;
                    case LogLevel.Critical:
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = _config.CriticalColor;
                        Console.Write($"{(int)LogLevel.Critical}:{LogLevel.Critical.ToString().ToUpper()}");
                        break;
                }
                
                // Reset console colors
                Console.ResetColor();

                Console.Write($"] [{_name}] {logMessage}\n");
            }
            catch (Exception ex)
            {
                Console.Write($"[{DateTime.Now:dd/MM/yyyy - HH:mm:ss}] [");
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = _config.CriticalColor;
                Console.Write($"{(int)LogLevel.Critical}:{LogLevel.Critical.ToString().ToUpper()}");
                Console.Write($"] [{_name}] {ex.Message}\n");
            }
        }

        public void LogDefault(string logMessage)
        {
            Log(LogLevel.Default, logMessage);
        }

        public void LogDebug(string logMessage)
        {
            // Log only if project is on 'DEBUG' mode
#if DEBUG
                Log(LogLevel.Debug, logMessage);
#endif
        }

        public void LogInformation(string logMessage)
        {
            Log(LogLevel.Information, logMessage);
        }

        public void LogWarning(string logMessage)
        {
            Log(LogLevel.Warning, logMessage);
        }

        public void LogError(string logMessage)
        {
            Log(LogLevel.Error, logMessage);

            // Save event to file/db?
        }

        public void LogCritical(string logMessage)
        {
            Log(LogLevel.Critical, logMessage);

            // Save event, definitely
        }
    }
}
