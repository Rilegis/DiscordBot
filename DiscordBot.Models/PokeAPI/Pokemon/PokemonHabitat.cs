/**********************************************************************
    Author            : Rilegis
    Repository        : DiscordBot
    Project           : DiscordBot.Models
    File name         : PokemonHabitat.cs
    Date created      : 30/11/2020
    Purpose           : This file contains PokeAPI's 'PokemonHabitat' structure definition.

    Revision History  :
    Date        Author      Ref     Revision 
    30/11/2020  Rilegis     1       First code commit.
**********************************************************************/

using DiscordBot.Models.PokeAPI.Common;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace DiscordBot.Models.PokeAPI.Pokemon
{
    public struct PokemonHabitat
    {
        // The identifier for this resource.
        public int Id { get; set; }

        // The name for this resource.
        public string Name { get; set; }

        // The name of this resource listed in different languages.
        public List<NameType> Names { get; set; }

        // A list of the Pokémon species that can be found in this habitat.
        [JsonProperty("pokemon_species")]
        public List<NamedAPIResource> PokemonSpecies { get; set; }
    }
}
