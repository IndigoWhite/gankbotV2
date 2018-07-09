using System;
using System.Collections.Generic;
using System.Text;
using Discord.Commands;
using System.Threading.Tasks;
using Discord;

namespace gankbot5.Modules
{
    [Group("germans")]
    public class germans : ModuleBase<SocketCommandContext>
    {
        [Command]
        public async Task germanAsync()
        {
            EmbedBuilder builder = new EmbedBuilder();
            builder.WithTitle("THE GERMANS?").WithDescription("How about a simple table of the Germans in Gank?").WithColor(Color.DarkOrange);
            builder.AddField("Well you are in luck!", "https://goo.gl/qoAqcA");

            await ReplyAsync("", false, builder.Build());
        }

        [Command("help")]
        public async Task helpAsync()
        {
            await ReplyAsync("PANIC");
        }


    }
}
