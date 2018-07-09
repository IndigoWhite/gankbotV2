//john.CS IS MOSTLY LIKE OTHER RANDOM RESPONSE COMMANDS, THIS COMMAND WAS USED TO PERFORM SOME BASIC XML TESTING
//I HAVE YET TO DECIDE TO ADD THE FUNCTION TO ALL COMMANDS. FOR NOW IT REMAINS.

using System;
using System.Collections.Generic;
using System.Text;
using Discord.Commands;
using System.Threading.Tasks;
using Discord;

namespace gankbot5.Modules
{
    [Group("john")]
    public class john : ModuleBase<SocketCommandContext>
    {
        private int clickAmount = 1;
        private string commandName = "john";

        [Command]
        public async Task johnAsync()
        {
            List<string> rndJohn = new List<string>();
            rndJohn.Add("Here is a recent picture of @Rolfokvar - http://i.imgur.com/kfWjfcq.png");
            rndJohn.Add("John has a unique view on Ascended Chest drops - http://i.imgur.com/1B3RAkp.png");
            rndJohn.Add("Johns favourite song is - https://www.youtube.com/watch?v=5NV6Rdv1a3I&feature=youtu.be");

            Random rnd = new Random();

            string johnMessage = rndJohn[rnd.Next(0, rndJohn.Count)];
            XMLWrite.ReadThenWrite(commandName, clickAmount);
            XMLRead.ReadXML(commandName);
            int newAmount = XMLRead.commandAmountRead;
            await ReplyAsync(johnMessage + " This command has been called " + newAmount + " times.");
            return;
        }
        [Command("%")]
        public async Task johnsAsync(int number)
        {
            List<string> rndJohn = new List<string>();
            rndJohn.Add("Here is a recent picture of @Rolfokvar - http://i.imgur.com/kfWjfcq.png");
            rndJohn.Add("John has a unique view on Ascended Chest drops - http://i.imgur.com/1B3RAkp.png");
            rndJohn.Add("Johns favourite song is - https://www.youtube.com/watch?v=5NV6Rdv1a3I&feature=youtu.be");

            if (number > rndJohn.Count - 1)
            {
                await ReplyAsync("I CANNOT FIND THE RESPONSE FOR " + number.ToString());
                return;
            }
            else
            {
                string johnMessage = rndJohn[number];
                await ReplyAsync(johnMessage);
            }
        }
        [Command("help")]
        public async Task helpAsync()
        {
            await ReplyAsync("PANIC");
        }

    }
}
