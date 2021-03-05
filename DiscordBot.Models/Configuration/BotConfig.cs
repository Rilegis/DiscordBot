/**********************************************************************
    Author            : Rilegis
    Repository        : DiscordBot
    Project           : DiscordBot.Models
    File name         : BotConfig.cs
    Date created      : 22/03/2020
    Purpose           : This file contains the bot's config structure definition.

    Revision History  :
    Date        Author      Ref     Revision 
    23/03/2020  Rilegis     1       First code commit.
    24/03/2020  Rilegis     2       Changed configuration file structure.
    01/04/2020  Rilegis     3       Changed 'Trigger' to 'Prefix'.
    10/11/2020  Rilegis     4       Moved 'Config' struct to it's own model.
    22/11/2020  Rilegis     5       Renamed 'Config' to 'BotConfig'.
    23/11/2020  Rilegis     6       Changed configuration file structure.
    05/03/2021  Rilegis     7       Added command cooldown config option.
**********************************************************************/

using Newtonsoft.Json;

namespace DiscordBot.Models.Configuration
{
    public struct BotConfig
    {
        public Bot Bot { get; set; }
    }

    public struct Bot
    {
        public string Token { get; set; }

        [JsonProperty("prefix")]
        public string CommandPrefix { get; set; }

        public int CommandCooldown { get; set; }
    }
}