using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Citizens_framework
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int i = 0;
            string input = Console.ReadLine();
            var list1 = input.Split(' ').ToList();
            string name = "";
            int foods = 0;
            Citizens citizens = new Citizens();
            List<string> personnames = new List<string>();
            List<string> rebelnames = new List<string>();

            while (i <= n)
            {
                i++;
                if (i == n )
                {
                    break;
                }
                if (list1.Count == 2)
                {
                    Robot robot = new Robot();
                    robot.Model = list1[0];
                    robot.Id = list1[1];
                    citizens.Robots.Add(robot);

                }
                else if (list1.Count == 4)
                {
                    Person person = new Person();
                    person.Name = list1[0];
                    person.Age = int.Parse(list1[1]);
                    person.Id = list1[2];
                    person.Birthdate = list1[3];
                    citizens.Persons.Add(person);
                    personnames.Add(person.Name);

                }
                else if (list1.Count == 3)
                {
                    Rebel rebel = new Rebel();
                    rebel.Name = list1[0];
                    rebel.Age = int.Parse(list1[1]);
                    rebel.Group = list1[2];
                    citizens.Rebels.Add(rebel);
                    rebelnames.Add(rebel.Name);
                }
                input = Console.ReadLine();
                list1 = input.Split(' ').ToList();
            }
            while (name != "end")
            {
                name = Console.ReadLine();
                if (personnames.Contains(name))
                {
                    foreach (Person person in citizens.Persons)
                    {
                        if (person.Name == name)
                        {
                            person.BuyFood();
                            foods = foods + 10;
                        }
                    }
                }
                else if (rebelnames.Contains(name))
                {
                    foreach (Rebel rebel in citizens.Rebels)
                    {
                        if (rebel.Name == name)
                        {
                            rebel.BuyFood();
                            foods = foods + 5;
                        }
                    }
                }
                else
                {

                }
            }
            Console.WriteLine(foods);
            Console.ReadKey();
        }
    }
}
/*
 * Zadacha 1
         int checkedNumber = int.Parse(Console.ReadLine());
         foreach (Person person in citizens.Persons)
         {
             string parsed = person.Id.ToString();
             if (parsed.EndsWith(checkedNumber.ToString()))
             {
                 Console.WriteLine(person.Id);
             }
         }
         foreach (Robot robot in citizens.Robots)
         {
             string parsed = robot.Id.ToString();
             if (parsed.EndsWith(checkedNumber.ToString()))
             {
                 Console.WriteLine(robot.Id);
             }
         }
*/

/* 
 Zadacha 2

 int bdnumber = int.Parse(Console.ReadLine());
                foreach (Person person in citizens.Persons)
                {
                    string bd = person.Birthdate.ToString();
                    if (bd.EndsWith(bdnumber.ToString()))
                    {
                        Console.WriteLine(person.Name + " " + person.Birthdate);
                    }
                }
                foreach (Pet pet in citizens.Pets)
                {
                    string bd = pet.Birthdate.ToString();
                    if (bd.EndsWith(bdnumber.ToString()))
                    {
                        Console.WriteLine(pet.Name + " " + pet.Birthdate);
                    }
                }
 */