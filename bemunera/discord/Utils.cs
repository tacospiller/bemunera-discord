using System.Text;

namespace Bemunera.Core
{
    public static class Utils
    {
        public static string EmojiBar(int current, int max, string fill, string empty)
        {
            var builder = new StringBuilder();
            for (var i = 0; i < max; i++)
            {
                if (i < current)
                {
                    builder.Append(fill);
                } else
                {
                    builder.Append(empty);
                }
            }
            return builder.ToString();
        }

        public static string EmojiRepeat(int count, string emoji)
        {
            var builder = new StringBuilder();
            for (var i = 0; i < count; i++)
            {

                 builder.Append(emoji);

            }
            return builder.ToString();
        }

        public static string StringJoin(this IEnumerable<string> strings, string separator = "")
        {
            if (strings == null)
            {
                return null;
            }
            var builder = new StringBuilder();
            builder.AppendJoin(separator, strings);
            var str = builder.ToString();
            if (str == "")
            {
                return null;
            }
            return str;
        }
    }
}
