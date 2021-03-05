/**********************************************************************
    Author            : Rilegis
    Repository        : DiscordBot
    Project           : DiscordBot.Models
    File name         : Location.cs
    Date created      : 29/11/2020
    Purpose           : This file contains PokeAPI's 'Location' structure definition.

    Revision History  :
    Date        Author      Ref     Revision 
    29/11/2020  Rilegis     1       First code commit.
**********************************************************************/

using DiscordBot.Models.PokeAPI.Common;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace DiscordBot.Models.PokeAPI.Location
{
    public struct Location
    {
        // The identifier for this resource.
        public int Id { get; set; }

        // The name for this resource.
        public string Name { get; set; }

        // The region this location can be found in.
        public NamedAPIResource Region { get; set; }

        // The name of this resource listed in different languages.
        public List<NameType> Names { get; set; }

        // A list of game indices relevent to this location by generation.
        [JsonProperty("game_indices")]
        public List<GenerationGameIndex> GameIndices { get; set; }

        // Areas that can be found within this location.
        public List<NamedAPIResource> Areas { get; set; }
    }
}
