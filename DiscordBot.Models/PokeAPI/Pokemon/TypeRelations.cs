/**********************************************************************
    Author            : Rilegis
    Repository        : DiscordBot
    Project           : DiscordBot.Models
    File name         : TypeRelations.cs
    Date created      : 30/11/2020
    Purpose           : This file contains PokeAPI's 'TypeRelations' structure definition.

    Revision History  :
    Date        Author      Ref     Revision 
    30/11/2020  Rilegis     1       First code commit.
**********************************************************************/

using DiscordBot.Models.PokeAPI.Common;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace DiscordBot.Models.PokeAPI.Pokemon
{
    public struct TypeRelations
    {
        // A list of types this type has no effect on.
        [JsonProperty("no_damage_to")]
        public List<NamedAPIResource> NoDamageTo { get; set; }

        // A list of types this type is not very effective against.
        [JsonProperty("half_damage_to")]
        public List<NamedAPIResource> HalfDamadeTo { get; set; }

        // A list of types this type is very effective against.
        [JsonProperty("double_damage_to")]
        public List<NamedAPIResource> DoubleDamageTo { get; set; }

        // A list of types that have no effect on this type.
        [JsonProperty("no_damage_from")]
        public List<NamedAPIResource> NoDamageFrom { get; set; }

        // A list of types that are not very effective against this type.
        [JsonProperty("half_damage_from")]
        public List<NamedAPIResource> HalfDamageFrom { get; set; }

        // A list of types that are very effective against this type.
        [JsonProperty("double_damage_from")]
        public List<NamedAPIResource> DoubleDamageFrom { get; set; }
    }
}