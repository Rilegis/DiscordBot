/**********************************************************************
    Author            : Rilegis
    Repository        : DiscordBot
    Project           : DiscordBot.Models
    File name         : PokemonHeldItem.cs
    Date created      : 30/11/2020
    Purpose           : This file contains PokeAPI's 'PokemonHeldItem' structure definition.

    Revision History  :
    Date        Author      Ref     Revision 
    30/11/2020  Rilegis     1       First code commit.
**********************************************************************/

using DiscordBot.Models.PokeAPI.Common;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace DiscordBot.Models.PokeAPI.Pokemon
{
    public struct PokemonHeldItem
    {
        // The item the referenced Pokémon holds.
        public NamedAPIResource Item { get; set; }

        // The details of the different versions in which the item is held.
        [JsonProperty("version_details")]
        public List<PokemonHeldItemVersion> VersionDetails { get; set; }
    }
}