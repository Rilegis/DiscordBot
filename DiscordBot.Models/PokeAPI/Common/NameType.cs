/**********************************************************************
    Author            : Rilegis
    Repository        : DiscordBot
    Project           : DiscordBot.Models
    File name         : NameType.cs
    Date created      : 23/11/2020
    Purpose           : This file contains PokeAPI's 'Name' structure definition.

    Revision History  :
    Date        Author      Ref     Revision 
    23/11/2020  Rilegis     1       First code commit.
    30/11/2020  Rilegis     2       Moved to 'PokeAPI.Common' namespace.
**********************************************************************/

namespace DiscordBot.Models.PokeAPI.Common
{
    public struct NameType
    {
        // The localized name for an API resource in a specific language.
        public string Name { get; set; }

        // The language this name is in.
        public NamedAPIResource Language { get; set; }
    }
}
