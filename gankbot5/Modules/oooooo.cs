//oooooo.CS IS SIMILAR TO OTHER RANDOM RESPONSE SCRIPTS. HOWEVER THE LIST OF RESPONSES HERE ARE A DEFINED ARRAY OF STRINGS.
//WITH THAT IN MIND, THE BOT HANDLES SPECIFIC RESPONSE CALLS DIFFERENTLY

using System;
using System.Collections.Generic;
using System.Text;
using Discord.Commands;
using System.Threading.Tasks;
using Discord;

namespace gankbot5.Modules
{
    [Group("oooooo")]
    public class oooooo : ModuleBase<SocketCommandContext>
    {
        //PREDEFINE THE ARRAY
        private string[] ooos = { "404", "aloha", "attack", "bear", "bowl",
                                    "box", "breakfast", "bubble", "cake",
                                    "cheer", "coffee", "construction", "cow",
                                    "cry", "elf", "ghost", "girl", "hat", "helmut",
                                    "hoodie-down", "hoodie-up", "killerwhale",
                                    "knight", "lollipop", "lost", "moving",
                                    "party", "present", "quaggan", "rain", "scifi",
                                    "seahawks", "sleep", "summer", "vacation" };
                

        [Command]
        public async Task oooAsync(string selection = "")
        {

            if (selection == "") //IF NO SPECIFIC QUAGGAN REQUESTED, SELECT A RANDOM ONE
            {
                Random rnd = new Random();
                string rndooos = ooos[rnd.Next(0, ooos.Length)];
                string url = "https://static.staticwars.com/quaggans/" + rndooos + ".jpg";
                await ReplyAsync("YOU HAVE REQUESTED A RANDOM QUAGGAN! " + url);
                return;
            }

            for (int i = 0; i < ooos.Length; i++) //ITERATE THROUGH THE QUAGGAN ARRAY
            {
                if (selection == ooos[i]) // IF THE QUAGGAN MATCHES A VALUE IN THE ARRAY, RESPOND WITH THAT QUAGGAN
                {
                    string rndooos = ooos[i];
                    string url = "https://static.staticwars.com/quaggans/" + rndooos + ".jpg";
                    await ReplyAsync("YOU HAVE REQUESTED A SPECIFIC QUAGGAN! " + url);
                    return;
                }

            }

            if (selection != "") //IF A SPECFIC QUAGGAN WAS REQUESTED BUT THE BOT CAN'T FIND IT
                {
                await ReplyAsync("I CANNOT FIND THE REQUESTED QUAGGAN " + selection);
                return;
            }

        }

        [Command("help")]
        public async Task helpAsync()
        {
            await ReplyAsync("PANIC");
        }

    }
}
