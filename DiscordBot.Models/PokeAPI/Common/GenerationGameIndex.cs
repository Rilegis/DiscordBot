/**********************************************************************
    Author            : Rilegis
    Repository        : DiscordBot
    Project           : DiscordBot.Models
    File name         : GenerationGameIndex.cs
    Date created      : 29/11/2020
    Purpose           : This file contains PokeAPI's 'GenerationGameIndex' structure definition.

    Revision History  :
    Date        Author      Ref     Revision 
    29/11/2020  Rilegis     1       First code commit.
    30/11/2020  Rilegis     2       Moved to 'PokeAPI.Common' namespace.
**********************************************************************/

using Newtonsoft.Json;

namespace DiscordBot.Models.PokeAPI.Common
{
    public struct GenerationGameIndex
    {
        // The internal id of an API resource within game data.
        [JsonProperty("game_index")]
        public int GameIndex { get; set; }

        // The generation relevent to this game index.
        public NamedAPIResource Generation { get; set; }
    }
}
