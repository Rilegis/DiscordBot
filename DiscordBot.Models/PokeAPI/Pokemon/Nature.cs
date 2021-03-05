/**********************************************************************
    Author            : Rilegis
    Repository        : DiscordBot
    Project           : DiscordBot.Models
    File name         : Nature.cs
    Date created      : 29/11/2020
    Purpose           : This file contains PokeAPI's 'Nature' structure definition.

    Revision History  :
    Date        Author      Ref     Revision 
    30/11/2020  Rilegis     1       First code commit.
**********************************************************************/

using DiscordBot.Models.PokeAPI.Common;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace DiscordBot.Models.PokeAPI.Pokemon
{
    public struct Nature
    {
        // The identifier for this resource.
        public int Id { get; set; }

        // The name for this resource.
        public string Name { get; set; }

        // The stat decreased by 10% in Pokémon with this nature.
        [JsonProperty("decreased_stat")]
        public NamedAPIResource DecreasedStat { get; set; }

        // The stat increased by 10% in Pokémon with this nature.
        [JsonProperty("increased_stat")]
        public NamedAPIResource IncreasedStats { get; set; }

        // The flavor hated by Pokémon with this nature.
        [JsonProperty("hates_flavor")]
        public NamedAPIResource HatesFlavor { get; set; }

        // The flavor liked by Pokémon with this nature.
        [JsonProperty("likes_flavor")]
        public NamedAPIResource LikesFlavor { get; set; }

        // A list of Pokéathlon stats this nature effects and how much it effects them.
        [JsonProperty("pokeathlon_stat_changes")]
        public List<NatureStatChange> PokeathlonStatChanges { get; set; }

        // A list of battle styles and how likely a Pokémon with this nature is to use them in the Battle Palace or Battle Tent.
        [JsonProperty("move_battle_style_preferences")]
        public List<MoveBattleStylePreference> MoveBattleStylePreference { get; set; }

        // The name of this resource listed in different languages.
        public List<NameType> Names { get; set; }
    }
}
