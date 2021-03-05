/**********************************************************************
    Author            : Rilegis
    Repository        : DiscordBot
    Project           : DiscordBot.Models
    File name         : PastMoveStatValues.cs
    Date created      : 29/11/2020
    Purpose           : This file contains PokeAPI's 'PastMoveStatValues' structure definition.

    Revision History  :
    Date        Author      Ref     Revision 
    29/11/2020  Rilegis     1       First code commit.
**********************************************************************/

using DiscordBot.Models.PokeAPI.Common;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace DiscordBot.Models.PokeAPI.Move
{
    public struct PastMoveStatValues
    {
        // The percent value of how likely this move is to be successful.
        public int Accuracy { get; set; }

        // The percent value of how likely it is this moves effect will take effect.
        [JsonProperty("effect_change")]
        public int EffectChange { get; set; }

        // The base power of this move with a value of 0 if it does not have a base power.
        public int Power { get; set; }

        // Power points. The number of times this move can be used.
        public int PP { get; set; }

        // The effect of this move listed in different languages.
        [JsonProperty("effect_entries")]
        public List<VerboseEffect> EffectEntries { get; set; }

        // The elemental type of this move.
        public NamedAPIResource Type { get; set; }

        // The version group in which these move stat values were in effect.
        [JsonProperty("version_groups")]
        public List<NamedAPIResource> VersionGroups { get; set; }
    }
}