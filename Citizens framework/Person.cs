using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Citizens_framework
{
    internal class Person : Citizens,IBuyer
    {
        
        private int age;
        private string name;
        private string id;
        private string birthdate;
        private int food = 0;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Birthdate
        {
            get { return birthdate; }
            set { birthdate = value; }
        }
        public int Food
        { 
          get {return food;}
          set { food = value;}
        }
        public void BuyFood()
        { 
         food = food + 10;
        }
    }
}
