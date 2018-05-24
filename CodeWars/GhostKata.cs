using System;
using System.Linq;

namespace CodeWars
{
    public class GhostKata
    {
        private static readonly Random _random = new Random();

        public string Colour { get; set; }

        private readonly string[] _colors = { "white", "yellow", "purple", "red" };
        public GhostKata()
        {
            var pos = _random.Next(_colors.Length);
            Colour = _colors[pos];
        }

    }
}
