/**********************************************************************
    Author            : Rilegis
    Repository        : DiscordBot
    Project           : DiscordBot.Models
    File name         : Type.cs
    Date created      : 30/11/2020
    Purpose           : This file contains PokeAPI's 'Type' structure definition.

    Revision History  :
    Date        Author      Ref     Revision 
    30/11/2020  Rilegis     1       First code commit.
**********************************************************************/

using DiscordBot.Models.PokeAPI.Common;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace DiscordBot.Models.PokeAPI.Pokemon
{
    public struct Type
    {
        // The identifier for this resource.
        public int Id { get; set; }

        // The name for this resource.
        public string Name { get; set; }

        // A detail of how effective this type is toward others and vice versa.
        [JsonProperty("damage_relations")]
        public TypeRelations DamageRelations { get; set; }

        // A list of game indices relevent to this item by generation.
        [JsonProperty("game_indices")]
        public List<GenerationGameIndex> GameIndices { get; set; }

        // The generation this type was introduced in.
        public NamedAPIResource Generation { get; set; }

        // The class of damage inflicted by this type.
        [JsonProperty("move_damage_class")]
        public NamedAPIResource MoveDamageClass { get; set; }

        // The name of this resource listed in different languages.
        public List<NameType> Names { get; set; }

        // A list of details of Pokémon that have this type.
        public List<TypePokemon> Pokemon { get; set; }

        // A list of moves that have this type.
        public List<NamedAPIResource> Moves { get; set; }
    }
}
