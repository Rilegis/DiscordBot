/**********************************************************************
    Author            : Rilegis
    Repository        : DiscordBot
    Project           : DiscordBot.Models
    File name         : ItemCategories.cs
    Date created      : 29/11/2020
    Purpose           : This file contains PokeAPI's 'ItemCategories' structure definition.

    Revision History  :
    Date        Author      Ref     Revision 
    29/11/2020  Rilegis     1       First code commit.
**********************************************************************/

using DiscordBot.Models.PokeAPI.Common;
using System.Collections.Generic;

namespace DiscordBot.Models.PokeAPI.Item
{
    public struct ItemCategories
    {
        // The identifier for this resource.
        public int Id { get; set; }

        // The name for this resource.
        public string Name { get; set; }

        // A list of items that are a part of this category.
        public List<NamedAPIResource> Items { get; set; }

        // The name of this item category listed in different languages.
        public List<NameType> Names { get; set; }

        // The pocket items in this category would be put in.
        public NamedAPIResource Pocket { get; set; }
    }
}
