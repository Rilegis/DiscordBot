/**********************************************************************
    Author            : Rilegis
    Repository        : DiscordBot
    Project           : DiscordBot.Models
    File name         : ItemPocket.cs
    Date created      : 29/11/2020
    Purpose           : This file contains PokeAPI's 'ItemPocket' structure definition.

    Revision History  :
    Date        Author      Ref     Revision 
    29/11/2020  Rilegis     1       First code commit.
**********************************************************************/

using DiscordBot.Models.PokeAPI.Common;
using System.Collections.Generic;

namespace DiscordBot.Models.PokeAPI.Item
{
    public struct ItemPocket
    {
        // The identifier for this resource.
        public int Id { get; set; }

        // The name for this resource.
        public string Name { get; set; }

        // A list of item categories that are relevant to this item pocket.
        public List<NamedAPIResource> Categories { get; set; }

        // The name of this resource listed in different languages.
        public List<NameType> Names { get; set; }
    }
}
