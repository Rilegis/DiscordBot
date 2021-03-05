/**********************************************************************
    Author            : Rilegis
    Repository        : DiscordBot
    Project           : DiscordBot.Bot
    File name         : EventHandlers.cs
    Date created      : 23/03/2020
    Purpose           : This file contains all event handlers for the bot.

    Revision History  :
    Date        Author      Ref     Revision 
    23/03/2020  Rilegis     1       First code commit.
    11/04/2020  Rilegis     2       Added 'Disconnected' task.
    09/02/2021  Rilegis     3       Added [Obsolete] tags to Connected, Disconnected
                                    LoggedIn, LoggedOut, Ready event handlers.
**********************************************************************/

using System;
using System.Threading.Tasks;
using DiscordBot.Models.Logging;

namespace DiscordBot.Bot
{
    public static class EventHandlers
    {
        [Obsolete(DiagnosticId = "Use of obsolete 'EventHandlers.Connected()' detected. Please refrain from using this.")]
        public static async Task Connected()
        {
            await Logger.Log($"[+]", "Connected to Discord Gateway.");
        }

        [Obsolete(DiagnosticId = "Use of obsolete 'EventHandlers.Disconnected(Exception ex)' detected. Please refrain from using this.")]
        public static async Task Disconnected(Exception ex)
        {
            await Logger.Log($"[+]", $"Disconnected from Discord Gateway with message: {ex.Message}");
        }

        [Obsolete(DiagnosticId = "Use of obsolete 'EventHandlers.LoggedIn()' detected. Please refrain from using this.")]
        public static async Task LoggedIn()
        {
            await Logger.Log($"[+]", "Successfully logged in to Discord!");
        }

        [Obsolete(DiagnosticId = "Use of obsolete 'EventHandlers.LoggedOut()' detected. Please refrain from using this.")]
        public static async Task LoggedOut()
        {
            await Logger.Log($"[+]", "Successfully logged out from Discord!");
        }

        [Obsolete(DiagnosticId = "Use of obsolete 'EventHandlers.Ready()' detected. Please refrain from using this.")]
        public static async Task Ready()
        {
            await Logger.Log($"[+]", "Bot is now ready!");
        }
    }
}
