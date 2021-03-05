/**********************************************************************
    Author            : Rilegis
    Repository        : DiscordBot
    Project           : DiscordBot.Models
    File name         : ContestComboDetail.cs
    Date created      : 29/11/2020
    Purpose           : This file contains PokeAPI's 'ContestComboDetail' structure definition.

    Revision History  :
    Date        Author      Ref     Revision 
    29/11/2020  Rilegis     1       First code commit.
**********************************************************************/

using DiscordBot.Models.PokeAPI.Common;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace DiscordBot.Models.PokeAPI.Move
{
    public struct ContestComboDetail
    {
        // A list of moves to use before this move.
        [JsonProperty("use_before")]
        public List<NamedAPIResource> UseBefore { get; set; }

        // A list of moves to use after this move.
        [JsonProperty("use_after")]
        public List<NamedAPIResource> UseAfter { get; set; }
    }
}