/**********************************************************************
    Author            : Rilegis
    Repository        : DiscordBot
    Project           : DiscordBot.Models
    File name         : MoveStatChange.cs
    Date created      : 29/11/2020
    Purpose           : This file contains PokeAPI's 'MoveStatChange' structure definition.

    Revision History  :
    Date        Author      Ref     Revision 
    29/11/2020  Rilegis     1       First code commit.
**********************************************************************/

using DiscordBot.Models.PokeAPI.Common;

namespace DiscordBot.Models.PokeAPI.Move
{
    public struct MoveStatChange
    {
        // The amount of change.
        public int Change { get; set; }

        // The stat being affected.
        public NamedAPIResource Stat { get; set; }
    }
}