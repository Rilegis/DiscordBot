/**********************************************************************
    Author            : Rilegis
    Repository        : DiscordBot
    Project           : DiscordBot.Models
    File name         : EggGroup.cs
    Date created      : 29/11/2020
    Purpose           : This file contains PokeAPI's 'EggGroup' structure definition.

    Revision History  :
    Date        Author      Ref     Revision 
    30/11/2020  Rilegis     1       First code commit.
**********************************************************************/

using DiscordBot.Models.PokeAPI.Common;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace DiscordBot.Models.PokeAPI.Pokemon
{
    public struct EggGroup
    {
        // The identifier for this resource.
        public int Id { get; set; }

        // The name for this resource.
        public string Name { get; set; }

        // The name of this resource listed in different languages.
        public List<NameType> Names { get; set; }

        // A list of all Pokémon species that are members of this egg group.
        [JsonProperty("pokemon_species")]
        public List<NamedAPIResource> PokemonSpecies { get; set; }
    }
}
