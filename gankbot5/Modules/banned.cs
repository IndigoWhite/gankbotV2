//banned.CS IS A COMMAND FUNCTION
//NOTE : WE DO NOT PERFORM ANY ACTUAL BANNING HERE. ALTHOUGH YOU COULD ADD THAT FEATURE IF YOU WANTED TO.
//!banned "target", BANS THE TARGET WHEN CALLED. IT WILL RESPOND WITH A RANDOM VALUE IN DAYS AND PROVIDE LIFETIME STATS FOR THE
//VICTIM IN THE AMOUNT OF TIMES THEY HAVE BEEN BANNED AND HOW MANY DAYS TOTAL
//A LOT OF THE BASIC COMMAND FUNCTIONS ARE EXPLAINED IN asurans.CS , I WILL TRY TO ONLY EXPLAIN NEW ELEMENTS HERE

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
            //RANDOM DAYS HANDLING, WE'RE JUST CREATE A RANDOM VALUE AND CONVERTING THAT VALUE TO "DAYS"
                Random rnd = new Random();
                float dayss = rnd.Next(1, 2500);
                TimeSpan t = TimeSpan.FromDays(dayss);
                string str = t.ToString(@"dd");
                string output = str + " days";

            //SIMPLE LIST TO PICK A RANDOM RESPONSE FROM
                List<string> rndBanned = new List<string>();
                rndBanned.Add(" https://www.youtube.com/watch?v=9B6bZSpQHxU");
                rndBanned.Add(" https://i.imgur.com/O3DHIA5.gif");

                string bannedMessage = rndBanned[rnd.Next(0, rndBanned.Count)];

            //ARGUMENT HANDLING
            //IF NO NAME IS ENTERED
            if (name == "")
            {
                //THE BOT WILL RESPOND WITH A GENERIC BAN
                string fullMessage = "You have requested a ban... now banning the target for " + output + bannedMessage;
                await ReplyAsync(fullMessage);
                return;
            }

            //IF THE BOT CREATOR IS ENTERED
            if (name == "Indi" || name == "indi")
            {
                //GIT OUT
                await ReplyAsync("NOT THIS TIME BUSTER BROWN");
                return;
            }

            //IF "counts" IS ENTERED. IN FUTURE WE'LL BE LISTING A TABLE OF BAN AMOUNTS AND DAYS BANNED.            
            if (name == "counts")
            {
                await ReplyAsync("BANNED COUNTS WILL BE HERE AT SOMEPOINT IF I FIGURE IT OUT");
                return;
            }

            //COMMAND HELP
            if (name == "help")
            {
                await ReplyAsync("PANIC");
                return;
            }

            //WHEN A TARGET NAME IS ENTERED "!banned someone" 
            else
            {
                //WRITE TO THE XML FILE : THE COMMAND NAME, VICTIM NAME, HOW MANY DAYS AND "1" TO ADD 1 TO THE TIMES COMMAND CALLED
                XMLWrite.BannedXML("banned", name, dayss, 1);
                //READ THE FILE THAT WAS WRITTEN TO
                XMLRead.BannedReadXML(name);
                //SET SOME VARIABLES BASED ON THAT FILE
                int daysAmount = XMLRead.daysRead;
                int bannedAmount = XMLRead.commandAmountRead;

                //SET A STRING BASED ON WHO CALLED THE COMMAND
                string description = Context.User.ToString() + " has requested a ban!";

                //EMBEDBUILDER FUNCTIONS ARE EXPLAINED IN builds.CS 
                //HERE WE'RE FILLING AN EMBED WITH DATA
                EmbedBuilder builder = new EmbedBuilder();
                builder.WithTitle("BAN REQUESTED!").WithDescription(description).WithColor(Color.DarkRed);
                builder.AddInlineField("Target", name).AddInlineField("Ban Amount", output);
                builder.AddInlineField("Lifetime Bans", bannedAmount).AddInlineField("Lifetime Days Banned", daysAmount);

                //REPLY WITH THE RANDOM RESPONSE AND THEN THE EMBED
                await ReplyAsync(bannedMessage);
                await ReplyAsync("", false, builder.Build());                
                return;
            }
            
                
            
        }             
        
    }


}
