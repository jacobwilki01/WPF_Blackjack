using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Blackjack.Util
{
    public static class ResourceUtil
    {
        private static readonly string? _assemblyPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

        private const string ASSETS_CARDS = "Assets\\Cards";

        private static string GetCardsDirectory()
        {
            return Path.Combine(_assemblyPath ?? string.Empty, ASSETS_CARDS);
        }

        public static string GetCardsPath(string filename)
        {
            return Path.Combine(GetCardsDirectory(), filename);
        }
    }
}
