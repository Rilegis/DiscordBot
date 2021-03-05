/**********************************************************************
    Author            : Rilegis
    Repository        : DiscordBot
    Project           : DiscordBot.Models
    File name         : ContestComboSets.cs
    Date created      : 29/11/2020
    Purpose           : This file contains PokeAPI's 'ContestComboSets' structure definition.

    Revision History  :
    Date        Author      Ref     Revision 
    29/11/2020  Rilegis     1       First code commit.
**********************************************************************/

namespace DiscordBot.Models.PokeAPI.Move
{
    public struct ContestComboSets
    {
        // A detail of moves this move can be used before or after, granting additional appeal points in contests.
        public ContestComboDetail Normal { get; set; }

        // A detail of moves this move can be used before or after, granting additional appeal points in super contests.
        public ContestComboDetail Super { get; set; }
    }
}