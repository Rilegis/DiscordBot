/**********************************************************************
    Author            : Rilegis
    Repository        : DiscordBot
    Project           : DiscordBot.Models
    File name         : GenusType.cs
    Date created      : 30/11/2020
    Purpose           : This file contains PokeAPI's 'GenusType' structure definition.

    Revision History  :
    Date        Author      Ref     Revision 
    30/11/2020  Rilegis     1       First code commit.
**********************************************************************/

using DiscordBot.Models.PokeAPI.Common;

namespace DiscordBot.Models.PokeAPI.Pokemon
{
    public struct GenusType
    {
        // The localized genus for the referenced Pokémon species
        public string Genus { get; set; }

        // The language this genus is in.
        public NamedAPIResource Language { get; set; }
    }
}