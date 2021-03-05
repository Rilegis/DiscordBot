/**********************************************************************
    Author            : Rilegis
    Repository        : DiscordBot
    Project           : DiscordBot.Models
    File name         : ChainLink.cs
    Date created      : 24/11/2020
    Purpose           : This file contains PokeAPI's 'ChainLink' structure definition.

    Revision History  :
    Date        Author      Ref     Revision 
    24/11/2020  Rilegis     1       First code commit.
**********************************************************************/

using DiscordBot.Models.PokeAPI.Common;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace DiscordBot.Models.PokeAPI.Evolution
{
    public struct ChainLink
    {
        // Whether or not this link is for a baby Pokémon.
        // This would only ever be true on the base link.
        [JsonProperty("is_baby")]
        public bool IsBaby { get; set; }

        // The Pokémon species at this point in the evolution chain.
        public NamedAPIResource Species { get; set; }

        // All details regarding the specific details of the referenced Pokémon species evolution.
        [JsonProperty("evolution_details")]
        public List<EvolutionDetail> EvolutionDetails { get; set; }

        // A List of chain objects.
        [JsonProperty("evolves_to")]
        public List<ChainLink> EvlvesTo { get; set; }
    }
}