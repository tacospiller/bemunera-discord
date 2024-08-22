using Discord.Interactions;
using Discord.WebSocket;
using Bemunera.Core;

namespace Bemunera.LocalClient
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var client = new DiscordSocketClient();
            
            var interactionService = new InteractionService(client.Rest);
            await interactionService.AddModuleAsync<CharacterSheetModule>(null);



            if (args.Length > 0 && args[0] == "--register")
            {
                client.Ready += async () =>
                {
                    try
                    {
                        await interactionService.RegisterCommandsGloballyAsync(true);
                    } catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                    }
                    System.Environment.Exit(0);
                };
            }
            else
            {
                client.InteractionCreated += async (x) =>
                {
                    var ctx = new SocketInteractionContext(client, x);
                    await interactionService.ExecuteCommandAsync(ctx, null);
                };
            }

            await client.LoginAsync(Discord.TokenType.Bot, Environment.GetEnvironmentVariable("BEMUNERA_DISCORD_TOKEN"));
            await client.StartAsync();

            await Task.Delay(-1);
        }
    }


}
