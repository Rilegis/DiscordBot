/**********************************************************************
    Author            : Rilegis
    Repository        : DiscordBot
    Project           : DiscordBot.Models
    File name         : SuperContestEffect.cs
    Date created      : 23/11/2020
    Purpose           : This file contains PokeAPI's 'SuperContestEffect' structure definition.

    Revision History  :
    Date        Author      Ref     Revision 
    23/11/2020  Rilegis     1       First code commit.
**********************************************************************/

using DiscordBot.Models.PokeAPI.Common;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace DiscordBot.Models.PokeAPI.Contest
{
    public struct SuperContestEffect
    {
        // The identifier for this resource.
        public int Id { get; set; }

        // The level of appeal this super contest effect has.
        public int Appeal { get; set; }

        // The flavor text of this super contest effect listed in different languages.
        [JsonProperty("flavor_text_entries")]
        public List<FlavorTextType> FlavorTextEntries { get; set; }

        // A list of moves that have the effect when used in super contests.
        public List<NamedAPIResource> Moves { get; set; }
    }
}
