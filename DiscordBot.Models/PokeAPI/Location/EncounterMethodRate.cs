/**********************************************************************
    Author            : Rilegis
    Repository        : DiscordBot
    Project           : DiscordBot.Models
    File name         : EncounterMethodRate.cs
    Date created      : 29/11/2020
    Purpose           : This file contains PokeAPI's 'EncounterMethodRate' structure definition.

    Revision History  :
    Date        Author      Ref     Revision 
    29/11/2020  Rilegis     1       First code commit.
**********************************************************************/

using DiscordBot.Models.PokeAPI.Common;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace DiscordBot.Models.PokeAPI.Location
{
    public struct EncounterMethodRate
    {
        // The method in which Pokémon may be encountered in an area.
        [JsonProperty("encounter_method")]
        public NamedAPIResource EncounterMethod { get; set; }

        // The chance of the encounter to occur on a version of the game.
        [JsonProperty("version_details")]
        public List<EncounterVersionDetails> VersionDetails { get; set; }
    }
}