/**********************************************************************
    Author            : Rilegis
    Repository        : DiscordBot
    Project           : DiscordBot.Models
    File name         : AbilityEffectChange.cs
    Date created      : 29/11/2020
    Purpose           : This file contains PokeAPI's 'AbilityEffectChange' structure definition.

    Revision History  :
    Date        Author      Ref     Revision 
    30/11/2020  Rilegis     1       First code commit.
**********************************************************************/

using DiscordBot.Models.PokeAPI.Common;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace DiscordBot.Models.PokeAPI.Pokemon
{
    public struct AbilityEffectChange
    {
        // The previous effect of this ability listed in different languages.
        [JsonProperty("effect_entries")]
        public List<EffectType> EffectEntries { get; set; }

        // The version group in which the previous effect of this ability originated.
        [JsonProperty("version_group")]
        public NamedAPIResource VersionGroup { get; set; }
    }
}