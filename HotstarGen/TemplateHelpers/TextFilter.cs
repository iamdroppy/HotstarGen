using System.Text;
using System.Text.RegularExpressions;

namespace HotstarGen.TemplateHelpers
{
    public static class TextFilter
    {
        public static string Normalize(string input, string to)
        {
            if (input.StartsWith("_0x")) return input;

            StringBuilder b = new StringBuilder();
            bool isUpper = true;
            foreach (var v in input.ToCharArray())
            {
                if (v == '_')
                {
                    isUpper = true; 
                    continue;
                }

                if (isUpper)
                {
                    b.Append(char.ToUpper(v));
                    isUpper = false;
                }
                else
                    b.Append(char.ToLowerInvariant(v));
            }

            return b.ToString();
        }
    }
}