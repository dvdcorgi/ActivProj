using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestUpdater
{
    class ClassCombine
    {
        private Item MyItem { get; set; }

        public void SetItem(string name)
        {
            Item thisItem = new Item();
            thisItem.Name = name;
            thisItem.Level = RandomLevel();

            MyItem = thisItem;
        }

        public string GetName()
        {
            return MyItem.Name;
        }

        public int GetLevel()
        {
            return MyItem.Level;
        }

        private int RandomLevel()
        {
            Random r = new Random();
            return r.Next(1, 100);
        }
    }
}
