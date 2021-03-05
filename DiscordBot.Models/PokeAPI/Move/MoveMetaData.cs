/**********************************************************************
    Author            : Rilegis
    Repository        : DiscordBot
    Project           : DiscordBot.Models
    File name         : MoveMetaData.cs
    Date created      : 29/11/2020
    Purpose           : This file contains PokeAPI's 'MoveMetaData' structure definition.

    Revision History  :
    Date        Author      Ref     Revision 
    29/11/2020  Rilegis     1       First code commit.
**********************************************************************/

using DiscordBot.Models.PokeAPI.Common;
using Newtonsoft.Json;

namespace DiscordBot.Models.PokeAPI.Move
{
    public struct MoveMetaData
    {
        // The status ailment this move inflicts on its target.
        public NamedAPIResource Ailment { get; set; }

        // The category of move this move falls under, e.g. damage or ailment.
        public NamedAPIResource Category { get; set; }

        // The minimum number of times this move hits. Null if it always only hits once.
        [JsonProperty("min_hits")]
        public int MinHits { get; set; }

        // The maximum number of times this move hits. Null if it always only hits once.
        [JsonProperty("max_hits")]
        public int MaxHits { get; set; }

        // The minimum number of turns this move continues to take effect. Null if it always only lasts one turn.
        [JsonProperty("min_turns")]
        public int MinTurns { get; set; }

        // The maximum number of turns this move continues to take effect. Null if it always only lasts one turn.
        [JsonProperty("max_turns")]
        public int MaxTurns { get; set; }

        // HP drain (if positive) or Recoil damage (if negative), in percent of damage done.
        public int Drain { get; set; }

        // The amount of hp gained by the attacking Pokemon, in percent of it's maximum HP.
        public int Healing { get; set; }

        // Critical hit rate bonus.
        [JsonProperty("crit_rate")]
        public int CritRate { get; set; }

        // The likelihood this attack will cause an ailment.
        [JsonProperty("ailment_chance")]
        public int AilmentChance { get; set; }

        // The likelihood this attack will cause the target Pokémon to flinch.
        [JsonProperty("flinch_chance")]
        public int FlinchChance { get; set; }

        // The likelihood this attack will cause a stat change in the target Pokémon.
        [JsonProperty("stat_chance")]
        public int StatChance { get; set; }
    }
}