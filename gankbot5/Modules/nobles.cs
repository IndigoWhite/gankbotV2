using System;
using System.Collections.Generic;
using System.Text;
using Discord.Commands;
using System.Threading.Tasks;
using Discord;

namespace gankbot5.Modules
{
    [Group("nobles")]
    public class nobles : ModuleBase<SocketCommandContext>
    {

        private string brahneImpressed;

        [Command]
        public async Task noblesAsync()
        {
            Random rnd = new Random();
            int numberOfNobles = rnd.Next(0, 100);

            string actualNobles = "Of 100 nobles watching " + numberOfNobles.ToString() + " were impressed.";
            
            if (numberOfNobles > 79)
            {
                brahneImpressed = " Queen Brahne was impressed.";
            }
            else
            {
                brahneImpressed = " Queen Brahne was not impressed.";
            }
            await ReplyAsync(actualNobles + brahneImpressed);
        }

        [Command("help")]
        public async Task helpAsync()
        {
            await ReplyAsync("PANIC");
        }

    }
}
