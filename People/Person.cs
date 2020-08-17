using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.People
{
    public class Person
    {
        public string Name;
        public int Age;
        public bool HasPet;

        public void Greetings()
        {
            Console.WriteLine("Hii, my name is " + Name + " and my age is " + Age);
        }

        public static int Calc(int x, int y)
        {
            int number = x + y;
            return number;
        }

    }

}
