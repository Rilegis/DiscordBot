/**********************************************************************
    Author            : Rilegis
    Repository        : DiscordBot
    Project           : DiscordBot.Models
    File name         : PokemonSpeciesVariety.cs
    Date created      : 30/11/2020
    Purpose           : This file contains PokeAPI's 'PokemonSpeciesVariety' structure definition.

    Revision History  :
    Date        Author      Ref     Revision 
    30/11/2020  Rilegis     1       First code commit.
**********************************************************************/

using DiscordBot.Models.PokeAPI.Common;
using Newtonsoft.Json;

namespace DiscordBot.Models.PokeAPI.Pokemon
{
    public struct PokemonSpeciesVariety
    {
        // Whether this variety is the default variety.
        [JsonProperty("is_default")]
        public bool IsDefault { get; set; }

        // The Pokémon variety.
        public NamedAPIResource Pokemon { get; set; }
    }
}