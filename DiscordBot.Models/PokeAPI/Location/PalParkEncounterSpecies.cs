/**********************************************************************
    Author            : Rilegis
    Repository        : DiscordBot
    Project           : DiscordBot.Models
    File name         : PalParkEncounterSpecies.cs
    Date created      : 29/11/2020
    Purpose           : This file contains PokeAPI's 'PalParkEncounterSpecies' structure definition.

    Revision History  :
    Date        Author      Ref     Revision 
    29/11/2020  Rilegis     1       First code commit.
**********************************************************************/

using DiscordBot.Models.PokeAPI.Common;
using Newtonsoft.Json;

namespace DiscordBot.Models.PokeAPI.Location
{
    public struct PalParkEncounterSpecies
    {
        // The base score given to the player when this Pokémon is caught during a pal park run.
        [JsonProperty("base_score")]
        public int BaseScore { get; set; }

        // The base rate for encountering this Pokémon in this pal park area.
        public int Rate { get; set; }

        // The Pokémon species being encountered.
        [JsonProperty("pokemon_species")]
        public NamedAPIResource PokemonSpecies { get; set; }
    }
}