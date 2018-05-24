using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.AdamAndEve
{
    public static class God
    {
        public static Human[] Create()
        {
            return new Human[] {new Man("Adam"), new Woman("Eve")};
        }

        public static void SayHiToHuman(Human human)
        {
            Console.WriteLine("Hello " + human.Name);
        }
    }
}
