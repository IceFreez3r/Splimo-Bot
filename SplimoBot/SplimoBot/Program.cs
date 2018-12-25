using System;
using Discord;
using Discord.WebSocket;
using System.Threading.Tasks;

namespace SplimoBot
{
    public class Program
    {
        static void Main(string[] args)
        => new Program().StartAsync().GetAwaiter().GetResult();

        private DiscordSocketClient _client;
        private CommandHandler _handler;

        public async Task StartAsync()
        {
            _client = new DiscordSocketClient();
            await _client.LoginAsync(TokenType.Bot, "NTIzODIzNTY2MTY5NTcxMzM4.DwOOUw.vCMyfbTOvyAqjlc3LTFIxhQy6nY");
            await _client.StartAsync();
            _handler = new CommandHandler(_client);
            await Task.Delay(-1);
        }
    }
}
