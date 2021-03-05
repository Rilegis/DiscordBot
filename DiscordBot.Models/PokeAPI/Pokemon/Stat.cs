/**********************************************************************
    Author            : Rilegis
    Repository        : DiscordBot
    Project           : DiscordBot.Models
    File name         : Stat.cs
    Date created      : 30/11/2020
    Purpose           : This file contains PokeAPI's 'Stat' structure definition.

    Revision History  :
    Date        Author      Ref     Revision 
    30/11/2020  Rilegis     1       First code commit.
**********************************************************************/

using DiscordBot.Models.PokeAPI.Common;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace DiscordBot.Models.PokeAPI.Pokemon
{
    public struct Stat
    {
        // The identifier for this resource.
        public int Id { get; set; }

        // The name for this resource.
        public string Name { get; set; }

        // ID the games use for this stat.
        [JsonProperty("game_index")]
        public int GameIndex { get; set; }

        // Whether this stat only exists within a battle.
        [JsonProperty("is_battle_only")]
        public bool IsBattleOnly { get; set; }

        // A detail of moves which affect this stat positively or negatively.
        [JsonProperty("affecting_moves")]
        public MoveStatAffectSets AffectingMoves { get; set; }

        // A detail of natures which affect this stat positively or negatively.
        [JsonProperty("affecting_natures")]
        public NatureStatAffectSets AffectingNatures { get; set; }

        // A list of characteristics that are set on a Pokémon when its highest base stat is this stat.
        public List<APIResource> Characteristics { get; set; }

        // The class of damage this stat is directly related to.
        [JsonProperty("move_damage_class")]
        public NamedAPIResource MoveDamageClass { get; set; }

        // The name of this resource listed in different languages.
        public List<NameType> Names { get; set; }
    }
}
