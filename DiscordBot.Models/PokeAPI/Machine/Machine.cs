/**********************************************************************
    Author            : Rilegis
    Repository        : DiscordBot
    Project           : DiscordBot.Models
    File name         : Machine.cs
    Date created      : 29/11/2020
    Purpose           : This file contains PokeAPI's 'Machine' structure definition.

    Revision History  :
    Date        Author      Ref     Revision 
    29/11/2020  Rilegis     1       First code commit.
**********************************************************************/

using DiscordBot.Models.PokeAPI.Common;
using Newtonsoft.Json;

namespace DiscordBot.Models.PokeAPI.Machine
{
    public struct Machine
    {
        // The identifier for this resource.
        public int Id { get; set; }

        // The TM or HM item that corresponds to this machine.
        public NamedAPIResource Item { get; set; }

        // The move that is taught by this machine.
        public NamedAPIResource Move { get; set; }

        // The version group that this machine applies to.
        [JsonProperty("version_group")]
        public NamedAPIResource VersionGroup { get; set; }
    }
}
