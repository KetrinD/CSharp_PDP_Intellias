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
            
            CollectionWithRandom collection = new CollectionWithRandom();
            collection.RandomCollection(5);
            collection.ListOfNumbers();
            collection.Growth();
            collection.Decrease();

            Console.ReadLine();
        }
    }
}
