// PROGRAM.CS IS THE MAIN THREAD OF THE BOT, WE LOGIN AND WAIT FOR COMMANDS HERE.

using System;
using System.Threading.Tasks;
using Discord;
using Discord.WebSocket;
using Discord.Commands;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace gankbot5
{
    class Program
    {
        //SETUP A COUPLE OF VARIABLES
        private string token = "INSERTBOTTOKENIDHERE";
        private string msgPrefix = "!";

        //SETTING UP THE MAIN THREAD
        public static void Main(string[] args) => new Program().MainAsync().GetAwaiter().GetResult();

        
        private DiscordSocketClient _client;
        private CommandService _commands;
        private IServiceProvider _services;        

        public async Task MainAsync()
        {
            //DEFINING CLIENT, COMMANDS AND SERVICE REFERENCES
            _client = new DiscordSocketClient();
            _commands = new CommandService();
            _services = new ServiceCollection().AddSingleton(_client).AddSingleton(_commands).BuildServiceProvider();

            //LOGGING
            _client.Log += Log;
            //REGISTER EVENT FOR WHEN A USER JOINS A DISCORD CHANNEL
            _client.UserJoined += AnnounceUserJoined;

            //REGISTER THE COMMANDS
            await RegisterCommandsAsync();

            //LOG THE BOT IN
            await _client.LoginAsync(TokenType.Bot, token);
            await _client.StartAsync();

            //STOP THE TASK FROM COMPLETING, WE DO THIS SO THE BOT IS ALWAYS ON.
            await Task.Delay(-1);
        }

        //USER JOINING CHANNEL FUNCTION, SENDS A MESSAGE OUT WELCOMING THEM TO THE CHANNEL
        private async Task AnnounceUserJoined(SocketGuildUser user)
        {
            var guild = user.Guild;
            var channel = guild.DefaultChannel;
            await channel.SendMessageAsync($"Welcome, {user.Mention}");
        }

        //REGISTERING COMMANDS FUNCTION
        public async Task RegisterCommandsAsync()
        {
            //WHEN A MESSAGE IS RECIEVED CHECK IF IT'S A COMMAND
            _client.MessageReceived += HandleCommandAsync;
            await _commands.AddModulesAsync(Assembly.GetEntryAssembly());
        }

        //COMMAND HANDLING
        private async Task HandleCommandAsync(SocketMessage arg)
        {
            
            var message = arg as SocketUserMessage;
            //WE DON'T NEED TO HANDLE EMPTY MESSAGES OR THE BOTS OWN MESSAGES
            if (message is null || message.Author.IsBot) return;

            //SET A POSITION FOR WHERE THE PREFIX SHOULD BE.
            int argPosition = 0;
            
            //IF THE MESSAGE HAS THE PREFIX IN THE CORRECT POSITION
            if (message.HasStringPrefix(msgPrefix, ref argPosition) || message.HasMentionPrefix(_client.CurrentUser, ref argPosition))
            {
                //EXECUTE THE COMMAND
                var context = new SocketCommandContext(_client, message);
                var result = await _commands.ExecuteAsync(context, argPosition, _services);

                //ERROR CATCHING AND CONSOLE LOGGING OF THE ERROR
                if (!result.IsSuccess)
                {
                    Console.WriteLine(result.ErrorReason);
                }

            }
        }

        //LOGGING FUNCTION
        private Task Log(LogMessage msg)
        {
            Console.WriteLine(msg.ToString());
            return Task.CompletedTask;
        }

        
    }
}
