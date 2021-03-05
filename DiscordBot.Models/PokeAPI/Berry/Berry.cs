/**********************************************************************
    Author            : Rilegis
    Repository        : DiscordBot
    Project           : DiscordBot.Models
    File name         : Berry.cs
    Date created      : 11/11/2020
    Purpose           : This file contains PokeAPI's 'Berry' structure definition.

    Revision History  :
    Date        Author      Ref     Revision 
    11/11/2020  Rilegis     1       First code commit.
    23/11/2020  Rilegis     2       Separated file into multiple class files.
                                    Moved to it's own namespace.
**********************************************************************/

using DiscordBot.Models.PokeAPI.Common;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace DiscordBot.Models.PokeAPI.Berry
{
    public struct Berry
    {
        // The identifier for this resource.
        public int Id { get; set; }

        // The name for this resource.
        public string Name { get; set; }

        // Time it takes the tree to grow one stage, in hours.
        // Berry trees go through four of these growth stages before they can be picked.
        [JsonProperty("growth_time")]
        public int GrowthTime { get; set; }

        // The maximum number of these berries that can grow on one tree in Generation IV.
        [JsonProperty("max_harvest")]
        public int MaxHarvest { get; set; }

        // The power of the move "Natural Gift" when used with this Berry.
        [JsonProperty("natural_gift_power")]
        public int NaturalGiftPower { get; set; }

        // The size of this Berry, in millimeters.
        public int Size { get; set; }

        // The smoothness of this Berry, used in making Pokéblocks or Poffins.
        public int Smoothness { get; set; }

        // The speed at which this Berry dries out the soil as it grows.
        // A higher rate means the soil dries more quickly.
        [JsonProperty("soil_dryness")]
        public int SoilDryness { get; set; }

        // The firmness of this berry, used in making Pokéblocks or Poffins.
        public NamedAPIResource Firmness { get; set; }

        // A list of references to each flavor a berry can have and the potency of each of those flavors in regard to this berry.
        public List<BerryFlavorMap> Flavors { get; set; }

        // Berries are actually items.
        // This is a reference to the item specific data for this berry.
        public NamedAPIResource Item { get; set; }

        // The type inherited by "Natural Gift" when used with this Berry.
        [JsonProperty("natural_gift_type")]
        public NamedAPIResource NaturalGiftType { get; set; }
    }
}
