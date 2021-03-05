/**********************************************************************
    Author            : Rilegis
    Repository        : DiscordBot
    Project           : DiscordBot.Models
    File name         : PokemonStat.cs
    Date created      : 30/11/2020
    Purpose           : This file contains PokeAPI's 'PokemonStat' structure definition.

    Revision History  :
    Date        Author      Ref     Revision 
    30/11/2020  Rilegis     1       First code commit.
**********************************************************************/

using DiscordBot.Models.PokeAPI.Common;
using Newtonsoft.Json;

namespace DiscordBot.Models.PokeAPI.Pokemon
{
    public struct PokemonStat
    {
        // The stat the Pokémon has.
        public NamedAPIResource Stat { get; set; }

        // The effort points (EV) the Pokémon has in the stat.
        public int Effort { get; set; }

        // The base value of the stat.
        [JsonProperty("base_stat")]
        public int BaseStat { get; set; }
    }
}