/**********************************************************************
    Author            : Rilegis
    Repository        : DiscordBot
    Project           : DiscordBot.Models
    File name         : MoveStatAffectSets.cs
    Date created      : 30/11/2020
    Purpose           : This file contains PokeAPI's 'MoveStatAffectSets' structure definition.

    Revision History  :
    Date        Author      Ref     Revision 
    30/11/2020  Rilegis     1       First code commit.
**********************************************************************/

using System.Collections.Generic;

namespace DiscordBot.Models.PokeAPI.Pokemon
{
    public struct MoveStatAffectSets
    {
        // A list of moves and how they change the referenced stat.
        public List<MoveStatAffect> Increase { get; set; }

        // A list of moves and how they change the referenced stat.
        public List<MoveStatAffect> Decrease { get; set; }
    }
}