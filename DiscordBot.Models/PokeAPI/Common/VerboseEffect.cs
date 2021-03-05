/**********************************************************************
    Author            : Rilegis
    Repository        : DiscordBot
    Project           : DiscordBot.Models
    File name         : VerboseEffect.cs
    Date created      : 29/11/2020
    Purpose           : This file contains PokeAPI's 'VerboseEffect' structure definition.

    Revision History  :
    Date        Author      Ref     Revision 
    29/11/2020  Rilegis     1       First code commit.
    30/11/2020  Rilegis     2       Moved to 'PokeAPI.Common' namespace.
**********************************************************************/

using Newtonsoft.Json;

namespace DiscordBot.Models.PokeAPI.Common
{
    public struct VerboseEffect
    {
        // The localized effect text for an API resource in a specific language.
        public string Effect { get; set; }

        // The localized effect text in brief.
        [JsonProperty("short_effect")]
        public string ShortEffect { get; set; }

        // The language this effect is in.
        public NamedAPIResource Language { get; set; }
    }
}
