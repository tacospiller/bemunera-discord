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
                        new EmbedFieldBuilder().WithName("크레드").WithValue(Creds == 0 ? "없음" : Utils.EmojiRepeat(Creds, ":gem:")),
                        new EmbedFieldBuilder().WithName("저축").WithValue(Savings == 0 ? "없음" : Utils.EmojiRepeat(Savings, ":moneybag:")),
                        new EmbedFieldBuilder().WithName("특수 능력").WithValue(Skills.StringJoin("\n") ?? "없음"),
                        new EmbedFieldBuilder().WithName("통찰").WithValue(Utils.EmojiBar(Cat1, 6, ":white_square_button:", ":white_large_square:")).WithIsInline(true),
                        new EmbedFieldBuilder().WithName("체력").WithValue(Utils.EmojiBar(Cat2, 6, ":white_square_button:", ":white_large_square:")).WithIsInline(true),
                        new EmbedFieldBuilder().WithName("의지").WithValue(Utils.EmojiBar(Cat3, 6, ":white_square_button:", ":white_large_square:")).WithIsInline(true),
                        new EmbedFieldBuilder().WithName("공작").WithValue(Utils.EmojiBar(Act11, 3, ":white_square_button:", ":white_large_square:")).WithIsInline(true),
                        new EmbedFieldBuilder().WithName("기동").WithValue(Utils.EmojiBar(Act21, 3, ":white_square_button:", ":white_large_square:")).WithIsInline(true),
                        new EmbedFieldBuilder().WithName("명령").WithValue(Utils.EmojiBar(Act31, 3, ":white_square_button:", ":white_large_square:")).WithIsInline(true),
                        new EmbedFieldBuilder().WithName("의료").WithValue(Utils.EmojiBar(Act12, 3, ":white_square_button:", ":white_large_square:")).WithIsInline(true),
                        new EmbedFieldBuilder().WithName("싸움").WithValue(Utils.EmojiBar(Act22, 3, ":white_square_button:", ":white_large_square:")).WithIsInline(true),
                        new EmbedFieldBuilder().WithName("조율").WithValue(Utils.EmojiBar(Act32, 3, ":white_square_button:", ":white_large_square:")).WithIsInline(true),
                        new EmbedFieldBuilder().WithName("조사").WithValue(Utils.EmojiBar(Act13, 3, ":white_square_button:", ":white_large_square:")).WithIsInline(true),
                        new EmbedFieldBuilder().WithName("조타").WithValue(Utils.EmojiBar(Act23, 3, ":white_square_button:", ":white_large_square:")).WithIsInline(true),
                        new EmbedFieldBuilder().WithName("친교").WithValue(Utils.EmojiBar(Act33, 3, ":white_square_button:", ":white_large_square:")).WithIsInline(true),
                        new EmbedFieldBuilder().WithName("해킹").WithValue(Utils.EmojiBar(Act14, 3, ":white_square_button:", ":white_large_square:")).WithIsInline(true),
                        new EmbedFieldBuilder().WithName("잠행").WithValue(Utils.EmojiBar(Act24, 3, ":white_square_button:", ":white_large_square:")).WithIsInline(true),
                        new EmbedFieldBuilder().WithName("현혹").WithValue(Utils.EmojiBar(Act34, 3, ":white_square_button:", ":white_large_square:")).WithIsInline(true)
                        );
                return builder;
            } catch (Exception ex)
            {
                Console.WriteLine(ex);
                return new EmbedBuilder();
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
        public int Act11 { get; set; }
        public int Act12 { get; set; }
        public int Act13 { get; set; }
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
