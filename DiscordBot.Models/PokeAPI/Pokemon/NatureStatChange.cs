/**********************************************************************
    Author            : Rilegis
    Repository        : DiscordBot
    Project           : DiscordBot.Models
    File name         : NatureStatChange.cs
    Date created      : 29/11/2020
    Purpose           : This file contains PokeAPI's 'NatureStatChange' structure definition.

    Revision History  :
    Date        Author      Ref     Revision 
    30/11/2020  Rilegis     1       First code commit.
**********************************************************************/

using DiscordBot.Models.PokeAPI.Common;
using Newtonsoft.Json;

namespace DiscordBot.Models.PokeAPI.Pokemon
{
    public struct NatureStatChange
    {
        // The amount of change.
        [JsonProperty("max_change")]
        public int MaxChange { get; set; }

        // The stat being affected.
        [JsonProperty("pokeathlon_stat")]
        public NamedAPIResource PokeathlonStat { get; set; }
    }
}