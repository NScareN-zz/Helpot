using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;

namespace Helpot.Modules
{
    public class MyInfo : ModuleBase<SocketCommandContext>
    {
        [Command("myinfo")]
        public async Task Myinfo()
        {
            var embed = new EmbedBuilder();
            embed.WithTitle("Информация об аккаунте " + Context.User.Username);
            embed.WithDescription("Имя аккаунта : " + Context.User.Username +
                "\nId Аккаунта : " + Context.User.Id +
                "\nДопольнительная информация : Пуша пидор");
            embed.WithColor(new Color(0, 255, 0));

            await Context.Channel.SendMessageAsync("", false, embed);
        }
    }
}
