/**********************************************************************
    Author            : Rilegis
    Repository        : DiscordBot
    Project           : DiscordBot.Models
    File name         : AbilityFlavorText.cs
    Date created      : 29/11/2020
    Purpose           : This file contains PokeAPI's 'AbilityFlavorText' structure definition.

    Revision History  :
    Date        Author      Ref     Revision 
    30/11/2020  Rilegis     1       First code commit.
**********************************************************************/

using DiscordBot.Models.PokeAPI.Common;
using Newtonsoft.Json;

namespace DiscordBot.Models.PokeAPI.Pokemon
{
    public struct AbilityFlavorText
    {
        // The localized name for an API resource in a specific language.
        [JsonProperty("flavor_text")]
        public string FlavorText { get; set; }

        // The language this text resource is in.
        public NamedAPIResource Language { get; set; }

        // The version group that uses this flavor text.
        [JsonProperty("version_group")]
        public NamedAPIResource VersionGroup { get; set; }
    }
}