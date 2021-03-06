﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.First_And_Reserve_Team
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Person> persons = new List<Person>();

            Team team = new Team("SoftUni");
            
            for (int i = 0; i < n; i++)
            {
                string[] command = 
                    Console.ReadLine()
                    .Split()
                    .ToArray();

                string firstName = command[0];
                string lastName = command[1];
                int age = int.Parse(command[2]);
                decimal salary = decimal.Parse(command[3]);

                Person person = new Person(firstName, lastName, age, salary);
                team.AddPlayer(person);
            }
   
            team.Print();
        }
    }
}
