//asurans.CS IS A COMMAND SCRIPT.
//IT TAKES IN A COMMAND FROM A USER AND REPLYS WITH A RANDOM RESPONSE BASED ON A LIST OF RESPONSES.
//OTHER SIMILAR SCRIPTS INCLUDE cunt, john, lucid, myon, oooooo, praisejoko, rugi, thegreatergood and who.

using System;
using System.Collections.Generic;
using System.Text;
using Discord.Commands;
using System.Threading.Tasks;
using Discord;

namespace gankbot5.Modules
{
    [Group("midgets")] //THE GROUP DEFINES THE COMMAND NAME, IN THIS CASE THE BOT RESPONDS TO "!midgets"
    public class asurans : ModuleBase<SocketCommandContext> //DEFINE AS A TYPE OF MODULEBASE SO THE MAIN FUNCTION CAN COMMAND HANDLE
    {        
        [Command] //IF THE USER JUST TYPES "!midgets" WITH NO ARGUMENTS
        public async Task midgetsAsync()
        {
            //CREATE A LIST OF STRING RESPONSES            
            List<string> rndMidgets = new List<string>();
            rndMidgets.Add("The Asuran Race are just somewhat intelligent bobbleheads.");
            rndMidgets.Add("Asurans make great doorstops.");
            rndMidgets.Add("I dislike Asurans. I also dislike Moas.");
            rndMidgets.Add("Asurans are officially the worst midget race in Tyria - https://goo.gl/4Ag3vE");

            //SETUP A RANDOM FUNCTION
            Random rnd = new Random();
            
            //SETUP THE RESPONSE STRING TO BE A RANDOM STRING FROM THE LIST CREATED ABOVE
            string midgetMessage = rndMidgets[rnd.Next(0, rndMidgets.Count)];

            //REPLY TO THE COMMAND IN DISCORD
            await ReplyAsync(midgetMessage);
            return;            
        }

        //HERE WE'RE LISTENING FOR THE "%" ARGUEMENT. A USER CAN TYPE IN A NUMBER AFTER % AND GET A SPECIFIC RESPONSE
        //FOR EXAMPLE "!midgets % 1" WILL HAVE THE BOT RESPOND "Asurans make great doorstops."
        [Command ("%")]
        public async Task midgetsAsync(int number)
        {
            List<string> rndMidgets = new List<string>();
            rndMidgets.Add("The Asuran Race are just somewhat intelligent bobbleheads.");
            rndMidgets.Add("Asurans make great doorstops.");
            rndMidgets.Add("I dislike Asurans. I also dislike Moas.");
            rndMidgets.Add("Asurans are officially the worst midget race in Tyria - https://goo.gl/4Ag3vE");

            //IF THE NUMBER PROVIDED ISN'T AVAILABLE
            if (number > rndMidgets.Count-1)
            {
                //LET THE USER KNOW WE CAN'T PERFROM THE COMMAND
                await ReplyAsync("I CANNOT FIND THE RESPONSE FOR " + number.ToString());
                return;
            }
            else //IF THE NUMBER IS AVAILABLE
            {
                //RESPONSE WITH THE SELECTED RESPONSE
                string midgetMessage = rndMidgets[number];
                await ReplyAsync(midgetMessage);
            }
        }

        //HELP IS A COMMAND SPECIFIC HELP FUNCTION. IF THE USER TYPES IN "!midgets help" WE CAN PROVIDE COMMAND SPECIFIC
        //INFORMATION HERE.
        [Command ("help")]
        public async Task helpAsync()
        {
            //THIS NEEDS ACTUAL INFORMATION, FOR NOW WE JUST RESPOND IN A SILLY MANNER
            await ReplyAsync("PANIC");
        }

    }
}
