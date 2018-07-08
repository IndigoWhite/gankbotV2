using System;
using System.Collections.Generic;
using System.Text;
using Discord.Commands;
using System.Threading.Tasks;
using Discord;

namespace gankbot5.Modules
{
    [Group("builds")]
    public class builds : ModuleBase<SocketCommandContext>
    {
        [Command]
        public async Task buildsAsync()
        {
            EmbedBuilder builder = new EmbedBuilder();
            builder.WithTitle("Looking for some builds?").WithDescription("Here's some useful sites!").WithColor(Color.Purple);
            builder.AddInlineField("General Builds", "https://www.metabattle.com")
                .AddInlineField("Open World", "https://metabattle.com/wiki/Open_World");
            builder.AddInlineField("Raids/Fractals", "https://snowcrows.com/")
                .AddInlineField("PvP", "       https://www.godsofpvp.net/");

            await ReplyAsync("", false, builder.Build());
        }
    }
}
