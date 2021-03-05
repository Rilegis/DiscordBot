/**********************************************************************
    Author            : Rilegis
    Repository        : DiscordBot
    Project           : DiscordBot.Models
    File name         : PokemonSprites.cs
    Date created      : 30/11/2020
    Purpose           : This file contains PokeAPI's 'PokemonSprites' structure definition.

    Revision History  :
    Date        Author      Ref     Revision 
    30/11/2020  Rilegis     1       First code commit.
**********************************************************************/

using Newtonsoft.Json;

namespace DiscordBot.Models.PokeAPI.Pokemon
{
    public struct PokemonSprites
    {
        // The default depiction of this Pokémon from the front in battle.
        [JsonProperty("front_default")]
        public string FrontDefault { get; set; }

        // The shiny depiction of this Pokémon from the front in battle.
        [JsonProperty("front_shiny")]
        public string FrontShiny { get; set; }

        // The female depiction of this Pokémon from the front in battle.
        [JsonProperty("front_female")]
        public string FrontFemale { get; set; }

        // The shiny female depiction of this Pokémon from the front in battle.
        [JsonProperty("front_shiny_female")]
        public string FrontShinyFemale{ get; set; }

        // The default depiction of this Pokémon from the back in battle.
        [JsonProperty("back_default")]
        public string BackDefault { get; set; }

        // The shiny depiction of this Pokémon from the back in battle.
        [JsonProperty("back_shiny")]
        public string BackShiny { get; set; }

        // The female depiction of this Pokémon from the back in battle.
        [JsonProperty("back_female")]
        public string BackFemale { get; set; }

        // The shiny female depiction of this Pokémon from the back in battle.
        [JsonProperty("back_shiny_female")]
        public string BackShinyFemale { get; set; }
    }
}