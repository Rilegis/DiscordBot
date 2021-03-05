/**********************************************************************
    Author            : Rilegis
    Repository        : DiscordBot
    Project           : DiscordBot.Models
    File name         : EncounterType.cs
    Date created      : 29/11/2020
    Purpose           : This file contains PokeAPI's 'Encounter' structure definition.

    Revision History  :
    Date        Author      Ref     Revision 
    29/11/2020  Rilegis     1       First code commit.
    30/11/2020  Rilegis     2       Moved to 'PokeAPI.Common' namespace.
**********************************************************************/

using Newtonsoft.Json;
using System.Collections.Generic;

namespace DiscordBot.Models.PokeAPI.Common
{
    public struct EncounterType
    {
        // The lowest level the Pokémon could be encountered at.
        [JsonProperty("min_level")]
        public int MinLevel { get; set; }

        // The highest level the Pokémon could be encountered at.
        [JsonProperty("max_level")]
        public int MaxLevel { get; set; }

        // A list of condition values that must be in effect for this encounter to occur.
        [JsonProperty("condition_values")]
        public List<NamedAPIResource> ConditionValues { get; set; }

        // Percent chance that this encounter will occur.
        public int Chance { get; set; }

        // The method by which this encounter happens.
        public NamedAPIResource Method { get; set; }
    }
}
