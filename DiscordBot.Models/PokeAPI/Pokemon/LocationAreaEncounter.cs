/**********************************************************************
    Author            : Rilegis
    Repository        : DiscordBot
    Project           : DiscordBot.Models
    File name         : LocationAreaEncounter.cs
    Date created      : 30/11/2020
    Purpose           : This file contains PokeAPI's 'LocationAreaEncounter' structure definition.

    Revision History  :
    Date        Author      Ref     Revision 
    30/11/2020  Rilegis     1       First code commit.
**********************************************************************/

using DiscordBot.Models.PokeAPI.Common;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace DiscordBot.Models.PokeAPI.Pokemon
{
    public struct LocationAreaEncounter
    {
        //
        [JsonProperty("location_area")]
        public NamedAPIResource LocationArea { get; set; }

        //
        [JsonProperty("version_details")]
        public List<VersionEncounterDetail> VersionDetails { get; set; }
    }
}
