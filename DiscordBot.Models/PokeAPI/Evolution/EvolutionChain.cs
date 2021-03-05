/**********************************************************************
    Author            : Rilegis
    Repository        : DiscordBot
    Project           : DiscordBot.Models
    File name         : EvolutionChain.cs
    Date created      : 24/11/2020
    Purpose           : This file contains PokeAPI's 'EvolutionChain' structure definition.

    Revision History  :
    Date        Author      Ref     Revision 
    24/11/2020  Rilegis     1       First code commit.
**********************************************************************/

using DiscordBot.Models.PokeAPI.Common;
using Newtonsoft.Json;

namespace DiscordBot.Models.PokeAPI.Evolution
{
    public struct EvolutionChain
    {
        // The identifier for this resource.
        public int Id { get; set; }

        // The item that a Pokémon would be holding when mating that would trigger the egg hatching a baby Pokémon rather than a basic Pokémon.
        [JsonProperty("baby_trigger_item")]
        public NamedAPIResource BabyTriggerItem { get; set; }

        // The base chain link object.
        // Each link contains evolution details for a Pokémon in the chain.
        // Each link references the next Pokémon in the natural evolution order.
        public ChainLink Chain { get; set; }
    }
}
