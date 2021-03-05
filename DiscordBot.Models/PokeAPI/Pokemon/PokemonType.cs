/**********************************************************************
    Author            : Rilegis
    Repository        : DiscordBot
    Project           : DiscordBot.Models
    File name         : PokemonType.cs
    Date created      : 30/11/2020
    Purpose           : This file contains PokeAPI's 'PokemonType' structure definition.

    Revision History  :
    Date        Author      Ref     Revision 
    30/11/2020  Rilegis     1       First code commit.
**********************************************************************/

using DiscordBot.Models.PokeAPI.Common;

namespace DiscordBot.Models.PokeAPI.Pokemon
{
    public struct PokemonType
    {
        // The order the Pokémon's types are listed in.
        public int Slot { get; set; }

        // The type the referenced Pokémon has.
        public NamedAPIResource Type { get; set; }
    }
}