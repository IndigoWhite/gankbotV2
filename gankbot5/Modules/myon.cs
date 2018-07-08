using System;
using System.Collections.Generic;
using System.Text;
using Discord.Commands;
using System.Threading.Tasks;
using Discord;

namespace gankbot5.Modules
{
    [Group("chris")]
    public class myon : ModuleBase<SocketCommandContext>
    {
        [Command]
        public async Task myonAsync()
        {
            List<string> rndMyon = new List<string>();
            rndMyon.Add("Here is a recent picture of @Myon - http://i.imgur.com/nEaDqdi.jpg");
            rndMyon.Add("If Chris had a theme song it would be - https://www.youtube.com/watch?v=ON-7v4qnHP8");

            Random rnd = new Random();

            string myonMessage = rndMyon[rnd.Next(0, rndMyon.Count)];
            await ReplyAsync(myonMessage);
            return;
        }

        [Command("%")]
        public async Task myonsAsync(int number)
        {
            List<string> rndMyon = new List<string>();
            rndMyon.Add("Here is a recent picture of @Myon - http://i.imgur.com/nEaDqdi.jpg");
            rndMyon.Add("If Chris had a theme song it would be - https://www.youtube.com/watch?v=ON-7v4qnHP8");

            if (number > rndMyon.Count - 1)
            {
                await ReplyAsync("I CANNOT FIND THE RESPONSE FOR " + number.ToString());
                return;
            }
            else
            {
                string myonMessage = rndMyon[number];
                await ReplyAsync(myonMessage);
            }
        }
        [Command("help")]
        public async Task helpAsync()
        {
            await ReplyAsync("PANIC");
        }



    }
}
