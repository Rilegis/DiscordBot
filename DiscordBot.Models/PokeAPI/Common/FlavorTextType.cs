/**********************************************************************
    Author            : Rilegis
    Repository        : DiscordBot
    Project           : DiscordBot.Models
    File name         : FlavorTextType.cs
    Date created      : 23/11/2020
    Purpose           : This file contains PokeAPI's 'FlavorText' structure definition.

    Revision History  :
    Date        Author      Ref     Revision 
    23/11/2020  Rilegis     1       First code commit.
    30/11/2020  Rilegis     2       Moved to 'PokeAPI.Common' namespace.
**********************************************************************/

namespace DiscordBot.Models.PokeAPI.Common
{
    public struct FlavorTextType
    {
        // The localized flavor text for an API resource in a specific language.
        public string FlavorText { get; set; }

        // The language this name is in.
        public NamedAPIResource Language { get; set; }

        // The game version this flavor text is extracted from.
        public NamedAPIResource Version { get; set; }
    }
}
