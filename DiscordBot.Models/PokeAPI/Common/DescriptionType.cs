/**********************************************************************
    Author            : Rilegis
    Repository        : DiscordBot
    Project           : DiscordBot.Models
    File name         : DescriptionType.cs
    Date created      : 24/11/2020
    Purpose           : This file contains PokeAPI's 'Description' structure definition.

    Revision History  :
    Date        Author      Ref     Revision 
    24/11/2020  Rilegis     1       First code commit.
    30/11/2020  Rilegis     2       Moved to 'PokeAPI.Common' namespace.
**********************************************************************/

namespace DiscordBot.Models.PokeAPI.Common
{
    public struct DescriptionType
    {
        // The localized description for an API resource in a specific language.
        public string Description { get; set; }

        // The language this name is in.
        public NamedAPIResource Language { get; set; }
    }
}
