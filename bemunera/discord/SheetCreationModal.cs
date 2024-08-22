using Discord;
using Discord.Interactions;

namespace Bemunera.Core
{
    public class SheetCreationModal : IModal
    {
        public string Title => "캐릭터 시트 생성";

        [InputLabel("캐릭터 이름")]
        [ModalTextInput("char-name")]
        public string Name { get; set; }
        [InputLabel("캐릭터 설명")]
        [ModalTextInput("char-desc", style: TextInputStyle.Paragraph)]
        [RequiredInput(false)]
        public string Desc { get; set; }
        [InputLabel("플레이북")]
        [ModalTextInput("playbook", placeholder: "기술자")]
        public string Playbook { get; set; }
    
    }
}
