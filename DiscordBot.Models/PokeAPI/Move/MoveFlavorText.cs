/**********************************************************************
    Author            : Rilegis
    Repository        : DiscordBot
    Project           : DiscordBot.Models
    File name         : MoveFlavorText.cs
    Date created      : 29/11/2020
    Purpose           : This file contains PokeAPI's 'MoveFlavorText' structure definition.

    Revision History  :
    Date        Author      Ref     Revision 
    29/11/2020  Rilegis     1       First code commit.
**********************************************************************/

using DiscordBot.Models.PokeAPI.Common;
using Newtonsoft.Json;

namespace DiscordBot.Models.PokeAPI.Move
{
    public struct MoveFlavorText
    {
        // The localized flavor text for an api resource in a specific language.
        [JsonProperty("flavor_text")]
        public string FlavorText { get; set; }

        // The language this name is in.
        public NamedAPIResource Language { get; set; }

        // The version group that uses this flavor text.
        [JsonProperty("version_group")]
        public NamedAPIResource VersionGroup { get; set; }
    }
}