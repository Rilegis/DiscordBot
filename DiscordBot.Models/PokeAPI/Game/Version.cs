/**********************************************************************
    Author            : Rilegis
    Repository        : DiscordBot
    Project           : DiscordBot.Models
    File name         : Version.cs
    Date created      : 24/11/2020
    Purpose           : This file contains PokeAPI's 'Version' structure definition.

    Revision History  :
    Date        Author      Ref     Revision 
    24/11/2020  Rilegis     1       First code commit.
**********************************************************************/

using DiscordBot.Models.PokeAPI.Common;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace DiscordBot.Models.PokeAPI.Game
{
    public struct Version
    {
        // The identifier for this resource.
        public int Id { get; set; }

        // The name for this resource.
        public string Name { get; set; }

        // The name of this resource listed in different languages.
        public List<NameType> Names { get; set; }

        // The version group this version belongs to.
        [JsonProperty("version_group")]
        public NamedAPIResource VersionGroup { get; set; }
    }
}
