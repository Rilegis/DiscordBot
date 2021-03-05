/**********************************************************************
    Author            : Rilegis
    Repository        : DiscordBot
    Project           : DiscordBot.Models
    File name         : Generation.cs
    Date created      : 24/11/2020
    Purpose           : This file contains PokeAPI's 'Generation' structure definition.

    Revision History  :
    Date        Author      Ref     Revision 
    24/11/2020  Rilegis     1       First code commit.
**********************************************************************/

using DiscordBot.Models.PokeAPI.Common;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace DiscordBot.Models.PokeAPI.Game
{
    public struct Generation
    {
        // The identifier for this resource.
        public int Id { get; set; }

        // The name for this resource.
        public string Name { get; set; }

        // A list of abilities that were introduced in this generation.
        public List<NamedAPIResource> Abilities { get; set; }

        // The name of this resource listed in different languages.
        public List<NameType> Names { get; set; }

        // The main region travelled in this generation.
        [JsonProperty("main_region")]
        public NamedAPIResource MainRegion { get; set; }

        // A list of moves that were introduced in this generation.
        public List<NamedAPIResource> Moves { get; set; }

        // A list of Pokémon species that were introduced in this generation.
        [JsonProperty("pokemon_species")]
        public List<NamedAPIResource> PokemonSpecies { get; set; }

        // A list of types that were introduced in this generation.
        public List<NamedAPIResource> Types { get; set; }

        // A list of version groups that were introduced in this generation.
        public List<NamedAPIResource> VersionGroups { get; set; }
    }
}
