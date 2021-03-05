/**********************************************************************
    Author            : Rilegis
    Repository        : DiscordBot
    Project           : DiscordBot.Models
    File name         : EncounterCondition.cs
    Date created      : 23/11/2020
    Purpose           : This file contains PokeAPI's 'EncounterCondition' structure definition.

    Revision History  :
    Date        Author      Ref     Revision 
    23/11/2020  Rilegis     1       First code commit.
**********************************************************************/

using DiscordBot.Models.PokeAPI.Common;
using System.Collections.Generic;

namespace DiscordBot.Models.PokeAPI.Encounter
{
    public struct EncounterCondition
    {
        // The identifier for this resource.
        public int Id { get; set; }

        // The name for this resource.
        public string Name { get; set; }

        // The name of this resource listed in different languages.
        public List<NameType> Names { get; set; }

        // A list of possible values for this encounter condition.
        public List<NamedAPIResource> Values { get; set; }
    }
}
