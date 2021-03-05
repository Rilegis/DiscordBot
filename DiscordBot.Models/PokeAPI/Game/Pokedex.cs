/**********************************************************************
    Author            : Rilegis
    Repository        : DiscordBot
    Project           : DiscordBot.Models
    File name         : Pokedex.cs
    Date created      : 24/11/2020
    Purpose           : This file contains PokeAPI's 'Pokedex' structure definition.

    Revision History  :
    Date        Author      Ref     Revision 
    24/11/2020  Rilegis     1       First code commit.
**********************************************************************/

using DiscordBot.Models.PokeAPI.Common;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace DiscordBot.Models.PokeAPI.Game
{
    public struct Pokedex
    {
        // The identifier for this resource.
        public int Id { get; set; }

        // The name for this resource.
        public string Name { get; set; }

        // Whether or not this Pokédex originated in the main series of the video games.
        [JsonProperty("is_main_series")]
        public bool IsMainSeries { get; set; }

        // The description of this resource listed in different languages.
        public List<DescriptionType> Descriptions { get; set; }

        // The name of this resource listed in different languages.
        public List<NameType> Names { get; set; }

        // A list of Pokémon catalogued in this Pokédex and their indexes.
        [JsonProperty("pokemon_entries")]
        public List<PokemonEntry> PokemonEntries { get; set; }

        // The region this Pokédex catalogues Pokémon for.
        public NamedAPIResource Region { get; set; }

        // A list of version groups this Pokédex is relevant to.
        [JsonProperty("version_groups")]
        public List<NamedAPIResource> VersionGroups { get; set; }
    }
}
