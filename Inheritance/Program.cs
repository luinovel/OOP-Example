using Inheritance.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Encapsulation
//Inheritance
//Polymorphism

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            MusicalPerformer Hamilton = new MusicalPerformer();

            Console.WriteLine($"Hamilton dances: {Hamilton.Dance()}");
            Console.WriteLine($"Hamilton also sings: {Hamilton.Sing()}");

            string nextTune = Hamilton.Sing("Alexander Hamilton, My name is Alexander Hamilton");
            Console.WriteLine(nextTune);


            // Polymorphism anyone? Let's see...
            List<Personnel> crew = new List<Personnel>();

            crew.Add(Hamilton);

            foreach(var crewMember in crew)
            {
                Console.WriteLine(crewMember.GetType().ToString());
            }
        }
    }
}
