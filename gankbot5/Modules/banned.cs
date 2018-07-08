using System;
using System.Collections.Generic;
using System.Text;
using Discord.Commands;
using System.Threading.Tasks;
using Discord;

namespace gankbot5.Modules
{
    [Group("banned")]
    public class banned : ModuleBase<SocketCommandContext>
    {
        [Command]
        public async Task bannedAsync(string name = "")
        {
            
                Random rnd = new Random();
                float dayss = rnd.Next(1, 2500);
                TimeSpan t = TimeSpan.FromDays(dayss);
                string str = t.ToString(@"dd");
                string output = str + " days";

                List<string> rndBanned = new List<string>();
                rndBanned.Add(" https://www.youtube.com/watch?v=9B6bZSpQHxU");
                rndBanned.Add(" https://i.imgur.com/O3DHIA5.gif");


                string bannedMessage = rndBanned[rnd.Next(0, rndBanned.Count)];
            if (name == "")
            {
                string fullMessage = "You have requested a ban... now banning the target for " + output + bannedMessage;
                await ReplyAsync(fullMessage);
                return;
            }

            if (name == "Indi" || name == "indi")
            {
                await ReplyAsync("NOT THIS TIME BUSTER BROWN");
                return;
            }

            if (name == "counts")
            {
                await ReplyAsync("BANNED COUNTS WILL BE HERE AT SOMEPOINT IF I FIGURE IT OUT");
                return;
            }

            if (name == "help")
            {
                await ReplyAsync("PANIC");
                return;
            }

            else
            {
                XMLWrite.BannedXML("banned", name, dayss, 1);
                XMLRead.BannedReadXML(name);
                int daysAmount = XMLRead.daysRead;
                int bannedAmount = XMLRead.commandAmountRead;
                string description = Context.User.ToString() + " has requested a ban!";

                EmbedBuilder builder = new EmbedBuilder();
                builder.WithTitle("BAN REQUESTED!").WithDescription(description).WithColor(Color.DarkRed);
                builder.AddInlineField("Target", name).AddInlineField("Ban Amount", output);
                builder.AddInlineField("Lifetime Bans", bannedAmount).AddInlineField("Lifetime Days Banned", daysAmount);

                await ReplyAsync(bannedMessage);
                await ReplyAsync("", false, builder.Build());                
                return;
            }
            
                
            
        }             
        
    }


}
