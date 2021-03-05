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
using System.Collections.Generic;

namespace DiscordBot.Models.PokeAPI.Move
{
    public struct MoveTarget
    {
        // The identifier for this resource.
        public int Id { get; set; }

        // The name for this resource.
        public string Name { get; set; }

        // The description of this resource listed in different languages.
        public List<DescriptionType> Descriptions { get; set; }

        // A list of moves that that are directed at this target.
        public List<NamedAPIResource> Moves { get; set; }

        // The name of this resource listed in different languages.
        public List<NameType> Names { get; set; }
    }
}
