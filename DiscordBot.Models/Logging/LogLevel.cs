/**********************************************************************
    Author            : Rilegis
    Repository        : DiscordBot
    Project           : DiscordBot.Models
    File name         : LogLevel.cs
    Date created      : 22/02/2021
    Purpose           : This file contains the definition for the custom
                        logger 'LogLevel' enum implementation.

    Revision History  :
    Date        Author      Ref     Revision 
    22/02/2021  Rilegis     1       First code commit.
**********************************************************************/

namespace DiscordBot.Models.Logging
{
    public enum LogLevel
    {
        Default = 0,
        Debug = 1,
        Information = 2,
        Warning = 3,
        Error = 4,
        Critical = 5
    }
}
