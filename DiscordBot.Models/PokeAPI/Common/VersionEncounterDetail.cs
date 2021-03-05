/**********************************************************************
    Author            : Rilegis
    Repository        : DiscordBot
    Project           : DiscordBot.Models
    File name         : VersionEncounterDetail.cs
    Date created      : 29/11/2020
    Purpose           : This file contains PokeAPI's 'VersionEncounterDetail' structure definition.

    Revision History  :
    Date        Author      Ref     Revision 
    29/11/2020  Rilegis     1       First code commit.
    30/11/2020  Rilegis     2       Moved to 'PokeAPI.Common' namespace.
**********************************************************************/

using Newtonsoft.Json;
using System.Collections.Generic;

namespace DiscordBot.Models.PokeAPI.Common
{
    public struct VersionEncounterDetail
    {
        // The game version this encounter happens in.
        public NamedAPIResource Version { get; set; }

        // The total percentage of all encounter potential.
        [JsonProperty("max_chance")]
        public int MaxChance { get; set; }

        // A list of encounters and their specifics.
        [JsonProperty("encounter_details")]
        public List<EncounterType> EncounterDetails { get; set; }
    }
}
