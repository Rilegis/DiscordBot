/**********************************************************************
    Author            : Rilegis
    Repository        : DiscordBot
    Project           : DiscordBot.Models
    File name         : FlavorType.cs
    Date created      : 23/11/2020
    Purpose           : Structure containing the reference to a specific flavor type.

    Revision History  :
    Date        Author      Ref     Revision 
    23/11/2020  Rilegis     1       Class separated to it's own model file.
                                    Class renamed to 'FlavorType', previously 'Flavors'.
**********************************************************************/

using DiscordBot.Models.PokeAPI.Common;

namespace DiscordBot.Models.PokeAPI.Berry
{
    public struct BerryFlavorMap
    {
        //  How powerful the referenced flavor is for this berry.
        public int Potency { get; set; }

        //  The referenced berry flavor.
        public NamedAPIResource Flavor { get; set; }
    }
}
