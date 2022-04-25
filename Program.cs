using System;  
  public class PrimeNumberExample  
   {  
     public static void Main(string[] args)  {
         Console.Write("Enter first number:");
         int firstNum = int.Parse(Console.ReadLine());
         Console.Write("Enter second number:");
         int secNum = int.Parse(Console.ReadLine());
         Console.WriteLine(lessThan100(firstNum,secNum));

     }

     static bool lessThan100(double a, double b){
        if( a + b < 100){
            return true;
        }
        else {
            return false;
        }

     }
   }