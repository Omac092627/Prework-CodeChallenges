using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.cs
{
    class ArrayMaxResult
    {
        static void Main(string[] args)
        {

            int Min = 1;
            int Max = 10;
            int[] numbers = {1, 2, 3, 4, 5};


            Random randNum = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = randNum.Next(Min, Max);
            }

            bool correct = false;

            do
            {
                Console.Write("Please pick 1 number from the selection of " + string.Join(",", numbers) + " : ");
                Console.ReadLine();
            } while (correct);
            {


            var m = from x in numbers
                    group x by x into y
                    select y;

            foreach(var arrEle in m)
            {
                Console.WriteLine(arrEle.Key + "\t" + arrEle.Sum() + "\t\t\t" + arrEle.Count());
            }
            Console.WriteLine();
                Console.ReadLine();
            }
          
        
        }
    }
}