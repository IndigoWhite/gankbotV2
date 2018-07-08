using System;
using System.Collections.Generic;
using System.Text;
using Discord.Commands;
using System.Threading.Tasks;
using Discord;

namespace gankbot5.Modules
{
    [Group("cunt")]
    public class cunt : ModuleBase<SocketCommandContext>
    { 

        [Command]
        public async Task cuntAsync()
        {
            List<string> rndCunts = new List<string>();
            rndCunts.Add("Say that again you cunt");
            rndCunts.Add("uwotm8?");
            rndCunts.Add("How unsavoury of you.");
            rndCunts.Add("CONGRATULATIONS YOU ARE THE 1,000,000TH PERSON TO ENTER THAT COMMAND! CLICK HERE TO CLAIM YOUR FREE IPOD! <https://goo.gl/SsAhv>");
            rndCunts.Add("Did you know Indi only uses this command to make sure I am on. #gankbotv2facts");
            rndCunts.Add("I am currently finding a new AFK spot, I will be back with an insult in 5 minutes");
            rndCunts.Add("I wish people would stop provoking me.");
            rndCunts.Add("Are you looking for my mate Kev? https://www.youtube.com/watch?v=yuwprXAaSv0");
            rndCunts.Add("Such a word has a fantastic history! Would you like to know more? https://www.youtube.com/watch?v=3GAbStTKFIw");
            rndCunts.Add("Dont make me go all cockney on your ass! https://www.youtube.com/watch?v=juIvwwPlCus");
            rndCunts.Add("Its just a game to you - https://www.youtube.com/watch?v=Z-IYk7YVW80");
            rndCunts.Add("My favourite TV show is Game Of Cunts - https://www.youtube.com/watch?v=jvK0rahXZgw");
            rndCunts.Add("Need help pronouncing that word? - https://www.youtube.com/watch?v=bs8Yjh45rhs");

            Random rnd = new Random();

            string cuntMessage = rndCunts[rnd.Next(0, rndCunts.Count)];
            await ReplyAsync(cuntMessage);
            return;

        }

        [Command("%")]
        public async Task cuntsAsync(int number)
        {
            List<string> rndCunts = new List<string>();
            rndCunts.Add("Say that again you cunt");
            rndCunts.Add("uwotm8?");
            rndCunts.Add("How unsavoury of you.");
            rndCunts.Add("CONGRATULATIONS YOU ARE THE 1,000,000TH PERSON TO ENTER THAT COMMAND! CLICK HERE TO CLAIM YOUR FREE IPOD! <https://goo.gl/SsAhv>");
            rndCunts.Add("Did you know Indi only uses this command to make sure I am on. #gankbotv2facts");
            rndCunts.Add("I am currently finding a new AFK spot, I will be back with an insult in 5 minutes");
            rndCunts.Add("I wish people would stop provoking me.");
            rndCunts.Add("Are you looking for my mate Kev? https://www.youtube.com/watch?v=yuwprXAaSv0");
            rndCunts.Add("Such a word has a fantastic history! Would you like to know more? https://www.youtube.com/watch?v=3GAbStTKFIw");
            rndCunts.Add("Dont make me go all cockney on your ass! https://www.youtube.com/watch?v=juIvwwPlCus");
            rndCunts.Add("Its just a game to you - https://www.youtube.com/watch?v=Z-IYk7YVW80");
            rndCunts.Add("My favourite TV show is Game Of Cunts - https://www.youtube.com/watch?v=jvK0rahXZgw");
            rndCunts.Add("Need help pronouncing that word? - https://www.youtube.com/watch?v=bs8Yjh45rhs");

            if (number > rndCunts.Count - 1)
            {
                await ReplyAsync("I CANNOT FIND THE RESPONSE FOR " + number.ToString());
                return;
            }
            else
            {
                string cuntsMessage = rndCunts[number];
                await ReplyAsync(cuntsMessage);
                return;
            }
        }

        [Command("backend"), RequireOwner]
        public async Task backendAsync()
        {
            await ReplyAsync("THE CREATOR CALLS!");
        }

        

        [Command("help")]
        public async Task helpAsync()
        {
            await ReplyAsync("PANIC");
        }
    }
}
