/**********************************************************************
    Author            : Rilegis
    Repository        : DiscordBot
    Project           : DiscordBot.Models
    File name         : PokemonMoveVersion.cs
    Date created      : 30/11/2020
    Purpose           : This file contains PokeAPI's 'PokemonMoveVersion' structure definition.

    Revision History  :
    Date        Author      Ref     Revision 
    30/11/2020  Rilegis     1       First code commit.
**********************************************************************/

using DiscordBot.Models.PokeAPI.Common;
using Newtonsoft.Json;

namespace DiscordBot.Models.PokeAPI.Pokemon
{
    public struct PokemonMoveVersion
    {
        // The method by which the move is learned.
        [JsonProperty("move_learn_method")]
        public NamedAPIResource MoveLearnMethod { get; set; }

        // The version group in which the move is learned.
        [JsonProperty("version_group")]
        public NamedAPIResource VersionGroup { get; set; }

        // The minimum level to learn the move.
        [JsonProperty("level_learned_at")]
        public int LevelLearnedAt { get; set; }
    }
}