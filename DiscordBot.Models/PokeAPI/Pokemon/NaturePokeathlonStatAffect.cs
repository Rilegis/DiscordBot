/**********************************************************************
    Author            : Rilegis
    Repository        : DiscordBot
    Project           : DiscordBot.Models
    File name         : NaturePokeathlonStatAffect.cs
    Date created      : 29/11/2020
    Purpose           : This file contains PokeAPI's 'NaturePokeathlonStatAffect' structure definition.

    Revision History  :
    Date        Author      Ref     Revision 
    30/11/2020  Rilegis     1       First code commit.
**********************************************************************/

using DiscordBot.Models.PokeAPI.Common;
using Newtonsoft.Json;

namespace DiscordBot.Models.PokeAPI.Pokemon
{
    public struct NaturePokeathlonStatAffect
    {
        // The maximum amount of change to the referenced Pokéathlon stat.
        [JsonProperty("max_change")]
        public int MaxChange { get; set; }

        // The nature causing the change.
        public NamedAPIResource Nature { get; set; }
    }
}