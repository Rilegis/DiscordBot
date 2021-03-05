/**********************************************************************
    Author            : Rilegis
    Repository        : DiscordBot
    Project           : DiscordBot.Models
    File name         : NamedAPIResource.cs
    Date created      : 23/11/2020
    Purpose           : Structure containing the reference to a specific type.

    Revision History  :
    Date        Author      Ref     Revision 
    23/11/2020  Rilegis     1       First code commit.
    30/11/2020  Rilegis     2       Moved to 'PokeAPI.Common' namespace.
**********************************************************************/

namespace DiscordBot.Models.PokeAPI.Common
{
    public struct NamedAPIResource
    {
        // The name of the referenced resource.
        public string Name { get; set; }

        // The URL of the referenced resource.
        public string Url { get; set; }
    }
}
