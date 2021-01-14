using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;

namespace XeMBot
{
    public class Commands : ModuleBase<SocketCommandContext>
    {
        [Command("ping")]

        public async Task PingAsync()
        {
            EmbedBuilder builder = new EmbedBuilder();

            builder.WithTitle($"Pong! :ping_pong: - { Context.Client.Latency}ms")
                .WithDescription("Ping me again daddy!!")
                .WithColor(Color.Green);

            await ReplyAsync("", false, builder.Build());
        }

        [Command("serverinfo")]

        public async Task ServerInfoAsync()
        {
            EmbedBuilder builder = new EmbedBuilder();

            builder.WithTitle($"Server: {Context.Guild.Name}")
                .WithThumbnailUrl(Context.Guild.IconUrl)
                .WithColor(Color.Magenta)
                .AddField("Owner", $"{Context.Guild.Owner}")
                .AddField("Server erstellt", $"{Context.Guild.CreatedAt}")
                .AddField("Mitglieder", $"{Context.Guild.MemberCount}")
                .AddField("Anzahl Rollen", $"{Context.Guild.Roles.Count}")
                .AddField("Anzahl Textchannel", $"{Context.Guild.TextChannels.Count}")
                .AddField("Anzahl Voicechannels", $"{Context.Guild.VoiceChannels.Count}")
                .AddField("Verification Level", $"{Context.Guild.VerificationLevel}")
                .AddField("Server Region", $"{Context.Guild.VoiceRegionId}")
                .WithFooter($"{DateTime.Now}");

            await ReplyAsync("", false, builder.Build());
        }

        [Command("pick")]

        public async Task Pick()
        {
            var random = new Random();
            var pick = new List<string> { "1", "2", "3", "4", "5", "6" };
            int index = random.Next(pick.Count);
            await ReplyAsync("Deine Zahl ist: " + pick[index], false);
        }
    }
}
