/**********************************************************************
    Author            : Rilegis
    Repository        : DiscordBot
    Project           : DiscordBot.Models
    File name         : NatureStatAffectSets.cs
    Date created      : 30/11/2020
    Purpose           : This file contains PokeAPI's 'NatureStatAffectSets' structure definition.

    Revision History  :
    Date        Author      Ref     Revision 
    30/11/2020  Rilegis     1       First code commit.
**********************************************************************/

using DiscordBot.Models.PokeAPI.Common;
using System.Collections.Generic;

namespace DiscordBot.Models.PokeAPI.Pokemon
{
    public struct NatureStatAffectSets
    {
        // A list of natures and how they change the referenced stat.
        public List<NamedAPIResource> Increase { get; set; }

        // A list of nature sand how they change the referenced stat.
        public List<NamedAPIResource> Decrease { get; set; }
    }
}