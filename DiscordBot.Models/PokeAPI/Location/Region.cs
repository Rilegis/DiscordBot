/**********************************************************************
    Author            : Rilegis
    Repository        : DiscordBot
    Project           : DiscordBot.Models
    File name         : PalParkEncounterSpecies.cs
    Date created      : 29/11/2020
    Purpose           : This file contains PokeAPI's 'PalParkEncounterSpecies' structure definition.

    Revision History  :
    Date        Author      Ref     Revision 
    29/11/2020  Rilegis     1       First code commit.
**********************************************************************/

using DiscordBot.Models.PokeAPI.Common;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace DiscordBot.Models.PokeAPI.Location
{
    public struct Region
    {
        // The identifier for this resource.
        public int Id { get; set; }

        // A list of locations that can be found in this region.
        public List<NamedAPIResource> Locations { get; set; }

        // The name for this resource.
        public string Name { get; set; }

        // The name of this resource listed in different languages.
        public List<NameType> Names { get; set; }

        // The generation this region was introduced in.
        [JsonProperty("main_generation")]
        public NamedAPIResource MainGeneration { get; set; }

        // A list of pokédexes that catalogue Pokémon in this region.
        public List<NamedAPIResource> Pokedexes { get; set; }

        // A list of version groups where this region can be visited.
        [JsonProperty("version_groups")]
        public List<NamedAPIResource> VersionGroups { get; set; }
    }
}
