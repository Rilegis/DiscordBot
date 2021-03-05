/**********************************************************************
    Author            : Rilegis
    Repository        : DiscordBot
    Project           : DiscordBot.Models
    File name         : PokemonAbility.cs
    Date created      : 30/11/2020
    Purpose           : This file contains PokeAPI's 'PokemonAbility' structure definition.

    Revision History  :
    Date        Author      Ref     Revision 
    30/11/2020  Rilegis     1       First code commit.
**********************************************************************/

using DiscordBot.Models.PokeAPI.Common;
using Newtonsoft.Json;

namespace DiscordBot.Models.PokeAPI.Pokemon
{
    public struct PokemonAbility
    {
        // Whether or not this is a hidden ability.
        [JsonProperty("is_hidden")]
        public bool IsHidden { get; set; }

        // The slot this ability occupies in this Pokémon species.
        public int Slot { get; set; }

        // The ability the Pokémon may have.
        public NamedAPIResource Ability { get; set; }
    }
}