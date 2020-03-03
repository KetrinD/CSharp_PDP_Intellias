using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_PDP_Intellias
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            CollectionWithRandom collection = new CollectionWithRandom();
            collection.numbers.Add(random.Next(0, 10));
            collection.numbers.Add(random.Next(0, 10));
            collection.numbers.Add(random.Next(0, 10));
            collection.numbers.Add(random.Next(0, 10));
            collection.numbers.Add(random.Next(0, 10));
            collection.numbers.Add(random.Next(0, 10));


            collection.ListOfNumbers();
            collection.Growth();
            collection.Decrease();




            Console.ReadLine();
        }
    }
}
