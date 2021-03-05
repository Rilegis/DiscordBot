/**********************************************************************
    Author            : Rilegis
    Repository        : DiscordBot
    Project           : DiscordBot.Models
    File name         : VersionGroupFlavorText.cs
    Date created      : 29/11/2020
    Purpose           : This file contains PokeAPI's 'VersionGroupFlavorText' structure definition.

    Revision History  :
    Date        Author      Ref     Revision 
    29/11/2020  Rilegis     1       First code commit.
    30/11/2020  Rilegis     2       Moved to 'PokeAPI.Common' namespace.
**********************************************************************/

using Newtonsoft.Json;

namespace DiscordBot.Models.PokeAPI.Common
{
    public struct VersionGroupFlavorText
    {
        // The localized name for an API resource in a specific language.
        public string Text { get; set; }

        // The language this name is in.
        public NamedAPIResource Language { get; set; }

        // The version group which uses this flavor text.
        [JsonProperty("version_group")]
        public NamedAPIResource VersionGroup { get; set; }
    }
}
