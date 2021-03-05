/**********************************************************************
    Author            : Rilegis
    Repository        : DiscordBot
    Project           : DiscordBot.Models
    File name         : EffectType.cs
    Date created      : 23/11/2020
    Purpose           : This file contains PokeAPI's 'Effect' structure definition.

    Revision History  :
    Date        Author      Ref     Revision 
    23/11/2020  Rilegis     1       First code commit.
    30/11/2020  Rilegis     2       Moved to 'PokeAPI.Common' namespace.
**********************************************************************/

namespace DiscordBot.Models.PokeAPI.Common
{
    public struct EffectType
    {
        // The localized effect text for an API resource in a specific language.
        public string Effect { get; set; }

        // The language this effect is in.
        public NamedAPIResource Language { get; set; }
    }
}
