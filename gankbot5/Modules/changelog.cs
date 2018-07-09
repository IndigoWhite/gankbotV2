using System;
using System.Collections.Generic;
using System.Text;
using Discord.Commands;
using System.Threading.Tasks;
using Discord;

namespace gankbot5.Modules
{
    [Group("changelog")]
    public class changelog : ModuleBase<SocketCommandContext>
    {
        [Command]
        public async Task buildsAsync()
        {
            EmbedBuilder builder = new EmbedBuilder();
            builder.WithTitle("Changelog").WithDescription("What the fuck is different?").WithColor(Color.Purple);
            builder.AddField("09 JULY 2018", "Porting complete");
            builder.AddField("08 JULY 2018", "Ported GankBot v1 from Node.JS to C#, now known as GankBot v2... I ain't done yet.");

            await ReplyAsync("", false, builder.Build());
        }

        [Command("help")]
        public async Task helpAsync()
        {
            await ReplyAsync("PANIC");
        }
    }
}
