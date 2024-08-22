using Discord;

namespace Bemunera.Core
{
    public class ScumVillainySheet
    {
        public EmbedBuilder ToEmbedBuilder()
        {
            try
            {
                var builder = new EmbedBuilder()
                    .WithTitle(Name)
                    .WithDescription($"**{Playbook}**\n{Desc}")
                    .WithFields(
                        new EmbedFieldBuilder().WithName("스트레스").WithValue(Utils.EmojiBar(Stress, MaxStress, ":broken_heart:", ":heart:")).WithIsInline(true),
                        new EmbedFieldBuilder().WithName("트라우마").WithValue(string.IsNullOrEmpty(Trauma) ? "없음" : Trauma).WithIsInline(true),
                        new EmbedFieldBuilder().WithName("피해").WithValue(string.IsNullOrEmpty(Damage) ? "없음" : Damage),
                        new EmbedFieldBuilder().WithName("크레드").WithValue(Creds == 0 ? "없음" : Utils.EmojiRepeat(Creds, ":gem:")).WithIsInline(true),
                        new EmbedFieldBuilder().WithName("저축").WithValue(Savings == 0 ? "없음" : Utils.EmojiRepeat(Savings, ":moneybag:")).WithIsInline(true),
                        new EmbedFieldBuilder().WithName("특수 능력").WithValue(Skills.StringJoin("\n") ?? "없음"),
                        new EmbedFieldBuilder().WithName("통찰").WithValue(CategoryBuilder(1)).WithIsInline(true),
                        new EmbedFieldBuilder().WithName("체력").WithValue(CategoryBuilder(2)).WithIsInline(true),
                        new EmbedFieldBuilder().WithName("의지").WithValue(CategoryBuilder(3)).WithIsInline(true)
                        );
                return builder;
            } catch (Exception ex)
            {
                Console.WriteLine(ex);
                return new EmbedBuilder();
            }
        }

        private string CategoryBuilder(int idx)
        {
            switch (idx)
            {
                case 1: 
                    return $"{Cat1}/6\n\n**공작** {Utils.EmojiRepeat(Act11, ":large_orange_diamond:")}\n**의료** {Utils.EmojiRepeat(Act12, ":large_orange_diamond:")}\n**조사** {Utils.EmojiRepeat(Act13, ":large_orange_diamond:")}\n**해킹** {Utils.EmojiRepeat(Act14, ":large_orange_diamond:")}";
                case 2:
                    return $"{Cat2}/6\n\n**공작** {Utils.EmojiRepeat(Act11, ":large_orange_diamond:")}\n**의료** {Utils.EmojiRepeat(Act22, ":large_orange_diamond:")}\n**조사** {Utils.EmojiRepeat(Act23, ":large_orange_diamond:")}\n**해킹** {Utils.EmojiRepeat(Act24, ":large_orange_diamond:")}";
                case 3:
                    return $"{Cat3}/6\n\n**공작** {Utils.EmojiRepeat(Act11, ":large_orange_diamond:")}\n**의료** {Utils.EmojiRepeat(Act32, ":large_orange_diamond:")}\n**조사** {Utils.EmojiRepeat(Act33, ":large_orange_diamond:")}\n**해킹** {Utils.EmojiRepeat(Act34, ":large_orange_diamond:")}";
                default:
                    return "없음";
            }
        }

        public string Player { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public string Playbook { get; set; }
        public int MaxStress { get; set; } = 8;
        public int Stress { get; set; }
        public string Trauma { get; set; }
        public string Damage { get; set; }
        public List<string> Skills { get; set; }
        public int Creds { get; set; }
        public int Savings { get; set; }
        public int Cat1 { get; set; }
        public int Act11 { get; set; } = 2;
        public int Act12 { get; set; }
        public int Act13 { get; set; } = 1;
        public int Act14 { get; set; }
        public int Cat2 { get; set; }
        public int Act21 { get; set; }
        public int Act22 { get; set; }
        public int Act23 { get; set; }
        public int Act24 { get; set; }
        public int Cat3 { get; set; }
        public int Act31 { get; set; }
        public int Act32 { get; set; }
        public int Act33 { get; set; }
        public int Act34 { get; set; }
    }
}
