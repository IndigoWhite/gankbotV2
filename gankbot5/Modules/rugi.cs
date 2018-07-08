using System;
using System.Collections.Generic;
using System.Text;
using Discord.Commands;
using System.Threading.Tasks;
using Discord;

namespace gankbot5.Modules
{
    [Group("rugi")]
    public class rugi : ModuleBase<SocketCommandContext>
    {
        [Command]
        public async Task rugiAsync()
        {
            List<string> rndrugi = new List<string>();
            rndrugi.Add("Here is Rugis latest single - https://www.youtube.com/watch?v=0doSWS0Fj24");
            rndrugi.Add("Rugi sometimes works at McDonalds when he needs a bit of spare cash - https://www.youtube.com/watch?v=A6m0M4se_QQ");
            rndrugi.Add("Rugi was last heard saying - http://s2.quickmeme.com/img/62/62b15dec772e1c51e1c6fcbcc5c52b245bf29a8143e84ecc689e79c424b52de2.jpg");

            Random rnd = new Random();

            string rugiMessage = rndrugi[rnd.Next(0, rndrugi.Count)];
            await ReplyAsync(rugiMessage);
            return;
        }

        [Command("%")]
        public async Task rugisAsync(int number)
        {
            List<string> rndrugi = new List<string>();
            rndrugi.Add("Here is Rugis latest single - https://www.youtube.com/watch?v=0doSWS0Fj24");
            rndrugi.Add("Rugi sometimes works at McDonalds when he needs a bit of spare cash - https://www.youtube.com/watch?v=A6m0M4se_QQ");
            rndrugi.Add("Rugi was last heard saying - http://s2.quickmeme.com/img/62/62b15dec772e1c51e1c6fcbcc5c52b245bf29a8143e84ecc689e79c424b52de2.jpg");

            if (number > rndrugi.Count - 1)
            {
                await ReplyAsync("I CANNOT FIND THE RESPONSE FOR " + number.ToString());
                return;
            }
            else
            {
                string rugiMessage = rndrugi[number];
                await ReplyAsync(rugiMessage);
            }
        }
        [Command("help")]
        public async Task helpAsync()
        {
            await ReplyAsync("PANIC");
        }
    }
}
