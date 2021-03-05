/**********************************************************************
    Author            : Rilegis
    Repository        : DiscordBot
    Project           : DiscordBot.Models
    File name         : PokemonSpeciesGender.cs
    Date created      : 29/11/2020
    Purpose           : This file contains PokeAPI's 'PokemonSpeciesGender' structure definition.

    Revision History  :
    Date        Author      Ref     Revision 
    30/11/2020  Rilegis     1       First code commit.
**********************************************************************/

using DiscordBot.Models.PokeAPI.Common;
using Newtonsoft.Json;

namespace DiscordBot.Models.PokeAPI.Pokemon
{
    public struct PokemonSpeciesGender
    {
        // The chance of this Pokémon being female, in eighths; or -1 for genderless.
        public int Rate { get; set; }

        // A Pokémon species that can be the referenced gender.
        [JsonProperty("pokemon_species")]
        public NamedAPIResource PokemonSpecies { get; set; }
    }
}