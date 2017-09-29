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

        public void SetItem(string name, int level)
        {
            Item thisItem = new Item();
            thisItem.Name = name;
            thisItem.Level = level;

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
    }
}
