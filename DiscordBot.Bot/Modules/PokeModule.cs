/**********************************************************************
    Author            : Rilegis
    Repository        : DiscordBot
    Project           : DiscordBot.Bot
    File name         : PokeModule.cs
    Date created      : 09/11/2020
    Purpose           : This is command module that contains commands
                        for PokeAPI.

    Revision History  :
    Date        Author      Ref     Revision 
    09/11/2020  Rilegis     1       First code commit.
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
    public class PokeModule : ModuleBase<SocketCommandContext>
    {
        // Variables declaration
        private readonly CustomLogger _logger = new CustomLogger(new CustomLoggerConfig(), "PokeModule");
        private static readonly string _apiUrl = "https://pokeapi.co/api/v2/";
        private static readonly Random _rand = new Random();

        // Constructor
        public PokeModule()
        {
            
        }

        [Command("poke")]
        [Alias("pokeapi", "pokemon")]
        public async Task PokeAsync(params string[] args)
        {
            try
            {
                // Reply only if channel is 'poke-api' or 'pokemon'
                if ((Context.Channel.Name != "poke-api") && (Context.Channel.Name != "pokemon")) return;

                //
                if (args[0].ToLower().Equals("berry"))
                {
                    Console.WriteLine(args[0]);
                }
                else if (args[0].ToLower().Equals("contest"))
                {
                    Console.WriteLine(args[0]);
                }
                else if (args[0].ToLower().Equals("encounter"))
                {
                    Console.WriteLine(args[0]);
                }
                else if (args[0].ToLower().Equals("evolution"))
                {
                    Console.WriteLine(args[0]);
                }
                else if (args[0].ToLower().Equals("game"))
                {
                    Console.WriteLine(args[0]);
                }
                else if (args[0].ToLower().Equals("item"))
                {
                    Console.WriteLine(args[0]);
                }
                else if (args[0].ToLower().Equals("location"))
                {
                    Console.WriteLine(args[0]);
                }
                else if (args[0].ToLower().Equals("machine"))
                {
                    Console.WriteLine(args[0]);
                }
                else if (args[0].ToLower().Equals("move"))
                {
                    Console.WriteLine(args[0]);
                }
                else if (args[0].ToLower().Equals("pokemon"))
                {
                    Console.WriteLine(args[0]);
                }
                else
                {
                    await Context.Channel.SendMessageAsync($"{Context.User.Mention} : Unknown argument '{args[0].ToLower()}'!");
                }


                //HttpClient client = new HttpClient
                //{
                //    BaseAddress = new Uri(_apiUrl)
                //};

                //// Add an Accept header for JSON format
                //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //// Get data response
                //HttpResponseMessage response = client.GetAsync($"{args[0]}/{args[1]}").Result;
                //if (response.IsSuccessStatusCode)
                //{
                //    string jsonBlob = await response.Content.ReadAsStringAsync();
                //    Berry berry = JsonConvert.DeserializeObject<Berry>(jsonBlob); // JSON blob file deserialization

                //    // Build 'Flavour stats' object value
                //    string value = "";
                //    int i = 0;
                //    foreach (BerryFlavorMap flavor in berry.Flavors)
                //    {
                //        value = $"{value}\n{char.ToUpper(berry.Flavors[i].Flavor.Name[0])}{berry.Flavors[i].Flavor.Name[1..]}: {berry.Flavors[i].Potency}";
                //        i++;
                //    }
                //    i = 0;

                //    var embed = new EmbedBuilder()
                //        .WithTitle($"{char.ToUpper(berry.Name[0])}{berry.Name[1..]} Berry")
                //        .WithDescription("**Berry description**\nA Berry to be consumed by Pokémon. If a Pokémon holds one, it can recover from paralysis on its own in battle.")
                //        .WithUrl($"https://bulbapedia.bulbagarden.net/wiki/{char.ToUpper(berry.Name[0])}{berry.Name[1..]}_Berry")
                //        .WithColor(new Color(_rand.Next(256), _rand.Next(256), _rand.Next(256)))
                //        .WithThumbnailUrl($"https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/items/{berry.Item.Name}.png")
                //        .AddField("Natural gift", $"Type: {berry.NaturalGiftType.Name}\nPower: {berry.NaturalGiftPower}", true)
                //        .AddField("Growth", $"Soil dryness: {berry.SoilDryness}\nGrowth time: {berry.GrowthTime}\nMax yeld: {berry.MaxHarvest}", true)
                //        .AddField("Flavour stats", value, true);

                //    await Context.Channel.SendMessageAsync("", false, embed.Build());
                //}
                //else
                //{
                //    await Context.Channel.SendMessageAsync($"{Context.User.Mention} : Error!");
                //}
            }
            catch (Exception ex)
            {
                await Context.Channel.SendMessageAsync($"Error! Saving stacktrace...\nNotifying owner...");
                _logger.LogCritical(ex.Message);
            }
        }
    }
}
