/**********************************************************************
    Author            : Rilegis
    Repository        : DiscordBot
    Project           : DiscordBot.Models
    File name         : BerryFirmnessType.cs
    Date created      : 23/11/2020
    Purpose           : This file contains PokeAPI's 'BerryFirmness' structure definition.

    Revision History  :
    Date        Author      Ref     Revision 
    23/11/2020  Rilegis     1       First code commit.
**********************************************************************/

using DiscordBot.Models.PokeAPI.Common;
using System.Collections.Generic;

namespace DiscordBot.Models.PokeAPI.Berry
{
    public struct BerryFirmness
    {
        // The identifier for this resource.
        public int Id { get; set; }

        //  The name for this resource.
        public string Name { get; set; }

        //  A list of the berries with this firmness.
        public List<NamedAPIResource> Berries { get; set; }

        // The name of this resource listed in different languages.
        public List<NameType> Names { get; set; }
    }
}
