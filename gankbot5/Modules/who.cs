using System;
using System.Collections.Generic;
using System.Text;
using Discord.Commands;
using System.Threading.Tasks;
using Discord;

namespace gankbot5.Modules
{
    [Group("who")]
    public class who : ModuleBase<SocketCommandContext>
    {
        [Command]
        public async Task whoAsync()
        {
            List<string> rndwho = new List<string>();
            rndwho.Add("https://i.imgur.com/F999NAf.jpg are we talking about my favourite wrestler?");
            rndwho.Add("https://www.youtube.com/watch?v=utBtRxPFPXU never heard of em");
            rndwho.Add("Time for some music - https://www.youtube.com/watch?v=gY5rztWa1TM");

            Random rnd = new Random();

            string whoMessage = rndwho[rnd.Next(0, rndwho.Count)];
            await ReplyAsync(whoMessage);
            return;
        }

        [Command("%")]
        public async Task whosAsync(int number)
        {
            List<string> rndwho = new List<string>();
            rndwho.Add("https://i.imgur.com/F999NAf.jpg are we talking about my favourite wrestler?");
            rndwho.Add("https://www.youtube.com/watch?v=utBtRxPFPXU never heard of em");
            rndwho.Add("Time for some music - https://www.youtube.com/watch?v=gY5rztWa1TM");

            if (number > rndwho.Count - 1)
            {
                await ReplyAsync("I CANNOT FIND THE RESPONSE FOR " + number.ToString());
                return;
            }
            else
            {
                string whoMessage = rndwho[number];
                await ReplyAsync(whoMessage);
            }
        }
        [Command("help")]
        public async Task helpAsync()
        {
            await ReplyAsync("PANIC");
        }

    }
}
