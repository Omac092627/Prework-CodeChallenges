using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.cs
{
   /* class ArrayMaxResult
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
   */

    /*class LeapYearCalendar
    {
                static void Main(string[] args)
            {
            DateTime myValue = DateTime.Now;
            Console.WriteLine( "Here is the current year: " + myValue.ToShortDateString()); //month,day,year

            bool correct = false;
     

            do{

            Console.WriteLine("Enter a year to find out if it is a leap year!: ");
            Console.ReadLine();

            }while(correct);
            {
            for (int year = 1990; year <= 2020; year++)
              {
            if (DateTime.IsLeapYear(year))
         {
            Console.WriteLine("{0} is a leap year.", year);
            DateTime leapDay = new DateTime(year, 2, 29);
            DateTime nextYear = leapDay.AddYears(1);
            Console.WriteLine("   One year from {0} is {1}.",
                              leapDay.ToString("d"),
                              nextYear.ToString("d"));
         }
      }
            }
            Console.ReadLine();

            }
    */

  /*  class PerfectSequence
        {
        
       public static void Main(string[] args)  
      {  
          int n, i, m=0, flag=0;    
          Console.Write("Enter the Number to check Prime: ");    
          
          n = int.Parse(Console.ReadLine());  

             int sum = 0;
                while (n != 0) {
                sum += n % 10;
                 n /= 10;

          m=n/2;    
          for(i = 2; i <= m; i++)    
          {    
           if(n % i == 0)    
            {    
             Console.Write("No");    
             Console.ReadLine();
             flag=1;    
             break;    
            }    
          }    
          if (flag==0)    
           Console.Write("Yes");      
           Console.ReadLine();
     }  
        
        //Perfect number is a positive number which sum of all positive divisors excluding that number is equal to that number. For example 6 is perfect number since divisor of 6 are 1, 2 and 3.  Sum of its divisor is 1 + 2+ 3 = 6
    
    

    }
    }
  */


  /*  class SumOfRows
        {
          public static void Main()  
    {  
        int rows, cols, sumRow, sumCol;  

          
        //Initialize matrix a  
        Random rnd = new Random();
        int[,] a = new int[3,5];
        for(int i=0;i<3;i++)
        {
            for(int j=0;j<5;j++)
            {
                a[i, j]= rnd.Next(1, 10);
            }
    }

          //Calculates number of rows and columns present in given matrix  
          rows = a.GetLength(0);  
        cols = a.GetLength(1);  
          
        //Calculates sum of each row of given matrix  
        for(int i = 0; i < rows; i++){  
            sumRow = 0;  
            for(int j = 0; j < cols; j++){  
              sumRow = sumRow + a[i,j];  
            }  
            Console.Write(" Sum of  " + (i+1) + " row: " + sumRow);  
        }  
          
        //Calculates sum of each column of given matrix  
        for(int i = 0; i < cols; i++){  
            sumCol = 0;  
            for(int j = 0; j < rows; j++){  
              sumCol = sumCol + a[j,i];  
            }  
        }  
        Console.ReadLine();
        
    }
    }
  */



 }

