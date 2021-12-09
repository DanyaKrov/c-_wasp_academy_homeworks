using System.IO;
using System.Threading.Tasks;
using Discord;
using Discord.Net;
using Discord.Commands;
using Bot0;
using Discord.Net.WebSockets;
using Discord.WebSocket;

namespace Bot0.Modules
{
    // Modules must be public and inherit from an IModuleBase
    public class PublicModule : ModuleBase<SocketCommandContext>
    {
        [Command("plus")]
        public async Task Plus(string num1, string num2)
        {
            if (int.TryParse(num1, out int number1) && int.TryParse(num2, out int number2))
                await Context.Channel.SendMessageAsync($"{num1} + {num2} = {number1 + number2}");
            else
                await Context.Channel.SendMessageAsync("Вы ввели строки, вместо чисел");

        }
        [Command("minus")]
        public async Task minus(string num1, string num2)
        {
            if (int.TryParse(num1, out int number1) && int.TryParse(num2, out int number2))
                await Context.Channel.SendMessageAsync($"{num1} - {num2} = {number1 - number2}");
            else
                await Context.Channel.SendMessageAsync("Вы ввели строки, вместо чисел");

        }
        [Command("divide")]
        public async Task divide(string num1, string num2)
        {
            if (int.TryParse(num1, out int number1) && int.TryParse(num2, out int number2))
                await Context.Channel.SendMessageAsync($"{num1} / {num2} = {number1 / number2}");
            else
                await Context.Channel.SendMessageAsync("Вы ввели строки, вместо чисел");

        }
        [Command("multiply")]
        public async Task multiply(string num1, string num2)
        {
            if (int.TryParse(num1, out int number1) && int.TryParse(num2, out int number2))
                await Context.Channel.SendMessageAsync($"{num1} * {num2} = {number1 * number2}");
            else
                await Context.Channel.SendMessageAsync("Вы ввели строки, вместо чисел");

        }
        [Command("scream")]
        public async Task multiply([Remainder]string word)
        {
            string answer = "";
            for (int i = 0; i < word.Length; i++)
            {
                answer += char.ToUpper(word[i]);
            }
            await Context.Channel.SendMessageAsync($"{word} >> {answer}");
        }
        [Command("purge")]
        public async Task Purge(int amount)
        {
            var messages = await Context.Channel.GetMessagesAsync(amount).FlattenAsync();
            await (Context.Channel as SocketTextChannel).DeleteMessagesAsync(messages);
        }
        [Command("destroy")]
        public async Task Destroy()
        {
            SocketGuildChannel Channel = Context.Channel as SocketGuildChannel;
            await Channel.DeleteAsync();
        }
    }
}