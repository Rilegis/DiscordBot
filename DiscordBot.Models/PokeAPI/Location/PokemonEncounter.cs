/**********************************************************************
    Author            : Rilegis
    Repository        : DiscordBot
    Project           : DiscordBot.Models
    File name         : PokemonEncounter.cs
    Date created      : 29/11/2020
    Purpose           : This file contains PokeAPI's 'PokemonEncounter' structure definition.

    Revision History  :
    Date        Author      Ref     Revision 
    29/11/2020  Rilegis     1       First code commit.
**********************************************************************/

using DiscordBot.Models.PokeAPI.Common;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace DiscordBot.Models.PokeAPI.Location
{
    public struct PokemonEncounter
    {
        // The Pokémon being encountered.
        public NamedAPIResource Pokemon { get; set; }

        // A list of versions and encounters with Pokémon that might happen in the referenced location area.
        [JsonProperty("version_details")]
        public List<VersionEncounterDetail> VersionDetails { get; set; }
    }
}