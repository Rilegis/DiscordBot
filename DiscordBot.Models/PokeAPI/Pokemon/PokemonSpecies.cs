/**********************************************************************
    Author            : Rilegis
    Repository        : DiscordBot
    Project           : DiscordBot.Models
    File name         : PokemonSpecies.cs
    Date created      : 30/11/2020
    Purpose           : This file contains PokeAPI's 'PokemonSpecies' structure definition.

    Revision History  :
    Date        Author      Ref     Revision 
    30/11/2020  Rilegis     1       First code commit.
**********************************************************************/

using DiscordBot.Models.PokeAPI.Common;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace DiscordBot.Models.PokeAPI.Pokemon
{
    public struct PokemonSpecies
    {
        // The identifier for this resource.
        public int Id { get; set; }

        // The name for this resource.
        public string Name { get; set; }

        // The order in which species should be sorted. Based on National Dex order, except families are grouped together and sorted by stage.
        public int Order { get; set; }

        // The chance of this Pokémon being female, in eighths; or -1 for genderless.
        [JsonProperty("gender_rate")]
        public int GenderRate { get; set; }

        // The base capture rate; up to 255. The higher the number, the easier the catch.
        [JsonProperty("capture_rate")]
        public int CaptureRate { get; set; }

        // The happiness when caught by a normal Pokéball; up to 255. The higher the number, the happier the Pokémon.
        [JsonProperty("base_happiness")]
        public int BaseHappiness { get; set; }

        // Whether or not this is a baby Pokémon.
        [JsonProperty("is_baby")]
        public bool IsBaby { get; set; }

        // Whether or not this is a legendary Pokémon.
        [JsonProperty("is_legendary")]
        public bool IsLegendary { get; set; }

        // Whether or not this is a mythical Pokémon.
        [JsonProperty("is_mythical")]
        public bool IsMythical { get; set; }

        // Initial hatch counter: one must walk 255 × (hatch_counter + 1) steps before this Pokémon's egg hatches, unless utilizing bonuses like Flame Body's.
        [JsonProperty("hatch_counter")]
        public int HatchCounter { get; set; }

        // Whether or not this Pokémon has visual gender differences.
        [JsonProperty("has_gender_differences")]
        public bool HasGenderDifferences { get; set; }

        // Whether or not this Pokémon has multiple forms and can switch between them.
        [JsonProperty("forms_switchable")]
        public bool FormsSwitchable { get; set; }

        // The rate at which this Pokémon species gains levels.
        [JsonProperty("growth_rate")]
        public NamedAPIResource GrowthRate { get; set; }

        // A list of Pokedexes and the indexes reserved within them for this Pokémon species.
        [JsonProperty("pokedex_numbers")]
        public List<PokemonSpeciesDexEntry> PokedexNumbers { get; set; }

        // A list of egg groups this Pokémon species is a member of.
        [JsonProperty("egg_groups")]
        public List<NamedAPIResource> EggGroups { get; set; }

        // The color of this Pokémon for Pokédex search.
        public NamedAPIResource Color { get; set; }

        // The shape of this Pokémon for Pokédex search.
        public NamedAPIResource Shape { get; set; }

        // The Pokémon species that evolves into this Pokemon species.
        [JsonProperty("evolves_from_species")]
        public NamedAPIResource EvolvesFromSpecies { get; set; }

        // The evolution chain this Pokémon species is a member of.
        [JsonProperty("evolution_chain")]
        public APIResource EvolutionChain { get; set; }

        // The habitat this Pokémon species can be encountered in.
        public NamedAPIResource Habitat { get; set; }

        // The generation this Pokémon species was introduced in.
        public NamedAPIResource Generation { get; set; }

        // The name of this resource listed in different languages.
        public List<NameType> Names { get; set; }

        // A list of encounters that can be had with this Pokémon species in pal park.
        [JsonProperty("pal_park_encounters")]
        public List<PalParkEncounterArea> PalParkEncounters { get; set; }

        // A list of flavor text entries for this Pokémon species.
        [JsonProperty("flavor_text_entries")]
        public List<FlavorTextType> FlavorTextEntries { get; set; }

        // Descriptions of different forms Pokémon take on within the Pokémon species.
        [JsonProperty("form_descriptions")]
        public List<DescriptionType> Descriptions { get; set; }

        // The genus of this Pokémon species listed in multiple languages.
        public List<GenusType> Genera { get; set; }

        // A list of the Pokémon that exist within this Pokémon species.
        public List<PokemonSpeciesVariety> Varieties { get; set; }
    }
}
