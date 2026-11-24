using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{

internal class Array : IOutput2, ICalc2
    {
        private int[] data;

        public Array(int[] numbers)
        {
            data = numbers;
        }

        public void ShowEven()
        {
            Console.Write("Even: ");
            bool found = false;
            foreach (int num in data)
            {
                if (num % 2 == 0)
                {
                    Console.Write(num + " ");
                    found = true;
                }
            }
            if (!found)
                Console.Write("None");
            Console.WriteLine();
        }

        public void ShowOdd()
        {
            Console.Write("Odd: ");
            bool found = false;
            foreach (int num in data)
            {
                if (num % 2 != 0)
                {
                    Console.Write(num + " ");
                    found = true;
                }
            }
            if (!found)
                Console.Write("None");
            Console.WriteLine();
        }

        public int CountDistinct()
        {
            List<int> distinct = new List<int>();
            foreach (int num in data)
            {
                if (!distinct.Contains(num))
                    distinct.Add(num);
            }
            return distinct.Count;
        }

        public int EqualToValue(int valueToCompare)
        {
            int count = 0;
            foreach (int num in data)
            {
                if (num == valueToCompare)
                    count++;
            }
            return count;
        }
    }
}


