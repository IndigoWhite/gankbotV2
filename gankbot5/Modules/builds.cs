//builds.CS IS A COMMAND SCRIPT
//HERE WE USE EMBED BUILDER TO FORMAT THE REPLY IN A NICER WAY

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
            //DEFINE A NEW BUILDER
            EmbedBuilder builder = new EmbedBuilder();

            //SETUP THE EMBED TITLE, IT'S DESCRIPTION AND THE COLOUR OF THE BAR TO THE LEFT OF THE EMBED
            builder.WithTitle("Looking for some builds?").WithDescription("Here's some useful sites!").WithColor(Color.Purple);
            //WE ADD A ROW OF INFORMATION, INLINE KEEPS INFORMATION ALIGNED
            builder.AddInlineField("General Builds", "https://www.metabattle.com")
                .AddInlineField("Open World", "https://metabattle.com/wiki/Open_World");
            //AND ANOTHER ROW
            builder.AddInlineField("Raids/Fractals", "https://snowcrows.com/")
                .AddInlineField("PvP", "       https://www.godsofpvp.net/");

            //REPLY WITH THE COMPLETED EMBED BUILT
            await ReplyAsync("", false, builder.Build());
        }
    }
}
