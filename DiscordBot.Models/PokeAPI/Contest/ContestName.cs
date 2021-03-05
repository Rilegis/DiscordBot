/**********************************************************************
    Author            : Rilegis
    Repository        : DiscordBot
    Project           : DiscordBot.Models
    File name         : ContestName.cs
    Date created      : 23/11/2020
    Purpose           : This file contains PokeAPI's 'ContestName' structure definition.

    Revision History  :
    Date        Author      Ref     Revision 
    23/11/2020  Rilegis     1       First code commit.
**********************************************************************/

using DiscordBot.Models.PokeAPI.Common;

namespace DiscordBot.Models.PokeAPI.Contest
{
    public struct ContestName
    {
        // The name for this contest.
        public string Name { get; set; }

        // The color associated with this contest's name.
        public string Color { get; set; }

        // The language that this name is in.
        public NamedAPIResource Language { get; set; }
    }
}