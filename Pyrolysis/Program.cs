using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pyrolysis
{
    class Program
    {
        public static string itemInput { get; set; }
        public static int a { get; set; }
        public static List<int> myNum { get; set; }

        static void Main(string[] args)
        {
            Console.WriteLine("Program started");
            
            do
            {
                SolveItem();
                //HeroAction();
                //ProgAction();
            } while (true);
        }

        private static void SolveItem()
        {
            try
            {
                List<Int32> myNum = new List<Int32>();
                Random r = new Random();
                var num1 = r.Next(0, 10);
                myNum.Add(num1);
                foreach (var item in myNum)
                {
                    Console.WriteLine(item);
                    myNum.Add(item);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void HeroAction()
        {
            Console.WriteLine("Hero name");
            var heroName = Console.ReadLine();
            Console.WriteLine("Hero level");
            var heroLevel = Convert.ToInt32(Console.ReadLine());
            
            //Hero h = new Hero();

            //h.Name = heroName;
            //h.Level = heroLevel;

            Behavior b = new Behavior();

            b.AddHero(heroName, heroLevel);

            foreach (var item in b.GetHeroes())
            {
                Console.WriteLine(item.Name + " " +item.Level);
            }

            b.HeroListConsole();
        }

        private static void ProgAction()
        {
            do
            {
                itemInput = Console.ReadLine();
                ComputeItem(itemInput);
            } while (itemInput != "x");
        }

        private static void ComputeItem(string itemIn)
        {
            char[] strArray = itemIn.ToCharArray();
            Random r = new Random();
            var itemOut = "";

            foreach (var item in strArray)
            {
                itemOut = itemOut + item + r.Next(0,10).ToString();
            }

            Console.WriteLine("Test out " + itemOut);
        }
    }
}
