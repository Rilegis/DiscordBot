/**********************************************************************
    Author            : Rilegis
    Repository        : DiscordBot
    Project           : DiscordBot.Models
    File name         : MachineVersionDetail.cs
    Date created      : 29/11/2020
    Purpose           : This file contains PokeAPI's 'MachineVersionDetail' structure definition.

    Revision History  :
    Date        Author      Ref     Revision 
    29/11/2020  Rilegis     1       First code commit.
    30/11/2020  Rilegis     2       Moved to 'PokeAPI.Common' namespace.
**********************************************************************/

using Newtonsoft.Json;

namespace DiscordBot.Models.PokeAPI.Common
{
    public struct MachineVersionDetail
    {
        // The machine that teaches a move from an item.
        public NamedAPIResource Machine { get; set; }

        // The version group of this specific machine.
        [JsonProperty("version_group")]
        public NamedAPIResource VersionGroup { get; set; }
    }
}
