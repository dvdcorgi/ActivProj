using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pyrolysis
{
    class Behavior
    {
        public List<Hero> MyHero = new List<Hero>();

        public Hero AddHero(string name, int level)
        {
            Hero h = new Hero();
            h.Name = name;
            h.Level = level;
            MyHero.Add(h);
            return h;
        }

        public List<Hero> GetHeroes()
        {
            return MyHero;
        }

        public void HeroListConsole()
        {
            foreach (var item in MyHero)
            {
                Console.WriteLine("Console Hero " + item.Name + " Level: " + item.Level);
            }
        }
    }
}
