/**********************************************************************
    Author            : Rilegis
    Repository        : DiscordBot
    Project           : DiscordBot.Models
    File name         : Logger.cs
    Date created      : 23/03/2020
    Purpose           : This file contains loggers methods.

    Revision History  :
    Date        Author      Ref     Revision 
    23/03/2020  Rilegis     1       First code commit.
    22/11/2020  Rilegis     2       Converted 'void' methods to Tasks.
    22/11/2020  Rilegis     3       Moved 'Logger' class to 'DiscordBot.Models' from 'DiscordBot.Bot'
    22/02/2020  Rilegis     4       Officially discontinued this 'Logger' class.
**********************************************************************/

using System;
using System.IO;
using System.Threading.Tasks;

namespace DiscordBot.Models.Logging
{
    [Obsolete("Officially discontinued class. Please switch to 'DiscordBot.Models.Logging.CustomLogger'.", true)]
    public static class Logger
    {
        private static string _dateTime;

        public static Task ExceptionLogger(Exception ex)
        {
            if (!Directory.Exists("./logs/exceptions")) Directory.CreateDirectory("./logs/exceptions");

            _dateTime = DateTime.Now.ToString("[dd/MM/yyyy - HH:mm:ss]");
            Console.Error.WriteLine($"{_dateTime}\tERROR! Showing stack trace:\n{ex}\n{_dateTime}\tSaving stack trace...");
            // Dump stack trace on a file
            var fileName = $"EXCEPTION_{DateTime.Now:ddMMyy_HHmmss}.log";
            using (StreamWriter file = new StreamWriter($"./logs/exceptions/{fileName}", true))
            {
                file.WriteLine(ex.ToString());
                file.Dispose();
                file.Close();
            }

            return Task.CompletedTask;
        }

        public static Task EventLogger(string ev)
        {
            if (!Directory.Exists("./logs")) Directory.CreateDirectory("./logs");

            _dateTime = DateTime.Now.ToString("[dd/MM/yyyy - HH:mm:ss]");
            using (StreamWriter file = File.AppendText($"./logs/events.log"))
            {
                file.WriteLine($"{_dateTime} {ev}");
                file.Dispose();
                file.Close();
            }

            return Task.CompletedTask;
        }

        public static Task SocketErrorLogger(string error)
        {
            if (!Directory.Exists("./logs/socketerrors")) Directory.CreateDirectory("./logs/socketerrors");

            // Dump error on a file
            var fileName = $"SOCKETERROR_{DateTime.Now:ddMMyy_HHmmss}.log";
            using (StreamWriter file = new StreamWriter($"./logs/socketerrors/{fileName}", true))
            {
                file.WriteLine(error);
                file.Dispose();
                file.Close();
            }

            return Task.CompletedTask;
        }

        // Examples:
        // Logger.Log("[+]", "Checking folder system...");
        // Logger.Log("'etc' folder not found...creating a new one.");
        // Logger.Log("Done.");
        public static Task Log(string log)
        {
            _dateTime = DateTime.Now.ToString("[dd/MM/yyyy - HH:mm:ss]");
            Console.WriteLine($"{_dateTime}     {log}");

            return Task.CompletedTask;
        }

        public static Task Log(string mode, string log)
        {
            _dateTime = DateTime.Now.ToString("[dd/MM/yyyy - HH:mm:ss]");
            Console.WriteLine($"{_dateTime} {mode} {log}");

            return Task.CompletedTask;
        }
    }
}

