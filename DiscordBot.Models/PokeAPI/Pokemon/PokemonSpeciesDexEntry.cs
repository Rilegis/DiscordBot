/**********************************************************************
    Author            : Rilegis
    Repository        : DiscordBot
    Project           : DiscordBot.Models
    File name         : PokemonSpeciesDexEntry.cs
    Date created      : 30/11/2020
    Purpose           : This file contains PokeAPI's 'PokemonSpeciesDexEntry' structure definition.

    Revision History  :
    Date        Author      Ref     Revision 
    30/11/2020  Rilegis     1       First code commit.
**********************************************************************/

using DiscordBot.Models.PokeAPI.Common;
using Newtonsoft.Json;

namespace DiscordBot.Models.PokeAPI.Pokemon
{
    public struct PokemonSpeciesDexEntry
    {
        // The index number within the Pokédex.
        [JsonProperty("entry_number")]
        public int EntryNumber { get; set; }

        // The Pokédex the referenced Pokémon species can be found in.
        public NamedAPIResource Pokedex { get; set; }
    }
}