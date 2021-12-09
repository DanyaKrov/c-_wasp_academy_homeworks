using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;
using Discord.WebSocket;

namespace bot0.Modules
{
    public class hw4: ModuleBase<SocketCommandContext>
    {
        [Command("info")]
        public async Task Info() => await ReplyAsync($"👑 Создатель бота: <@{535822867045285939}>\n#️⃣ Канал: <#{Context.Channel.Id}>\n⚾ Команду вызвал: {Context.User.Mention}", false, null, null, null, new MessageReference(Context.Message.Id));
       
    }
}
