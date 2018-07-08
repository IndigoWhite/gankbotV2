using System;
using System.Collections.Generic;
using System.Text;
using Discord.Commands;
using System.Threading.Tasks;
using Discord;

namespace gankbot5.Modules
{
    [Group("lucid")]
    public class lucid : ModuleBase<SocketCommandContext>
    {

        [Command]
        public async Task lucidAsync()
        {

            List<string> rndLucid = new List<string>();
            rndLucid.Add("https://i.makeagif.com/media/12-14-2015/qXzZVA.gif'");
            rndLucid.Add("https://www.youtube.com/watch?v=_CBLDA86LMQ");
            rndLucid.Add("http://www.gifbin.com/bin/112014/1417109336_guy_falls_off_roof.gif");
            rndLucid.Add("https://www.youtube.com/watch?v=FunoDTsdr2E");
            rndLucid.Add("https://giant.gfycat.com/InfinitePointlessDeviltasmanian.webm  maybe not this time.");
            rndLucid.Add("https://www.youtube.com/watch?v=bvim4rsNHkQ");


            Random rnd = new Random();

            string lucidMessage = rndLucid[rnd.Next(0, rndLucid.Count)];
            await ReplyAsync("I did a Lucid! " + lucidMessage);
            return;
        }

        [Command("%")]
        public async Task lucidsAsync(int number)
        {
            List<string> rndLucid = new List<string>();
            rndLucid.Add("https://i.makeagif.com/media/12-14-2015/qXzZVA.gif'");
            rndLucid.Add("https://www.youtube.com/watch?v=_CBLDA86LMQ");
            rndLucid.Add("http://www.gifbin.com/bin/112014/1417109336_guy_falls_off_roof.gif");
            rndLucid.Add("https://www.youtube.com/watch?v=FunoDTsdr2E");
            rndLucid.Add("https://giant.gfycat.com/InfinitePointlessDeviltasmanian.webm  maybe not this time.");
            rndLucid.Add("https://www.youtube.com/watch?v=bvim4rsNHkQ");

            if (number > rndLucid.Count - 1)
            {
                await ReplyAsync("I CANNOT FIND THE RESPONSE FOR " + number.ToString());
                return;
            }
            else
            {
                string lucidMessage = rndLucid[number];
                await ReplyAsync(lucidMessage);
            }
        }
        [Command("help")]
        public async Task helpAsync()
        {
            await ReplyAsync("PANIC");
        }

    }
}
