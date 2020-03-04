using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_PDP_Intellias
{
    public class CollectionWithRandom
    {
        
        public List<int> numbers = new List<int>();

        public void RandomCollection()
        {
            Random random = new Random();
            numbers.Add(random.Next(0, 10));
            numbers.Add(random.Next(0, 10));
            numbers.Add(random.Next(0, 10));
            numbers.Add(random.Next(0, 10));
            numbers.Add(random.Next(0, 10));
            numbers.Add(random.Next(0, 10));
        }


        public void ListOfNumbers()
        {
            foreach (int x in numbers)
            {
                Console.WriteLine(x);
            }
        }
       

    //в порядку збільшення
    public void Growth()
        {
            
            for (int i = 0; i < numbers.Count; i++)
            {
                for (int j = 0; j < numbers.Count - 1; j++)
                {
                    if (numbers[j + 1] < numbers[j])
                    {
                        int c = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = c;
                    }
                }
            }
            Console.WriteLine("\nArray2: [{0}]", string.Join(", ", numbers));
        }

        // в порядку зменшення-
        public void Decrease()
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                for (int j = 0; j < numbers.Count - 1; j++)
                {
                    if (numbers[j + 1] > numbers[j])
                    {
                        int c = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = c;
                    }
                }
            }
            Console.WriteLine("\nArray3: [{0}]", string.Join(", ", numbers));
        }
    }
}

