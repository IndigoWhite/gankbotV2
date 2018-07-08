using System;
using System.Collections.Generic;
using System.Text;
using Discord.Commands;
using System.Threading.Tasks;
using Discord;

namespace gankbot5.Modules
{
    [Group("thegreatergood")]
    public class thegreatergood : ModuleBase<SocketCommandContext>
    {         
        [Command]
        public async Task grtgudAsync()
        {
            List<string> rndgrtgud = new List<string>();
            rndgrtgud.Add("The greater good... https://www.youtube.com/watch?v=yUpbOliTHJY");
            rndgrtgud.Add("Fuck off up the model village... https://www.youtube.com/watch?v=HWgYVeCqJ-8");
            rndgrtgud.Add("Ayespose... https://www.youtube.com/watch?v=Cun-LZvOTdw");
            rndgrtgud.Add("Morning. https://www.youtube.com/watch?v=Tp05YYQtggU");

            Random rnd = new Random();

            string grtgudMessage = rndgrtgud[rnd.Next(0, rndgrtgud.Count)];
            await ReplyAsync(grtgudMessage);
            return;
        }

        [Command("%")]
        public async Task grtgudsAsync(int number)
        {
            List<string> rndgrtgud = new List<string>();
            rndgrtgud.Add("The greater good... https://www.youtube.com/watch?v=yUpbOliTHJY");
            rndgrtgud.Add("Fuck off up the model village... https://www.youtube.com/watch?v=HWgYVeCqJ-8");
            rndgrtgud.Add("Ayespose... https://www.youtube.com/watch?v=Cun-LZvOTdw");
            rndgrtgud.Add("Morning. https://www.youtube.com/watch?v=Tp05YYQtggU");

            if (number > rndgrtgud.Count - 1)
            {
                await ReplyAsync("I CANNOT FIND THE RESPONSE FOR " + number.ToString());
                return;
            }
            else
            {
                string grtgudMessage = rndgrtgud[number];
                await ReplyAsync(grtgudMessage);
            }
        }
        [Command("help")]
        public async Task helpAsync()
        {
            await ReplyAsync("PANIC");
        }

    }
}
