/**********************************************************************
    Author            : Rilegis
    Repository        : DiscordBot
    Project           : DiscordBot.Models
    File name         : Language.cs
    Date created      : 29/11/2020
    Purpose           : This file contains PokeAPI's 'Language' structure definition.

    Revision History  :
    Date        Author      Ref     Revision 
    29/11/2020  Rilegis     1       First code commit.
    30/11/2020  Rilegis     2       Moved to 'PokeAPI.Common' namespace.
**********************************************************************/

using System.Collections.Generic;

namespace DiscordBot.Models.PokeAPI.Common.Common
{
    public struct Language
    {
        // The identifier for this resource.
        public int Id { get; set; }

        // The name for this resource.
        public string Name { get; set; }

        // Whether or not the games are published in this language.
        public bool Official { get; set; }

        // The two-letter code of the country where this language is spoken. Note that it is not unique.
        public string Iso369 { get; set; }

        // The two-letter code of the language. Note that it is not unique.
        public string Iso3166 { get; set; }

        // The name of this resource listed in different languages.
        public List<NameType> Names { get; set; }
    }
}
