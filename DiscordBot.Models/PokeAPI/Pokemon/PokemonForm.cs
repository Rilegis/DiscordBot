/**********************************************************************
    Author            : Rilegis
    Repository        : DiscordBot
    Project           : DiscordBot.Models
    File name         : PokemonForm.cs
    Date created      : 30/11/2020
    Purpose           : This file contains PokeAPI's 'PokemonForm' structure definition.

    Revision History  :
    Date        Author      Ref     Revision 
    30/11/2020  Rilegis     1       First code commit.
**********************************************************************/

using DiscordBot.Models.PokeAPI.Common;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace DiscordBot.Models.PokeAPI.Pokemon
{
    public struct PokemonForm
    {
        // The identifier for this resource.
        public int Id { get; set; }

        // The name for this resource.
        public string Name { get; set; }

        // The order in which forms should be sorted within all forms. Multiple forms may have equal order, in which case they should fall back on sorting by name.
        public int Order { get; set; }

        // The order in which forms should be sorted within a species' forms.
        [JsonProperty("form_order")]
        public int FormOrder { get; set; }

        // True for exactly one form used as the default for each Pokémon.
        [JsonProperty("is_default")]
        public bool IsDefault { get; set; }

        // Whether or not this form can only happen during battle.
        [JsonProperty("is_battle_only")]
        public bool IsBattleOnly { get; set; }

        // Whether or not this form requires mega evolution.
        [JsonProperty("is_mega")]
        public bool IsMega { get; set; }

        // The name of this form.
        [JsonProperty("form_name")]
        public string FormName { get; set; }

        // The Pokémon that can take on this form.
        public NamedAPIResource Pokemon { get; set; }

        // A set of sprites used to depict this Pokémon form in the game.
        public PokemonFormSprites Sprites { get; set; }

        // The version group this Pokémon form was introduced in.
        [JsonProperty("version_group")]
        public NamedAPIResource VersionGroup { get; set; }

        // The form specific full name of this Pokémon form, or empty if the form does not have a specific name.
        public List<NameType> Names { get; set; }

        // The form specific form name of this Pokémon form, or empty if the form does not have a specific name.
        [JsonProperty("form_names")]
        public List<NameType> FormNames { get; set; }
    }
}
