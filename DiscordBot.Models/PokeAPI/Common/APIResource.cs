/**********************************************************************
    Author            : Rilegis
    Repository        : DiscordBot
    Project           : DiscordBot.Models
    File name         : APIResource.cs
    Date created      : 29/11/2020
    Purpose           : This file contains PokeAPI's 'APIResource' structure definition.

    Revision History  :
    Date        Author      Ref     Revision 
    29/11/2020  Rilegis     1       First code commit.
    30/11/2020  Rilegis     2       Moved to 'PokeAPI.Common' namespace.
**********************************************************************/

namespace DiscordBot.Models.PokeAPI.Common
{
    public struct APIResource
    {
        // The URL of the referenced resource.
        public string Url { get; set; }
    }
}