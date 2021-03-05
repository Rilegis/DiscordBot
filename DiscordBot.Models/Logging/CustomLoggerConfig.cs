/**********************************************************************
    Author            : Rilegis
    Repository        : DiscordBot
    Project           : DiscordBot.Models
    File name         : CustomLogger.cs
    Date created      : 22/02/2021
    Purpose           : This file contains the definition for the custom
                        logger's confiugurator class.

    Revision History  :
    Date        Author      Ref     Revision 
    22/02/2021  Rilegis     1       First code commit.
**********************************************************************/

using System;

namespace DiscordBot.Models.Logging
{
    public class CustomLoggerConfig
    {
        // Log levels colors
        public ConsoleColor DefaultColor { get; set; } = ConsoleColor.White;
        public ConsoleColor DebugColor { get; set; } = ConsoleColor.Cyan;
        public ConsoleColor InfoColor { get; set; } = ConsoleColor.Green;
        public ConsoleColor WarnColor { get; set; } = ConsoleColor.Yellow;
        public ConsoleColor ErrorColor { get; set; } = ConsoleColor.Red;
        public ConsoleColor CriticalColor { get; set; } = ConsoleColor.Black;
    }
}
