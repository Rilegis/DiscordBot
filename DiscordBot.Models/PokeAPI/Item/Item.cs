/**********************************************************************
    Author            : Rilegis
    Repository        : DiscordBot
    Project           : DiscordBot.Models
    File name         : Item.cs
    Date created      : 29/11/2020
    Purpose           : This file contains PokeAPI's 'Item' structure definition.

    Revision History  :
    Date        Author      Ref     Revision 
    29/11/2020  Rilegis     1       First code commit.
**********************************************************************/

using DiscordBot.Models.PokeAPI.Common;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace DiscordBot.Models.PokeAPI.Item
{
    public struct Item
    {
        // The identifier for this resource.
        public int Id { get; set; }

        // The name for this resource.
        public string Name { get; set; }

        // The price of this item in stores.
        public int Cost { get; set; }

        // The power of the move Fling when used with this item.
        [JsonProperty("fling_power")]
        public int FlingPower { get; set; }

        // The effect of the move Fling when used with this item.
        [JsonProperty("fling_effect")]
        public NamedAPIResource FlingEffect { get; set; }

        // A list of attributes this item has.
        public List<NamedAPIResource> Attributes { get; set; }

        // The category of items this item falls into.
        public NamedAPIResource Category { get; set; }

        // The effect of this ability listed in different languages.
        [JsonProperty("effect_entries")]
        public List<VerboseEffect> EffectEntries { get; set; }

        // The flavor text of this ability listed in different languages.
        [JsonProperty("flavor_text_entries")]
        public List<VersionGroupFlavorText> FlavorTextEntries { get; set; }

        // A list of game indices relevent to this item by generation.
        [JsonProperty("game_indices")]
        public List<GenerationGameIndex> GameIndices { get; set; }

        // The name of this item listed in different languages.
        public List<NameType> Names { get; set; }

        // A set of sprites used to depict this item in the game.
        public ItemSprites Sprites { get; set; }

        // A list of Pokémon that might be found in the wild holding this item.
        [JsonProperty("held_by_pokemon")]
        public List<ItemHolderPokemon> HeldByPokemon { get; set; }

        // An evolution chain this item requires to produce a baby during mating.
        [JsonProperty("baby_trigger_for")]
        public APIResource BabyTriggerFor { get; set; }

        // A list of the machines related to this item.
        public List<MachineVersionDetail> Machines { get; set; }
    }
}
