/**********************************************************************
    Author            : Rilegis
    Repository        : DiscordBot
    Project           : DiscordBot.Models
    File name         : ItemFlingEffect.cs
    Date created      : 29/11/2020
    Purpose           : This file contains PokeAPI's 'ItemFlingEffect' structure definition.

    Revision History  :
    Date        Author      Ref     Revision 
    29/11/2020  Rilegis     1       First code commit.
**********************************************************************/

using DiscordBot.Models.PokeAPI.Common;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace DiscordBot.Models.PokeAPI.Item
{
    public struct ItemFlingEffect
    {
        // The identifier for this resource.
        public int Id { get; set; }

        // The name for this resource.
        public string Name { get; set; }

        // The result of this fling effect listed in different languages.
        [JsonProperty("effect_entries")]
        public List<EffectType> EffectEntries { get; set; }

        // A list of items that have this fling effect.
        public List<NamedAPIResource> Items { get; set; }
    }
}
