/**********************************************************************
    Author            : Rilegis
    Repository        : DiscordBot
    Project           : DiscordBot.Models
    File name         : ContestType.cs
    Date created      : 23/11/2020
    Purpose           : This file contains PokeAPI's 'ContestType' structure definition.

    Revision History  :
    Date        Author      Ref     Revision 
    23/11/2020  Rilegis     1       First code commit.
**********************************************************************/

using DiscordBot.Models.PokeAPI.Common;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace DiscordBot.Models.PokeAPI.Contest
{
    public struct ContestType
    {
        // The identifier for this resource.
        public int Id { get; set; }

        // The name for this resource
        public string Name { get; set; }

        // The berry flavor that correlates with this contest type.
        [JsonProperty("berry_flavor")]
        public NamedAPIResource BerryFlavor { get; set; }

        // The name of this contest type listed in different languages.
        public List<ContestName> Names { get; set; }
    }
}
