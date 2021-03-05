/**********************************************************************
    Author            : Rilegis
    Repository        : DiscordBot
    Project           : DiscordBot.Models
    File name         : PokemonFormSprites.cs
    Date created      : 30/11/2020
    Purpose           : This file contains PokeAPI's 'PokemonFormSprites' structure definition.

    Revision History  :
    Date        Author      Ref     Revision 
    30/11/2020  Rilegis     1       First code commit.
**********************************************************************/

using Newtonsoft.Json;

namespace DiscordBot.Models.PokeAPI.Pokemon
{
    public struct PokemonFormSprites
    {
        // The default depiction of this Pokémon form from the front in battle.
        [JsonProperty("front_default")]
        public string FrontDefault { get; set; }

        // The shiny depiction of this Pokémon form from the front in battle.
        [JsonProperty("front_shiny")]
        public string FrontShiny { get; set; }

        // The default depiction of this Pokémon form from the back in battle.
        [JsonProperty("back_default")]
        public string BackDefault { get; set; }

        // The shiny depiction of this Pokémon form from the back in battle.
        [JsonProperty("back_shiny")]
        public string BackShiny { get; set; }
    }
}