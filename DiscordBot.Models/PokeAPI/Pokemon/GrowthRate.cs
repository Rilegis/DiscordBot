/**********************************************************************
    Author            : Rilegis
    Repository        : DiscordBot
    Project           : DiscordBot.Models
    File name         : GrowthRate.cs
    Date created      : 29/11/2020
    Purpose           : This file contains PokeAPI's 'GrowthRate' structure definition.

    Revision History  :
    Date        Author      Ref     Revision 
    30/11/2020  Rilegis     1       First code commit.
**********************************************************************/

using DiscordBot.Models.PokeAPI.Common;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace DiscordBot.Models.PokeAPI.Pokemon
{
    public struct GrowthRate
    {
        // The identifier for this resource.
        public int Id { get; set; }

        // The name for this resource.
        public string Name { get; set; }

        // The formula used to calculate the rate at which the Pokémon species gains level.
        public string Formula { get; set; }

        // The descriptions of this characteristic listed in different languages.
        public List<DescriptionType> Descriptions { get; set; }

        // A list of levels and the amount of experienced needed to atain them based on this growth rate.
        public List<GrowthRateExperienceLevel> Levels { get; set; }

        // A list of Pokémon species that gain levels at this growth rate.
        [JsonProperty("pokemon_species")]
        public List<NamedAPIResource> PokemonSpecies { get; set; }
    }
}
