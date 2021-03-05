/**********************************************************************
    Author            : Rilegis
    Repository        : DiscordBot
    Project           : DiscordBot.Models
    File name         : MoveBattleStylePreference.cs
    Date created      : 29/11/2020
    Purpose           : This file contains PokeAPI's 'MoveBattleStylePreference' structure definition.

    Revision History  :
    Date        Author      Ref     Revision 
    30/11/2020  Rilegis     1       First code commit.
**********************************************************************/

using DiscordBot.Models.PokeAPI.Common;
using Newtonsoft.Json;

namespace DiscordBot.Models.PokeAPI.Pokemon
{
    public struct MoveBattleStylePreference
    {
        // Chance of using the move, in percent, if HP is under one half.
        [JsonProperty("low_hp_preference")]
        public int LowHpPreference { get; set; }

        // Chance of using the move, in percent, if HP is over one half.
        [JsonProperty("high_hp_preference")]
        public int HighHpPreference { get; set; }

        // The move battle style.
        [JsonProperty("move_battle_style")]
        public NamedAPIResource MoveBattleStyle { get; set; }
    }
}