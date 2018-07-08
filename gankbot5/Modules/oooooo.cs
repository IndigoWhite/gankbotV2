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

            if (selection == "")
            {
                Random rnd = new Random();
                string rndooos = ooos[rnd.Next(0, ooos.Length)];
                string url = "https://static.staticwars.com/quaggans/" + rndooos + ".jpg";
                await ReplyAsync("YOU HAVE REQUESTED A RANDOM QUAGGAN! " + url);
                return;
            }

            for (int i = 0; i < ooos.Length; i++)
            {
                if (selection == ooos[i])
                {
                    string rndooos = ooos[i];
                    string url = "https://static.staticwars.com/quaggans/" + rndooos + ".jpg";
                    await ReplyAsync("YOU HAVE REQUESTED A RANDOM QUAGGAN! " + url);
                    return;
                }

            }

            if (selection != "")
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
