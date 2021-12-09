using System.IO;
using System.Threading.Tasks;
using Discord;
using Discord.Net;
using Discord.Commands;
using Bot0;
using Discord.Net.WebSockets;
using Discord.Addons.Interactive;
using Discord.WebSocket;
namespace bot0.Modules
{
    public class Play : ModuleBase<SocketCommandContext>
    {
        [Command("play")]
        [Alias("здфн")]
        public async Task Start_of_game(SocketGuildUser player1)
        {
            var builder = new EmbedBuilder()
            {
                Color = Color.LightOrange,
                Description = $"Id - ***{player1.Id}***\n" +
                $"Возраст аккаунта: {(Context.Message.Timestamp.DateTime - player1.CreatedAt.DateTime).Days} д\n" +
                $"Имя - ***{player1.Username}#{player1.Discriminator}({((player1.Nickname != null) ? player1.Nickname : player1.Username)})***\n"
            };
            builder.ThumbnailUrl = player1.GetAvatarUrl();
            await ReplyAsync("", false, builder.Build());
            builder = new EmbedBuilder()
            {
                Color = Color.LightOrange,
                Description = $"Id - ***{Context.User.Id}***\n" +
                $"Возраст аккаунта: {(Context.Message.Timestamp.DateTime - Context.User.CreatedAt.DateTime).Days} д\n" +
                $"Имя - ***{Context.User.Username}#{Context.User.Discriminator}({((Context.User.Username != null) ? Context.User.Username : Context.User.Username)})***\n"
            };
            builder.ThumbnailUrl = Context.User.GetAvatarUrl();
            await ReplyAsync("", false, builder.Build());
            ICategoryChannel category = await Context.Guild.CreateCategoryChannelAsync("Игровая комната");
            IMessageChannel channel1 = await category.Guild.CreateTextChannelAsync($"Чат {player1.Username}", x => x.CategoryId = category.Id);
            IMessageChannel channel2 = await category.Guild.CreateTextChannelAsync($"Чат {Context.User.Username}", x => x.CategoryId = category.Id);
            IVoiceChannel channel3 = await category.Guild.CreateVoiceChannelAsync("Обсуждение", x => x.CategoryId = category.Id);
            var builder1 = new EmbedBuilder()
            {
                Color = Color.Red,
                Description = $"***Вот и начало игры***\n" +
                $"Вам выпадет что-то из 🪨 / ✂️ / 🗞️\n"
            };
            await channel1.SendMessageAsync("", false, builder1.Build());
            await channel2.SendMessageAsync("", false, builder1.Build());
            await Task.Delay(1000);
            await channel1.SendMessageAsync("3️⃣", false);
            await channel2.SendMessageAsync("3️⃣", false);
            await Task.Delay(1000);
            await channel1.SendMessageAsync("2️⃣", false);
            await channel2.SendMessageAsync("2️⃣", false);
            await Task.Delay(1000);
            await channel1.SendMessageAsync("1️⃣", false);
            await channel2.SendMessageAsync("1️⃣", false);
            await Task.Delay(1000);
            await channel1.SendMessageAsync("0️⃣", false);
            await channel2.SendMessageAsync("0️⃣", false);
            await Task.Delay(1000);
            Random rnd = new Random();
            int value1 = rnd.Next(0, 3);
            int value2 = rnd.Next(0, 3);
            string number_of_triumphator = Context.User.Username;
            string[] choices = { "✂️", "🗞️", "🪨" };
            await channel1.SendMessageAsync($"ваш выбор - {choices[value1]}", false);
            await channel2.SendMessageAsync($"ваш выбор - {choices[value2]}", false);
            if (value1 == 0)
            {
                if (value2 == 1)
                    number_of_triumphator = Context.User.Username;
                else
                    number_of_triumphator = player1.Username;
            }
            else if (value1 == 1)
            {
                if (value2 == 2)
                    number_of_triumphator = Context.User.Username;
                else
                    number_of_triumphator = player1.Username;
            }
            else if (value1 == 2)
            {
                if (value2 == 0)
                    number_of_triumphator = Context.User.Username;
                else
                    number_of_triumphator = player1.Username;
            }
            builder = new EmbedBuilder()
            {
                Color = Color.Red,
                Description = $"{choices[value1]} против {choices[value2]}\n" +
                $"Победил игрок {number_of_triumphator}"
            };
            if (value1 == value2)
            {
                builder = new EmbedBuilder()
                {
                    Color = Color.Red,
                    Description = $"{choices[value1]} против {choices[value2]}\n" +
                $"Ничья"
                };
            }
            await Task.Delay(1000);
            await ReplyAsync("", false, builder.Build());
            await Task.Delay(3000);
            await category.DeleteAsync();
        }
        [Command("help")]
        [Alias("хелп")]
        public async Task Help()
        {
            var builder = new EmbedBuilder()
            {
                Color = Color.LightOrange,
                Title = "RPS бот",
                Description = $"***!play*** - старт сессии\n" +
                $"***!scores*** - таблица лидеров в гильдии"
            };
            await ReplyAsync("", false, builder.Build());
        }
        [Command("scores")]
        [Alias("результаты")]
        public async Task Scores()
        {
            await Context.Channel.SendMessageAsync("команда ещё не готова");
        }
    }
}
