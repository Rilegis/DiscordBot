/**********************************************************************
    Author            : Rilegis
    Repository        : DiscordBot
    Project           : DiscordBot.Models
    File name         : PalParkEncounterArea.cs
    Date created      : 30/11/2020
    Purpose           : This file contains PokeAPI's 'PalParkEncounterArea' structure definition.

    Revision History  :
    Date        Author      Ref     Revision 
    30/11/2020  Rilegis     1       First code commit.
**********************************************************************/

using DiscordBot.Models.PokeAPI.Common;
using Newtonsoft.Json;

namespace DiscordBot.Models.PokeAPI.Pokemon
{
    public struct PalParkEncounterArea
    {
        // The base score given to the player when the referenced Pokémon is caught during a pal park run.
        [JsonProperty("base_score")]
        public int BaseScore { get; set; }

        // The base rate for encountering the referenced Pokémon in this pal park area.
        public int Rate { get; set; }

        // The pal park area where this encounter happens.
        public NamedAPIResource Area { get; set; }
    }
}