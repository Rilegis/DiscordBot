/**********************************************************************
    Author            : Rilegis
    Repository        : DiscordBot
    Project           : DiscordBot.Models
    File name         : Characteristics.cs
    Date created      : 29/11/2020
    Purpose           : This file contains PokeAPI's 'Characteristics' structure definition.

    Revision History  :
    Date        Author      Ref     Revision 
    30/11/2020  Rilegis     1       First code commit.
**********************************************************************/

using Newtonsoft.Json;

namespace DiscordBot.Models.PokeAPI.Pokemon
{
    public struct Characteristics
    {
        // The identifier for this resource.
        public int Id { get; set; }

        // The remainder of the highest stat/IV divided by 5.
        [JsonProperty("gene_modulo")]
        public int GeneModulo { get; set; }

        // The possible values of the highest stat that would result in a Pokémon recieving this characteristic when divided by 5.
        [JsonProperty("possible_values")]
        public int[] PossibleValues { get; set; }
    }
}
