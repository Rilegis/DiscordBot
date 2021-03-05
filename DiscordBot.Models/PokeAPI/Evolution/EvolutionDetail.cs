/**********************************************************************
    Author            : Rilegis
    Repository        : DiscordBot
    Project           : DiscordBot.Models
    File name         : EvolutionDetail.cs
    Date created      : 24/11/2020
    Purpose           : This file contains PokeAPI's 'EvolutionDetail' structure definition.

    Revision History  :
    Date        Author      Ref     Revision 
    24/11/2020  Rilegis     1       First code commit.
**********************************************************************/

using DiscordBot.Models.PokeAPI.Common;
using Newtonsoft.Json;

namespace DiscordBot.Models.PokeAPI.Evolution
{
    public struct EvolutionDetail
    {
        // The item required to cause evolution this into Pokémon species.
        public NamedAPIResource Item { get; set; }

        // The type of event that triggers evolution into this Pokémon species.
        public NamedAPIResource Trigger { get; set; }

        // The id of the gender of the evolving Pokémon species must be in order to evolve into this Pokémon species.
        public int Gender { get; set; }

        // The item the evolving Pokémon species must be holding during the evolution trigger event to evolve into this Pokémon species.
        [JsonProperty("held_item")]
        public NamedAPIResource HeldItem { get; set; }

        // The move that must be known by the evolving Pokémon species during the evolution trigger event in order to evolve into this Pokémon species.
        [JsonProperty("known_move")]
        public NamedAPIResource KnownMove { get; set; }

        // The evolving Pokémon species must know a move with this type during the evolution trigger event in order to evolve into this Pokémon species.
        [JsonProperty("known_move_type")]
        public NamedAPIResource KnownMoveType { get; set; }

        // The location the evolution must be triggered at.
        public NamedAPIResource Location { get; set; }

        // The minimum required level of the evolving Pokémon species to evolve into this Pokémon species.
        [JsonProperty("min_level")]
        public int MinLevel { get; set; }

        // The minimum required level of happiness the evolving Pokémon species to evolve into this Pokémon species.
        [JsonProperty("min_happiness")]
        public int MinHappiness { get; set; }

        // The minimum required level of beauty the evolving Pokémon species to evolve into this Pokémon species.
        [JsonProperty("min_beauty")]
        public int MinBeauty { get; set; }

        // The minimum required level of affection the evolving Pokémon species to evolve into this Pokémon species.
        [JsonProperty("min_affection")]
        public int MinAffection { get; set; }

        // Whether or not it must be raining in the overworld to cause evolution this Pokémon species.
        [JsonProperty("needs_overworld_rain")]
        public bool NeedsOverworldRain { get; set; }

        // The Pokémon species that must be in the players party in order for the evolving Pokémon species to evolve into this Pokémon species.
        [JsonProperty("party_species")]
        public NamedAPIResource PartySpecies { get; set; }

        // The player must have a Pokémon of this type in their party during the evolution trigger event in order for the evolving Pokémon species to evolve into this Pokémon species.
        [JsonProperty("party_type")]
        public NamedAPIResource PartyType { get; set; }

        // The required relation between the Pokémon's Attack and Defense stats.
        // 1 means Attack > Defense. 0 means Attack = Defense. -1 means Attack < Defense.
        [JsonProperty("relative_physical_stats")]
        public int RelativePhysicalStats { get; set; }

        // The required time of day.
        // Day or night.
        [JsonProperty("time_of_day")]
        public string TimeOfDay { get; set; }

        // Pokémon species for which this one must be traded.
        [JsonProperty("trade_species")]
        public NamedAPIResource TradeSpecies { get; set; }

        // Whether or not the 3DS needs to be turned upside-down as this Pokémon levels up.
        [JsonProperty("turn_upside_down")]
        public bool TurnUpsideDown { get; set; }
    }
}