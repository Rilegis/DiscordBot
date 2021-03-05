/**********************************************************************
    Author            : Rilegis
    Repository        : DiscordBot
    Project           : DiscordBot.Models
    File name         : Move.cs
    Date created      : 29/11/2020
    Purpose           : This file contains PokeAPI's 'Move' structure definition.

    Revision History  :
    Date        Author      Ref     Revision 
    29/11/2020  Rilegis     1       First code commit.
**********************************************************************/

using DiscordBot.Models.PokeAPI.Common;
using DiscordBot.Models.PokeAPI.Pokemon;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace DiscordBot.Models.PokeAPI.Move
{
    public struct Move
    {
        // The identifier for this resource.
        public int Id { get; set; }

        // The name for this resource.
        public string Name { get; set; }

        // The percent value of how likely this move is to be successful.
        public int Accuracy { get; set; }

        // The percent value of how likely it is this moves effect will happen.
        [JsonProperty("effect_chance")]
        public int EffectChance { get; set; }

        // Power points.
        // The number of times this move can be used.
        public int PP { get; set; }

        // A value between -8 and 8.
        // Sets the order in which moves are executed during battle. See Bulbapedia for greater detail.
        public int Priority { get; set; }

        // The base power of this move with a value of 0 if it does not have a base power.
        public int Power { get; set; }

        // A detail of normal and super contest combos that require this move.
        [JsonProperty("contest_combos")]
        public ContestComboSets ContestCombos { get; set; }

        // The type of appeal this move gives a Pokémon when used in a contest.
        [JsonProperty("contest_type")]
        public NamedAPIResource ContestType { get; set; }

        // The effect the move has when used in a contest.
        [JsonProperty("contest_effect")]
        public APIResource ContestEffect { get; set; }

        // The type of damage the move inflicts on the target, e.g. physical.
        [JsonProperty("damage_class")]
        public NamedAPIResource DamageClass { get; set; }

        // The effect of this move listed in different languages.
        [JsonProperty("effect_entries")]
        public List<VerboseEffect> EffectEntries { get; set; }

        // The list of previous effects this move has had across version groups of the games.
        [JsonProperty("effect_changes")]
        public List<AbilityEffectChange> EffectChanges { get; set; }

        // The flavor text of this move listed in different languages.
        [JsonProperty("flavor_text_entries")]
        public List<MoveFlavorText> FlavorTextEntries { get; set; }

        // The generation in which this move was introduced.
        public NamedAPIResource Generation { get; set; }

        // A list of the machines that teach this move.
        public List<MachineVersionDetail> Machines { get; set; }

        // Metadata about this move.
        public MoveMetaData Meta { get; set; }

        // The name of this resource listed in different languages.
        public List<NameType> Names { get; set; }

        // A list of move resource value changes across version groups of the game.
        [JsonProperty("past_values")]
        public List<PastMoveStatValues> PastValues { get; set; }

        // A list of stats this moves effects and how much it effects them.
        [JsonProperty("stat_changes")]
        public List<MoveStatChange> StatChanges { get; set; }

        // The effect the move has when used in a super contest.
        [JsonProperty("super_contest_effect")]
        public APIResource SuperContestEffect { get; set; }

        // The type of target that will receive the effects of the attack.
        public NamedAPIResource Target { get; set; }

        // The elemental type of this move.
        public NamedAPIResource Type { get; set; }
    }
}
