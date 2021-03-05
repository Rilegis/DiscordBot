/**********************************************************************
    Author            : Rilegis
    Repository        : DiscordBot
    Project           : DiscordBot.Models
    File name         : AwesomeNameType.cs
    Date created      : 30/11/2020
    Purpose           : This file contains PokeAPI's 'AwesomeNameType' structure definition.

    Revision History  :
    Date        Author      Ref     Revision 
    30/11/2020  Rilegis     1       First code commit.
**********************************************************************/

using DiscordBot.Models.PokeAPI.Common;
using Newtonsoft.Json;

namespace DiscordBot.Models.PokeAPI.Pokemon
{
    public struct AwesomeNameType
    {
        // The localized "scientific" name for an API resource in a specific language.
        [JsonProperty("awesome_name")]
        public string AwesomeName { get; set; }

        // The language this "scientific" name is in.
        public NamedAPIResource Language { get; set; }
    }
}