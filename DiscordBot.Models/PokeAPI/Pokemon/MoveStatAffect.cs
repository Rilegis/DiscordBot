/**********************************************************************
    Author            : Rilegis
    Repository        : DiscordBot
    Project           : DiscordBot.Models
    File name         : MoveStatAffect.cs
    Date created      : 30/11/2020
    Purpose           : This file contains PokeAPI's 'MoveStatAffect' structure definition.

    Revision History  :
    Date        Author      Ref     Revision 
    30/11/2020  Rilegis     1       First code commit.
**********************************************************************/

using DiscordBot.Models.PokeAPI.Common;

namespace DiscordBot.Models.PokeAPI.Pokemon
{
    public struct MoveStatAffect
    {
        // The maximum amount of change to the referenced stat.
        public int Change { get; set; }

        // The move causing the change.
        public NamedAPIResource Move { get; set; }
    }
}