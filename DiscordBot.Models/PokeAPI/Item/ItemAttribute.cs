/**********************************************************************
    Author            : Rilegis
    Repository        : DiscordBot
    Project           : DiscordBot.Models
    File name         : ItemAttribute.cs
    Date created      : 29/11/2020
    Purpose           : This file contains PokeAPI's 'ItemAttribute' structure definition.

    Revision History  :
    Date        Author      Ref     Revision 
    29/11/2020  Rilegis     1       First code commit.
**********************************************************************/

using DiscordBot.Models.PokeAPI.Common;
using System.Collections.Generic;

namespace DiscordBot.Models.PokeAPI.Item
{
    public struct ItemAttribute
    {
        // The identifier for this resource.
        public int Id { get; set; }

        // The name for this resource.
        public string Name { get; set; }

        // A list of items that have this attribute.
        public List<NamedAPIResource> Items { get; set; }

        // The name of this item attribute listed in different languages.
        public List<NameType> Names { get; set; }

        // The description of this item attribute listed in different languages.
        public List<DescriptionType> Descriptions { get; set; }
    }
}
