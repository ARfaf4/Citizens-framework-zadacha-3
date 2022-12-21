using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Citizens_framework
{
    internal class Rebel :IBuyer
    {
        private string name;
        private int age;
        private string group;
        private int food = 0;

        public string Name
        { 
            get { return name; } 
            set { name = value; } 
        }
        public string Group
        {
            get { return group; }
            set { group = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public int Food
        { 
          get {return food;}
          set { food = value;}
        }
        public void BuyFood()
        { 
         food = food + 5;
        }
    }
}
