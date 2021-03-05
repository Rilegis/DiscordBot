/**********************************************************************
    Author            : Rilegis
    Repository        : DiscordBot
    Project           : DiscordBot.Models
    File name         : Ability.cs
    Date created      : 29/11/2020
    Purpose           : This file contains PokeAPI's 'Ability' structure definition.

    Revision History  :
    Date        Author      Ref     Revision 
    30/11/2020  Rilegis     1       First code commit.
**********************************************************************/

using DiscordBot.Models.PokeAPI.Common;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace DiscordBot.Models.PokeAPI.Pokemon
{
    public struct Ability
    {
        // The identifier for this resource.
        public int Id { get; set; }

        // The name for this resource.
        public string Name { get; set; }

        // Whether or not this ability originated in the main series of the video games.
        [JsonProperty("is_main_series")]
        public bool IsMainSeries { get; set; }

        // The generation this ability originated in.
        public NamedAPIResource Generation { get; set; }

        // The name of this resource listed in different languages.
        public List<NameType> Names { get; set; }

        // The effect of this ability listed in different languages.
        [JsonProperty("effect_entries")]
        public List<VerboseEffect> EffectEntries { get; set; }

        // The list of previous effects this ability has had across version groups.
        [JsonProperty("effect_changes")]
        public List<AbilityEffectChange> EffectChanges { get; set; }

        // The flavor text of this ability listed in different languages.
        [JsonProperty("flavor_text_entries")]
        public List<AbilityFlavorText> FlavorTextEntries { get; set; }

        // A list of Pokémon that could potentially have this ability.
        public List<AbilityPokemon> Pokemon { get; set; }
    }
}
