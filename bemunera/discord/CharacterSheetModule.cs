using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Discord;
using Discord.Interactions;

namespace Bemunera.Core
{

    public class CharacterSheetModule: InteractionModuleBase
    {
        [SlashCommand("create", "캐릭터 시트 생성")]
        public async Task CreateSheet([Summary(name: "sheettype", description: "캐릭터 시트 타입"), Choice("프로키온의 무법자들 캐릭터시트", "sv")]string sheettype)
        {
            await RespondWithModalAsync<SheetCreationModal>("create-sheet-modal");
        }

        [ModalInteraction("create-sheet-modal")]
        public async Task OnResponseCreateSheet(SheetCreationModal modal)
        {
            var sheet = new ScumVillainySheet
            {
                Name = modal.Name,
                Desc = modal.Desc,
                Playbook = modal.Playbook,
            };

            await RespondAsync("", embeds: new[] { sheet.ToEmbedBuilder().Build() }, components: new ComponentBuilder().AddRow(new ActionRowBuilder().WithButton("수정", customId: "edit-sheet")).Build());
            var response = await GetOriginalResponseAsync();
            Console.WriteLine(response?.Id);
        }
    }
}
