/**********************************************************************
    Author            : Rilegis
    Repository        : DiscordBot
    Project           : DiscordBot.Models
    File name         : Pokemon.cs
    Date created      : 29/11/2020
    Purpose           : This file contains PokeAPI's 'Pokemon' structure definition.

    Revision History  :
    Date        Author      Ref     Revision 
    30/11/2020  Rilegis     1       First code commit.
**********************************************************************/

using DiscordBot.Models.PokeAPI.Common;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace DiscordBot.Models.PokeAPI.Pokemon
{
    public struct Pokemon
    {
        // The identifier for this resource.
        public int Id { get; set; }

        // The name for this resource.
        public string Name { get; set; }

        // The base experience gained for defeating this Pokémon.
        [JsonProperty("base_experience")]
        public int BaseExperience { get; set; }

        // The height of this Pokémon in decimetres.
        public int Height { get; set; }

        // Set for exactly one Pokémon used as the default for each species.
        [JsonProperty("is_default")]
        public bool IsDefault { get; set; }

        // Order for sorting. Almost national order, except families are grouped together.
        public int Order { get; set; }

        // The weight of this Pokémon in hectograms.
        public int Weight { get; set; }

        // A list of abilities this Pokémon could potentially have.
        public List<PokemonAbility> Abilities { get; set; }

        // A list of forms this Pokémon can take on.
        public List<NamedAPIResource> Forms { get; set; }

        // A list of game indices relevent to Pokémon item by generation.
        [JsonProperty("game_indices")]
        public List<VersionGameIndex> GameIndices { get; set; }

        // A list of items this Pokémon may be holding when encountered.
        [JsonProperty("held_items")]
        public List<PokemonHeldItem> HeldItems { get; set; }

        // A link to a list of location areas, as well as encounter details pertaining to specific versions.
        [JsonProperty("location_area_encounters")]
        public string LocationAreaEncounters { get; set; }

        // A list of moves along with learn methods and level details pertaining to specific version groups.
        public List<PokemonMove> Moves { get; set; }

        // A set of sprites used to depict this Pokémon in the game. A visual representation of the various sprites can be found at PokeAPI/sprites
        public PokemonSprites Sprites { get; set; }

        // The species this Pokémon belongs to.
        public NamedAPIResource Species { get; set; }

        // A list of base stat values for this Pokémon.
        public List<PokemonStat> Stats { get; set; }

        // A list of details showing types this Pokémon has.
        public List<PokemonType> Types { get; set; }
    }
}
