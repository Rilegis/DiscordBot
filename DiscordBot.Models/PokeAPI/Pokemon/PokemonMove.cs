/**********************************************************************
    Author            : Rilegis
    Repository        : DiscordBot
    Project           : DiscordBot.Models
    File name         : PokemonMove.cs
    Date created      : 30/11/2020
    Purpose           : This file contains PokeAPI's 'PokemonMove' structure definition.

    Revision History  :
    Date        Author      Ref     Revision 
    30/11/2020  Rilegis     1       First code commit.
**********************************************************************/

using DiscordBot.Models.PokeAPI.Common;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace DiscordBot.Models.PokeAPI.Pokemon
{
    public struct PokemonMove
    {
        // The move the Pokémon can learn.
        public NamedAPIResource Move { get; set; }

        // The details of the version in which the Pokémon can learn the move.
        [JsonProperty("version_group_details")]
        public List<PokemonMoveVersion> VersionGroupDetails { get; set; }
    }
}