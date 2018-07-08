using System;
using System.Collections.Generic;
using System.Text;
using Discord.Commands;
using System.Threading.Tasks;
using Discord;

namespace gankbot5.Modules
{
    [Group("crusade")]
    public class crusade : ModuleBase<SocketCommandContext>
    {
        [Command]
        public async Task crusadeAsync()
        {
            DateTime today = DateTime.Today;
            DateTime crusadeStart = new DateTime(2015, 10 , 23);
            int dayz = (today - crusadeStart).Days;            

            
            string daysMsg = ("Aly's dagger crusade has lasted for " + dayz + " days.");

              if (dayz < 1000)
              {
                await ReplyAsync(daysMsg + " Here's her last playing GW2 - https://youtu.be/yDyjz5bLSEU?t=30s");
                  return;
              }
              if (dayz > 1000)
              {
                await ReplyAsync("HOLY SHIT IT'S OVER 1000 DAYS, WTF ALY JUST PLAY SOMETHING ELSE... THIS BOT WILL NOW SELF DESTRUCT  *note if I coded this correctly the bot will disconnect when you see this*");
                await Context.Client.LogoutAsync();
            } 
        }

        [Command("help")]
        public async Task helpAsync()
        {
            await ReplyAsync("PANIC");
        }

    }
}
