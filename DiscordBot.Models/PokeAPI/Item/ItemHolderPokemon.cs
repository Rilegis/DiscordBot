/**********************************************************************
    Author            : Rilegis
    Repository        : DiscordBot
    Project           : DiscordBot.Models
    File name         : ItemHolderPokemon.cs
    Date created      : 29/11/2020
    Purpose           : This file contains PokeAPI's 'ItemHolderPokemon' structure definition.

    Revision History  :
    Date        Author      Ref     Revision 
    29/11/2020  Rilegis     1       First code commit.
**********************************************************************/

using DiscordBot.Models.PokeAPI.Common;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace DiscordBot.Models.PokeAPI.Item
{
    public struct ItemHolderPokemon
    {
        // The Pokémon that holds this item.
        public NamedAPIResource Pokemon { get; set; }

        // The details for the version that this item is held in by the Pokémon.
        [JsonProperty("version_details")]
        public List<ItemHolderPokemonVersionDetail> VersionDetails { get; set; }
    }
}