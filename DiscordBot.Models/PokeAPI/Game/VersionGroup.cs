/**********************************************************************
    Author            : Rilegis
    Repository        : DiscordBot
    Project           : DiscordBot.Models
    File name         : VersionGroup.cs
    Date created      : 24/11/2020
    Purpose           : This file contains PokeAPI's 'VersionGroup' structure definition.

    Revision History  :
    Date        Author      Ref     Revision 
    24/11/2020  Rilegis     1       First code commit.
**********************************************************************/

using DiscordBot.Models.PokeAPI.Common;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace DiscordBot.Models.PokeAPI.Game
{
    public struct VersionGroup
    {
        // The identifier for this resource.
        public int Id { get; set; }

        // The name for this resource.
        public string Name { get; set; }

        // Order for sorting. Almost by date of release, except similar versions are grouped together.
        public string Order { get; set; }

        // The generation this version was introduced in.
        public NamedAPIResource Generation { get; set; }

        // A list of methods in which Pokémon can learn moves in this version group.
        [JsonProperty("move_learn_methods")]
        public List<NamedAPIResource> MoveLearnMethod { get; set; }

        // A list of Pokédexes introduces in this version group.
        public List<NamedAPIResource> Pokedexes { get; set; }

        // A list of regions that can be visited in this version group.
        public List<NamedAPIResource> Regions { get; set; }

        // The versions this version group owns.
        public List<NamedAPIResource> Versions { get; set; }
    }
}
