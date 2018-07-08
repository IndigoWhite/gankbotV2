using System;
using System.Collections.Generic;
using System.Text;
using Discord.Commands;
using System.Threading.Tasks;
using Discord;

namespace gankbot5.Modules
{
    [Group("midgets")]
    public class asurans : ModuleBase<SocketCommandContext>
    {        
        [Command]
        public async Task midgetsAsync()
        {
                        
            List<string> rndMidgets = new List<string>();
            rndMidgets.Add("The Asuran Race are just somewhat intelligent bobbleheads.");
            rndMidgets.Add("Asurans make great doorstops.");
            rndMidgets.Add("I dislike Asurans. I also dislike Moas.");
            rndMidgets.Add("Asurans are officially the worst midget race in Tyria - https://goo.gl/4Ag3vE");

            Random rnd = new Random();
            
            string midgetMessage = rndMidgets[rnd.Next(0, rndMidgets.Count)];
            await ReplyAsync(midgetMessage);
            return;            
        }
        [Command ("%")]
        public async Task midgetsAsync(int number)
        {
            List<string> rndMidgets = new List<string>();
            rndMidgets.Add("The Asuran Race are just somewhat intelligent bobbleheads.");
            rndMidgets.Add("Asurans make great doorstops.");
            rndMidgets.Add("I dislike Asurans. I also dislike Moas.");
            rndMidgets.Add("Asurans are officially the worst midget race in Tyria - https://goo.gl/4Ag3vE");

            
            if (number > rndMidgets.Count-1)
            {
                await ReplyAsync("I CANNOT FIND THE RESPONSE FOR " + number.ToString());
                return;
            }
            else
            {
                string midgetMessage = rndMidgets[number];
                await ReplyAsync(midgetMessage);
            }
        }
        [Command ("help")]
        public async Task helpAsync()
        {
            await ReplyAsync("PANIC");
        }

    }
}
