using System;
using System.Collections.Generic;
using System.Text;
using Discord.Commands;
using System.Threading.Tasks;
using Discord;

namespace gankbot5.Modules
{
    [Group("choya")]
    public class choya : ModuleBase<SocketCommandContext>
    {
        [Command]
        public async Task choyaAsync()
        {
            EmbedBuilder builder = new EmbedBuilder();
            builder.WithTitle("WIP").WithDescription("What the fuck is this?").WithColor(Color.Purple);
            builder.AddField("Well....", "This was created originally with the idea Aly would be providing responses at somepoint... none have appeared yet.");

            await ReplyAsync("", false, builder.Build());
        }

        [Command("help")]
        public async Task helpAsync()
        {
            await ReplyAsync("PANIC");
        }

    }
}
