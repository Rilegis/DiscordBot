/**********************************************************************
    Author            : Rilegis
    Repository        : DiscordBot
    Project           : DiscordBot.Models
    File name         : MoveCategory.cs
    Date created      : 29/11/2020
    Purpose           : This file contains PokeAPI's 'MoveCategory' structure definition.

    Revision History  :
    Date        Author      Ref     Revision 
    29/11/2020  Rilegis     1       First code commit.
**********************************************************************/

using DiscordBot.Models.PokeAPI.Common;
using System.Collections.Generic;

namespace DiscordBot.Models.PokeAPI.Move
{
    public struct MoveCategory
    {
        // The identifier for this resource.
        public int Id { get; set; }

        // The name for this resource.
        public string Name { get; set; }

        // A list of moves that fall into this category.
        public List<NamedAPIResource> Moves { get; set; }

        // The description of this resource listed in different languages.
        public List<DescriptionType> Descriptions { get; set; }
    }
}
