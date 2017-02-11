using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaffittMath
{
    public class Prime
    {
        //Name:		isPrime
        //Input:	number as an integer
        //Output:	Boolean - Prime = True, Composite = False
        //Purpose:	This function will use the Trial Test method to determine if the 
        //value sent to it is a prime number or not.
        public bool IsPrime(int? number)
        {
            if (number == null || number <= 1)
            {
                return false;
            }

            bool primeFlag = true;
            for (int x = 2; x < number; x++)
            {
                if (number % x == 0) // A Composite number was found number is NOT prime.
                {
                    primeFlag = false;
                    Console.Write(x + " ");
                }
            }
            return primeFlag;
        }
    }
}
