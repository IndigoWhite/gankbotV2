using System;
using System.Collections.Generic;
using System.Text;
using Discord.Commands;
using System.Threading.Tasks;
using Discord;

namespace gankbot5.Modules
{
    [Group("tybalt")]
    public class tybalt : ModuleBase<SocketCommandContext>
    {
        [Command]
        public async Task tybaltAsync()
        {
            
        EmbedBuilder builder = new EmbedBuilder();
            builder.WithTitle("FRESH GENDARRAN APPLES HERE!").WithDescription("Welcome Initiate, it seems you are new here or you have request information that would help a fellow player. Here is our current docket of information.").WithColor(Color.DarkRed);
            builder.AddField("Bots", "This discord has a few bots, all are available to use by anyone here. If you think you are going to spam a lot of commands please use the #botstuff channel.");
            builder.AddInlineField("GankBotv2", "! prefix. GankBotv2 was built by Indi to help in Gank shenanigans here on Discord. This information is served to you by GankBotv2! Type !help for more information on GankBot.")
                   .AddInlineField("GW2Bot", "$ prefix. GW2Bot has many commands specifically used for Guild Wars 2 information. Type $help for more information")
                   .AddInlineField("Go4LiftOffBot", ". prefix. The Go4Liftoff bots primary use is to automatically list upcoming space launches. Type .help for more information. ");

            await ReplyAsync("", false, builder.Build());
        }

        [Command("help")]
        public async Task helpAsync()
        {
            await ReplyAsync("PANIC");
        }

    }
}
