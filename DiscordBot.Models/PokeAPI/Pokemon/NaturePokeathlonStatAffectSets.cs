/**********************************************************************
    Author            : Rilegis
    Repository        : DiscordBot
    Project           : DiscordBot.Models
    File name         : NaturePokeathlonStatAffectSets.cs
    Date created      : 29/11/2020
    Purpose           : This file contains PokeAPI's 'NaturePokeathlonStatAffectSets' structure definition.

    Revision History  :
    Date        Author      Ref     Revision 
    30/11/2020  Rilegis     1       First code commit.
**********************************************************************/

using System.Collections.Generic;

namespace DiscordBot.Models.PokeAPI.Pokemon
{
    public struct NaturePokeathlonStatAffectSets
    {
        // A list of natures and how they change the referenced Pokéathlon stat.
        public List<NaturePokeathlonStatAffect> Increase { get; set; }

        // A list of natures and how they change the referenced Pokéathlon stat.
        public List<NaturePokeathlonStatAffect> Decrease { get; set; }
    }
}