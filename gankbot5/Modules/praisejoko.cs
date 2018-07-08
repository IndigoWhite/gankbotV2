using System;
using System.Collections.Generic;
using System.Text;
using Discord.Commands;
using System.Threading.Tasks;
using Discord;

namespace gankbot5.Modules
{
    [Group("praisejoko")]
    public class praisejoko : ModuleBase<SocketCommandContext>
    {
       [Command]
        public async Task jokoAsync()
        {
            List<string> rndjoko = new List<string>();
            rndjoko.Add("Praise Joko! :praisejoko:");
            rndjoko.Add("Praise our high and mighty Palawa Joko! :praisejoko:");

            Random rnd = new Random();

            string jokoMessage = rndjoko[rnd.Next(0, rndjoko.Count)];
            await ReplyAsync(jokoMessage);
            return;
        }

        [Command("%")]
        public async Task jokosAsync(int number)
        {
            List<string> rndjoko = new List<string>();
            rndjoko.Add("Praise Joko! :praisejoko:");
            rndjoko.Add("Praise our high and mighty Palawa Joko! :praisejoko:");

            if (number > rndjoko.Count - 1)
            {
                await ReplyAsync("I CANNOT FIND THE RESPONSE FOR " + number.ToString());
                return;
            }
            else
            {
                string jokoMessage = rndjoko[number];
                await ReplyAsync(jokoMessage);
            }
        }
        [Command("help")]
        public async Task helpAsync()
        {
            await ReplyAsync("PANIC");
        }

    }
}
