/**********************************************************************
    Author            : Rilegis
    Repository        : DiscordBot
    Project           : DiscordBot.Models
    File name         : ContestEffect.cs
    Date created      : 23/11/2020
    Purpose           : This file contains PokeAPI's 'ContestEffect' structure definition.

    Revision History  :
    Date        Author      Ref     Revision 
    23/11/2020  Rilegis     1       First code commit.
**********************************************************************/

using DiscordBot.Models.PokeAPI.Common;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace DiscordBot.Models.PokeAPI.Contest
{
    public struct ContestEffect
    {
        // The identifier for this resource.
        public int Id { get; set; }

        // The base number of hearts the user of this move gets.
        public int Appeal { get; set; }

        // The base number of hearts the user's opponent loses.
        public int Jam { get; set; }

        // The result of this contest effect listed in different languages.
        [JsonProperty("effect_entries")]
        public List<EffectType> EffectEntries { get; set; }

        // The flavor text of this contest effect listed in different languages.
        [JsonProperty("flavor_text_entries")]
        public List<FlavorTextType> FlavorTextEntries { get; set; }
    }
}
