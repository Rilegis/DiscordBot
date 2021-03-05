/**********************************************************************
    Author            : Rilegis
    Repository        : DiscordBot
    Project           : DiscordBot.Models
    File name         : MoveLearnMethod.cs
    Date created      : 29/11/2020
    Purpose           : This file contains PokeAPI's 'MoveLearnMethod' structure definition.

    Revision History  :
    Date        Author      Ref     Revision 
    29/11/2020  Rilegis     1       First code commit.
**********************************************************************/

using DiscordBot.Models.PokeAPI.Common;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace DiscordBot.Models.PokeAPI.Move
{
    public struct MoveLearnMethod
    {
        // The identifier for this resource.
        public int Id { get; set; }

        // The name for this resource.
        public string Name { get; set; }

        // The description of this resource listed in different languages.
        public List<DescriptionType> Descriptions { get; set; }

        // The name of this resource listed in different languages.
        public List<NameType> Names { get; set; }

        // A list of version groups where moves can be learned through this method.
        [JsonProperty("version_groups")]
        public List<NamedAPIResource> VersionGroups { get; set; }
    }
}
