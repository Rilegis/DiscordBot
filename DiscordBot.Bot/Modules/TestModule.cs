/**********************************************************************
    Author            : Rilegis
    Repository        : DiscordBot
    Project           : DiscordBot.Bot
    File name         : TestModule.cs
    Date created      : 23/11/2020
    Purpose           : This is command module that contains commands
                        that are in development.

    Revision History  :
    Date        Author      Ref     Revision 
    23/11/2020  Rilegis     1       First code commit.
    05/02/2021  Rilegis     2       Added '#if DEBUG' macro
    08/02/2021  Rilegis     3       Switched logging to 'Microsoft.Extensions.Logging'
    22/02/2021  Rilegis     4       Switched logging to simple custom logger, because i do not like
                                    Microsoft's own.
    05/03/2021  Rilegis     5       Removed log from constructor.
**********************************************************************/

#if DEBUG
using System.Threading.Tasks;
using Discord;
using Discord.Commands;
using DiscordBot.Models.Logging;

namespace DiscordBot.Bot.Modules
{
    // Modules must be public and inherit from an IModuleBase
    public class TestModule : ModuleBase<SocketCommandContext>
    {
        // Variables declaration
        private readonly CustomLogger _logger = new CustomLogger(new CustomLoggerConfig(), "TestModule");

        // Constructor
        public TestModule()
        {
            
        }

        [Command("args")]
        public async Task ArgsAsync(params string[] args)
        {
            string output = "Command arguments:\n";
            int i = 0;

            foreach (string arg in args)
            {
                output = $"{output}`args[{i}]: {arg}`\n";
                i++;
            }

            await Context.Channel.SendMessageAsync($"{output}");
        }

        [Command("embed")]
        public async Task EmbedAsync()
        {
            var embed = new EmbedBuilder()
            {
                Title = "Embed title",
                Description = "Embed description"
            }.Build();

            await Context.Channel.SendMessageAsync("", false, embed);
        }
    }
}
#endif