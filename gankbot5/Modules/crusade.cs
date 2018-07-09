//crusade.CS IS ANOTHER COMMAND FUNCTION THAT PERFORMS A SIMPLE MATH CHECK TO SEE HOW MANY DAYS ARE BETWEEN A DEFINED DATE
//AND THE CURRENT DATE

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
            //SET today TO TODAY
            DateTime today = DateTime.Today;
            //DEFINE A 2ND DATE TO COMPARE TO
            DateTime crusadeStart = new DateTime(2015, 10 , 23);
            //PERFORM THE MATH
            int dayz = (today - crusadeStart).Days;            

            //SET THE INITIAL RESPONSE STRING
            string daysMsg = ("Aly's dagger crusade has lasted for " + dayz + " days.");

            //RESPOND BASED ON THE AMOUNT OF DAYS
              if (dayz < 1000)
              {
                await ReplyAsync(daysMsg + " Here's her last playing GW2 - https://youtu.be/yDyjz5bLSEU?t=30s");
                  return;
              }
              if (dayz > 1000)
              {
                await ReplyAsync("HOLY SHIT IT'S OVER 1000 DAYS, WTF ALY JUST PLAY SOMETHING ELSE... THIS BOT WILL NOW SELF DESTRUCT  *note if I coded this correctly the bot will disconnect when you see this*");
                //I BELIEVE THIS SHOULD LOGOUT THE BOT, BUT IT'S YET UNTESTED... IN 10 DAYS IT SHOULD WORK THOUGH.
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
