using System;
using System.Collections.Generic;
using System.Text;
using Discord.Commands;
using System.Threading.Tasks;
using Discord;

namespace gankbot5.Modules
{
    [Group("legendary")]
    public class legendary : ModuleBase<SocketCommandContext>
    {
        [Command]
        public async Task legendaryAsync()
        {
            EmbedBuilder builder = new EmbedBuilder();
            builder.WithTitle("LEGENDARIES").WithDescription("Check out the google doc of Legendaries created within Gank").WithColor(Color.Purple);
            builder.AddField("If you've added one let us know :)", "https://docs.google.com/spreadsheets/d/1jZvt1_WbNoFifOEcCQQlfCBbWE4sFV6IJz-oyK4EdRk/edit#gid=0");

            await ReplyAsync("", false, builder.Build());
        }

        [Command("help")]
        public async Task helpAsync()
        {
            await ReplyAsync("PANIC");
        }


    }
}
