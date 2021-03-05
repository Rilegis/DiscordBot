/**********************************************************************
    Author            : Rilegis
    Repository        : DiscordBot
    Project           : DiscordBot.Models
    File name         : TypePokemon.cs
    Date created      : 30/11/2020
    Purpose           : This file contains PokeAPI's 'TypePokemon' structure definition.

    Revision History  :
    Date        Author      Ref     Revision 
    30/11/2020  Rilegis     1       First code commit.
**********************************************************************/

using DiscordBot.Models.PokeAPI.Common;

namespace DiscordBot.Models.PokeAPI.Pokemon
{
    public struct TypePokemon
    {
        // The order the Pokémon's types are listed in.
        public int Slot { get; set; }

        // The Pokémon that has the referenced type.
        public NamedAPIResource Pokemon { get; set; }
    }
}