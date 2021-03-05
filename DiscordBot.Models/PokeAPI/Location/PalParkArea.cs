/**********************************************************************
    Author            : Rilegis
    Repository        : DiscordBot
    Project           : DiscordBot.Models
    File name         : PalParkArea.cs
    Date created      : 29/11/2020
    Purpose           : This file contains PokeAPI's 'PalParkArea' structure definition.

    Revision History  :
    Date        Author      Ref     Revision 
    29/11/2020  Rilegis     1       First code commit.
**********************************************************************/

using DiscordBot.Models.PokeAPI.Common;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace DiscordBot.Models.PokeAPI.Location
{
    public struct PalParkArea
    {
        // The identifier for this resource.
        public int Id { get; set; }

        // The name for this resource.
        public string Name { get; set; }

        // The name of this resource listed in different languages.
        public List<NameType> Names { get; set; }

        // A list of Pokémon encountered in thi pal park area along with details.
        [JsonProperty("pokemon_encounters")]
        public List<PalParkEncounterSpecies> PokemonEncounters { get; set; }
    }
}
