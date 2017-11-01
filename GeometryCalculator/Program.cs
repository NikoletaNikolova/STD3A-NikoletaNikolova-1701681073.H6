using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose option (triangle, square or radians): ");
            string option = Console.ReadLine();
            switch (option)
            {
                case "triangle":
                    Console.WriteLine("Enter side: ");
                    double a = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter height: ");
                    double h = double.Parse(Console.ReadLine());
                    double S = (a * h) / 2;
                    Console.WriteLine("The area of the triangle is {0:F2} ", S);
                    break;
                case "square":
                    Console.WriteLine("Enter side: ");
                    double b = double.Parse(Console.ReadLine());
                    double S2 = Math.Pow(b,2);
                    Console.WriteLine("The area of the square is {0:F2}", S2);
                    break;
                case "radians":
                    Console.WriteLine("Enter the degrees you want to transform in radians: ");
                    double c = double.Parse(Console.ReadLine());
                    double Rad = (Math.PI / 180) * c;
                    Console.WriteLine("Your degrees in radians are = {0}", Rad);
                    break;
                default:
                    Console.WriteLine("That's not an option");
                    break;
            }
        }


    }


}   
  

              
        
                    

                

        
        
    

