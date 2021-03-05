/**********************************************************************
    Author            : Rilegis
    Repository        : DiscordBot
    Project           : DiscordBot.Models
    File name         : GrowthRateExperienceLevel.cs
    Date created      : 29/11/2020
    Purpose           : This file contains PokeAPI's 'GrowthRateExperienceLevel' structure definition.

    Revision History  :
    Date        Author      Ref     Revision 
    30/11/2020  Rilegis     1       First code commit.
**********************************************************************/

namespace DiscordBot.Models.PokeAPI.Pokemon
{
    public struct GrowthRateExperienceLevel
    {
        // The level gained.
        public int Level { get; set; }

        // The amount of experience required to reach the referenced level.
        public int Experience { get; set; }
    }
}