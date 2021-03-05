/**********************************************************************
    Author            : Rilegis
    Repository        : DiscordBot
    Project           : DiscordBot.Models
    File name         : VersionGameIndex.cs
    Date created      : 30/11/2020
    Purpose           : This file contains PokeAPI's 'VersionGameIndex' structure definition.

    Revision History  :
    Date        Author      Ref     Revision 
    30/11/2020  Rilegis     1       First code commit.
    30/11/2020  Rilegis     2       Moved to 'PokeAPI.Common' namespace.
**********************************************************************/

using Newtonsoft.Json;

namespace DiscordBot.Models.PokeAPI.Common
{
    public struct VersionGameIndex
    {
        // The internal id of an API resource within game data.
        [JsonProperty("game_index")]
        public int GameIndex { get; set; }

        // The version relevent to this game index.
        public NamedAPIResource Version { get; set; }
    }
}
