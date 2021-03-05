/**********************************************************************
    Author            : Rilegis
    Repository        : DiscordBot
    Project           : DiscordBot.Models
    File name         : AbilityPokemon.cs
    Date created      : 29/11/2020
    Purpose           : This file contains PokeAPI's 'AbilityPokemon' structure definition.

    Revision History  :
    Date        Author      Ref     Revision 
    30/11/2020  Rilegis     1       First code commit.
**********************************************************************/

using DiscordBot.Models.PokeAPI.Common;
using Newtonsoft.Json;

namespace DiscordBot.Models.PokeAPI.Pokemon
{
    public struct AbilityPokemon
    {
        // Whether or not this a hidden ability for the referenced Pokémon.
        [JsonProperty("is_hidden")]
        public bool IsHidden { get; set; }

        // Pokémon have 3 ability 'slots' which hold references to possible abilities they could have.
        // This is the slot of this ability for the referenced pokemon.
        public int Slot { get; set; }

        // The Pokémon this ability could belong to.
        public NamedAPIResource Pokemon { get; set; }
    }
}