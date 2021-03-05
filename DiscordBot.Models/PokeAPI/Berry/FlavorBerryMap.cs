/**********************************************************************
    Author            : Rilegis
    Repository        : DiscordBot
    Project           : DiscordBot.Models
    File name         : FlavorBerryMap.cs
    Date created      : 23/11/2020
    Purpose           : This file contains PokeAPI's 'FlavorBerryMap' structure definition.

    Revision History  :
    Date        Author      Ref     Revision 
    23/11/2020  Rilegis     1       First code commit.
**********************************************************************/

using DiscordBot.Models.PokeAPI.Common;

namespace DiscordBot.Models.PokeAPI.Berry
{
    public struct FlavorBerryMap
    {
        // How powerful the referenced flavor is for this berry
        public int Potency { get; set; }

        // The berry with the referenced flavor.
        public NamedAPIResource Berry { get; set; }
    }
}