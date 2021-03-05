/**********************************************************************
    Author            : Rilegis
    Repository        : DiscordBot
    Project           : DiscordBot.Models
    File name         : ItemHolderPokemonVersionDetail.cs
    Date created      : 29/11/2020
    Purpose           : This file contains PokeAPI's 'ItemHolderPokemonVersionDetail' structure definition.

    Revision History  :
    Date        Author      Ref     Revision 
    29/11/2020  Rilegis     1       First code commit.
**********************************************************************/

using DiscordBot.Models.PokeAPI.Common;

namespace DiscordBot.Models.PokeAPI.Item
{
    public struct ItemHolderPokemonVersionDetail
    {
        // How often this Pokémon holds this item in this version.
        public int Rarity { get; set; }

        // The version that this item is held in by the Pokémon.
        public NamedAPIResource Version { get; set; }
    }
}