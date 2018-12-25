using Discord;
using Discord.Commands;
using System.Threading.Tasks;

namespace SplimoBot.Modules
{
    public class Test : ModuleBase<SocketCommandContext>
    {
        [Command("test")]
        public async Task one(IRole role)
        {
            await Context.Channel.SendMessageAsync("Kilian ist " + role.ToString());
        }
        [Command("lol")]
        public async Task two(IGuildUser user)
        {
            await Context.Channel.SendMessageAsync("Kilian ist " + user.ToString());
        }
        [Command("rofl")]
        public async Task three(string repeat)
        {
            await Context.Channel.SendMessageAsync("Kilian ist " + repeat.ToString());
        }
    }
}
