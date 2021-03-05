/**********************************************************************
    Author            : Rilegis
    Repository        : DiscordBot
    Project           : DiscordBot.Models
    File name         : LocationArea.cs
    Date created      : 29/11/2020
    Purpose           : This file contains PokeAPI's 'LocationArea' structure definition.

    Revision History  :
    Date        Author      Ref     Revision 
    29/11/2020  Rilegis     1       First code commit.
**********************************************************************/

using DiscordBot.Models.PokeAPI.Common;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace DiscordBot.Models.PokeAPI.Location
{
    public struct LocationArea
    {
        // The identifier for this resource.
        public int Id { get; set; }

        // The name for this resource.
        public string Name { get; set; }

        // The internal id of an API resource within game data.
        [JsonProperty("game_index")]
        public int GameIndex { get; set; }

        // A list of methods in which Pokémon may be encountered in this area and how likely the method will occur depending on the version of the game.
        public List<EncounterMethodRate> EncounterMethodRates { get; set; }

        // The region this location area can be found in.
        public NamedAPIResource Location { get; set; }

        // The name of this resource listed in different languages.
        public List<NameType> Names { get; set; }

        // A list of Pokémon that can be encountered in this area along with version specific details about the encounter.
        [JsonProperty("pokemon_encounters")]
        public List<PokemonEncounter> PokemonEncounters { get; set; }
    }
}
