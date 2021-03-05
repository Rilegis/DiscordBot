/**********************************************************************
    Author            : Rilegis
    Repository        : DiscordBot
    Project           : DiscordBot.Bot
    File name         : BaseModule.cs
    Date created      : 01/04/2020
    Purpose           : This is a commands base module, copy this, rename it
                        and edit to add more modules.

    Revision History  :
    Date        Author      Ref     Revision 
    01/04/2020  Rilegis     1       First code commit.
    08/02/2021  Rilegis     2       Switched logging to 'Microsoft.Extensions.Logging'
    22/02/2021  Rilegis     3       Switched logging to simple custom logger, because i do not like
                                    Microsoft's own.
    05/03/2021  Rilegis     4       Removed log from constructor.
**********************************************************************/

using Discord.Commands;
using DiscordBot.Models.Logging;

namespace DiscordBot.Bot.Modules
{
    // Modules must be public and inherit from an IModuleBase
    public class BaseModule : ModuleBase<SocketCommandContext>
    {
        // Variables declaration
        private readonly CustomLogger _logger = new CustomLogger(new CustomLoggerConfig(), "BaseModule");

        // Constructor
        public BaseModule()
        {
            
        }
    }
}
