using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Piracy
{
    public class Ship
    {
        public int Draft;
        public int Crew;

        public Ship(int draft, int crew)
        {
            Draft = draft;
            Crew = crew;
        }
       

        public bool IsWorthIt()
        {
            //return Draft + (Crew * 1.5) > 20;
            return (Draft - 1.5 * Crew > 20 && Crew == 0);
        }
    }
}
