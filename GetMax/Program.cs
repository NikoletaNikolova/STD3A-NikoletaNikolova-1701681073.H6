using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetMax
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number:");
            int firstnum = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            int secondnum = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter third number:");
            int thirdnum = int.Parse(Console.ReadLine());
            Console.WriteLine("The biggest number is:{0}",GetMax(firstnum,secondnum,thirdnum));
        }
        static int GetMax(int firstnum, int secondnum, int thirdnum)
        {
            int max1 = firstnum > secondnum ? firstnum : secondnum;
            return max1 > thirdnum ? max1 : thirdnum;
        }
    }
}
 
    
         
       



