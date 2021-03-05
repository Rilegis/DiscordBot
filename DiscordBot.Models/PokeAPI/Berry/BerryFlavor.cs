/**********************************************************************
    Author            : Rilegis
    Repository        : DiscordBot
    Project           : DiscordBot.Models
    File name         : BerryFlavor.cs
    Date created      : 23/11/2020
    Purpose           : This file contains PokeAPI's 'BerryFlavor' structure definition.

    Revision History  :
    Date        Author      Ref     Revision 
    23/11/2020  Rilegis     1       First code commit.
**********************************************************************/

using DiscordBot.Models.PokeAPI.Common;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace DiscordBot.Models.PokeAPI.Berry
{
    public struct BerryFlavor
    {
        // The identifier for this resource.
        public int Id { get; set; }

        // The name for this resource
        public string Name { get; set; }

        // A list of the berries with this flavor.
        public List<FlavorBerryMap> Berries { get; set; }

        // The contest type that correlates with this berry flavor.
        [JsonProperty("contest_type")]
        public NamedAPIResource ContestType { get; set; }

        // The name of this resource listed in different languages.
        public List<NameType> Names { get; set; }
    }
}
