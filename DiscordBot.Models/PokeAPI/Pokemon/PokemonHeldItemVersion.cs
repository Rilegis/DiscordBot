/**********************************************************************
    Author            : Rilegis
    Repository        : DiscordBot
    Project           : DiscordBot.Models
    File name         : PokemonHeldItemVersion.cs
    Date created      : 30/11/2020
    Purpose           : This file contains PokeAPI's 'PokemonHeldItemVersion' structure definition.

    Revision History  :
    Date        Author      Ref     Revision 
    30/11/2020  Rilegis     1       First code commit.
**********************************************************************/

using DiscordBot.Models.PokeAPI.Common;

namespace DiscordBot.Models.PokeAPI.Pokemon
{
    public struct PokemonHeldItemVersion
    {
        // The version in which the item is held.
        public NamedAPIResource Version { get; set; }

        // How often the item is held.
        public int Rarity { get; set; }
    }
}