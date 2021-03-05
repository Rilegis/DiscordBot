/**********************************************************************
    Author            : Rilegis
    Repository        : DiscordBot
    Project           : DiscordBot.Bot
    File name         : GamesModule.cs
    Date created      : 01/04/2020
    Purpose           : This is a commands module that contains game commands.

    Revision History  :
    Date        Author      Ref     Revision 
    15/01/2021  Rilegis     1       First code commit.
    08/02/2021  Rilegis     2       Switched logging to 'Microsoft.Extensions.Logging'
    22/02/2021  Rilegis     3       Switched logging to simple custom logger, because i do not like
                                    Microsoft's own.
    05/03/2021  Rilegis     4       Removed log from constructor.
**********************************************************************/

using System;
using System.Threading.Tasks;
using Discord.Commands;
using DiscordBot.Models.Logging;

namespace DiscordBot.Bot.Modules
{
    // Modules must be public and inherit from an IModuleBase
    public class GamesModule : ModuleBase<SocketCommandContext>
    {
        // Variables declaration
        private readonly CustomLogger _logger = new CustomLogger(new CustomLoggerConfig(), "GamesModule");

        // Constructor
        public GamesModule()
        {
            
        }

        [Command("ping")]
        public async Task PingAsync()
        {
            await Context.Channel.SendMessageAsync($"{Context.User.Mention} Pong!");
        }

        [Command("echo")]
        [Alias("say")]
        public async Task SayAsync([Remainder] string text)
        {
            await Context.Channel.SendMessageAsync($"{Context.User.Mention} made me say: {text}");
        }

        [Command("8ball"), Alias("8b", "magicball")]
        public async Task MagicBallAsync([Remainder] string text = "")
        {
            // Random number generator instance
            var rand = new Random();

            // Array of random answers
            string[] answers = {
                "As I see it, yes.",
                "Ask again later.",
                "Better not tell you now.",
                "Cannot predict now.",
                "Concentrate and ask again.",
                "Don’t count on it.",
                "It is certain.",
                "It is decidedly so.",
                "Most likely.",
                "My reply is no.",
                "My sources say no.",
                "Outlook not so good.",
                "Outlook good.",
                "Reply hazy, try again.",
                "Signs point to yes.",
                "Very doubtful.",
                "Without a doubt.",
                "Yes.",
                "Yes – definitely.",
                "You may rely on it.",
                "Absolutely!",
                "Could be, could be...",
                "In your dreams.",
                "Why not?",
                "Of course.",
                "I'd better shut up...",
                "Shut up!",
                "I'm so cute :3",
            };

            if (text.Equals(""))
                await Context.Channel.SendMessageAsync($"{Context.User.Mention} It would be nice if you asked a question...you know...?");
            else
                await Context.Channel.SendMessageAsync($"{Context.User.Mention} {answers[rand.Next(answers.Length)]}");
        }
    }
}
