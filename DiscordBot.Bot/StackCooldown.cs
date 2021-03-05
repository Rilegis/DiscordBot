/**********************************************************************
    Author            : Rilegis
    Repository        : DiscordBot
    Project           : DiscordBot.Bot
    File name         : StackCooldown.cs
    Date created      : 16/02/2021
    Purpose           : This file contains the definition for the 'StackCooldown'
                        class, used to implement per-user command cooldown.

    Revision History  :
    Date        Author      Ref     Revision 
    16/02/2021  Rilegis     1       First code commit.
    05/03/2021  Rilegis     2       Changed class structure.
**********************************************************************/

using System;
using System.Collections.Generic;
using Discord.WebSocket;

namespace DiscordBot.Bot
{
    public class StackCooldown
    {
        public List<SocketUser> userStack = new List<SocketUser>();
        public List<DateTime> lastCommandAt = new List<DateTime>();
    }
}
