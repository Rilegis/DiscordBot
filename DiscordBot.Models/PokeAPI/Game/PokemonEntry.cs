/**********************************************************************
    Author            : Rilegis
    Repository        : DiscordBot
    Project           : DiscordBot.Models
    File name         : PokemonEntry.cs
    Date created      : 24/11/2020
    Purpose           : This file contains PokeAPI's 'PokemonEntry' structure definition.

    Revision History  :
    Date        Author      Ref     Revision 
    24/11/2020  Rilegis     1       First code commit.
**********************************************************************/

using DiscordBot.Models.PokeAPI.Common;
using Newtonsoft.Json;

namespace DiscordBot.Models.PokeAPI.Game
{
    public struct PokemonEntry
    {
        // The index of this Pokémon species entry within the Pokédex.
        [JsonProperty("entry_number")]
        public int EntryNumber { get; set; }

        // The Pokémon species being encountered.
        [JsonProperty("pokemon_species")]
        public NamedAPIResource PokemonSpecies { get; set; }
    }
}