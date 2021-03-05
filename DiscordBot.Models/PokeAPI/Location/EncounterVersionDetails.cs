/**********************************************************************
    Author            : Rilegis
    Repository        : DiscordBot
    Project           : DiscordBot.Models
    File name         : EncounterVersionDetails.cs
    Date created      : 29/11/2020
    Purpose           : This file contains PokeAPI's 'EncounterVersionDetails' structure definition.

    Revision History  :
    Date        Author      Ref     Revision 
    29/11/2020  Rilegis     1       First code commit.
**********************************************************************/

using DiscordBot.Models.PokeAPI.Common;

namespace DiscordBot.Models.PokeAPI.Location
{
    public struct EncounterVersionDetails
    {
        // The chance of an encounter to occur.
        public int Rate { get; set; }

        // The version of the game in which the encounter can occur with the given chance.
        public NamedAPIResource Version { get; set; }
    }
}