/**********************************************************************
    Author            : Rilegis
    Repository        : DiscordBot
    Project           : DiscordBot.Models
    File name         : EggGroup.cs
    Date created      : 29/11/2020
    Purpose           : This file contains PokeAPI's 'EggGroup' structure definition.

    Revision History  :
    Date        Author      Ref     Revision 
    30/11/2020  Rilegis     1       First code commit.
**********************************************************************/

using DiscordBot.Models.PokeAPI.Common;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace DiscordBot.Models.PokeAPI.Pokemon
{
    public struct Genders
    {
        // The identifier for this resource.
        public int Id { get; set; }

        // The name for this resource.
        public string Name { get; set; }

        // A list of Pokémon species that can be this gender and how likely it is that they will be.
        [JsonProperty("pokemon_species_details")]
        public List<PokemonSpeciesGender> PokemonSpeciesDetails { get; set; }

        // A list of Pokémon species that required this gender in order for a Pokémon to evolve into them.
        [JsonProperty("required_for_evolution")]
        public List<NamedAPIResource> RequiredForEvolution { get; set; }
    }
}
