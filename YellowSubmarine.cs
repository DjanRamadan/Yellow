using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YellowSubmarine
{
    internal class YellowSubmarine
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many people are in the boat?");
            int n = int.Parse(Console.ReadLine());
            Person[] arr = new Person[n];

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(',');
                Person person = new Person();
                person.FName = input[0];
                person.LName = input[1];
                person.Age = int.Parse(input[2]);
                person.Address = input[3];
                arr[i] = person;


            }

            Console.WriteLine("Whose information do you want?");
            int index = int.Parse(Console.ReadLine());
            if (index >= 0 && index < arr.Length)
            {
                Person requestedPerson = arr[index];
                requestedPerson.WriteInfo();
            }
            else
            {
                Console.WriteLine("Gledai si rabotata");
            }
            Console.ReadLine();
        }
    }

    class Person
    {
        public string FName { get; set; }
        public string LName { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }

        public void WriteInfo()
        {
            Console.WriteLine($"I am {FName[0]}. {LName}. I am {Age} years old and i live on {Address}");
        }


    }
}
