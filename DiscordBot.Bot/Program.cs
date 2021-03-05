/**********************************************************************
    Author            : Rilegis
    Repository        : DiscordBot
    Project           : DiscordBot.Bot
    File name         : Program.cs
    Date created      : 23/03/2020
    Purpose           : This is the entry point for the application.

    Revision History  :
    Date        Author      Ref     Revision 
    23/03/2020  Rilegis     1       First code commit.
    10/11/2020  Rilegis     2       Recreated repo due to heavy structure changes.
    09/02/2021  Rilegis     3       Changed 'new Client().Run().GetAwaiter().GetResult();' to
                                    'new Client().RunAsync().GetAwaiter().GetResult();'
    22/02/2021  Rilegis     4       Switched logging to simple custom logger, because i do not like
                                    Microsoft's own.
**********************************************************************/

using System;
using System.IO;
using DiscordBot.Models.Logging;

namespace DiscordBot.Bot
{
    class Program
    {
        // Variables declaration
        private static readonly CustomLogger _logger = new CustomLogger(new CustomLoggerConfig(), "Program");

        static void Main(string[] args)
        {
            // Print MOTD
            Console.WriteLine(File.ReadAllText("./etc/motd"));

            // Check if folder system is intact
            _logger.LogInformation("Checking folder system...");

            // Make sure 'etc' folder exists
            if (!Directory.Exists("./etc"))
            {
                _logger.LogInformation("'etc' folder not found...creating a new one.");

                Directory.CreateDirectory("./etc");
                // Add methos to generate config file.
                // W.I.P
            }
            // Make sure 'logs' folder exists
            if (!Directory.Exists("./logs"))
            {
                _logger.LogInformation("'logs' folder not found...creating a new one.");

                Directory.CreateDirectory("./logs");
            }
            _logger.LogInformation("Done.");

            // Start the bot
            new Client().RunAsync().GetAwaiter().GetResult();
        }
    }
}
