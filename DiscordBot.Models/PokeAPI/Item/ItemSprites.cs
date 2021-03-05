/**********************************************************************
    Author            : Rilegis
    Repository        : DiscordBot
    Project           : DiscordBot.Models
    File name         : ItemSprites.cs
    Date created      : 29/11/2020
    Purpose           : This file contains PokeAPI's 'ItemSprites' structure definition.

    Revision History  :
    Date        Author      Ref     Revision 
    29/11/2020  Rilegis     1       First code commit.
**********************************************************************/

namespace DiscordBot.Models.PokeAPI.Item
{
    public struct ItemSprites
    {
        // The default depiction of this item.
        public string Default { get; set; }
    }
}