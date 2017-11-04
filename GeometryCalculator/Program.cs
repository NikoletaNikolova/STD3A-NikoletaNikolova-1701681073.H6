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
            Console.WriteLine("Your option: ");
            string option = Console.ReadLine();
            switch (option)
            {
                case "triangle":
                           Triangle();
                           break;
                case "square":       
                         Square();
                         break;
                case "radians":
                         Radians();
                         break;
                case "exit":
                         Environment.Exit(0);
                         break;
                default:
                    Console.WriteLine("That's not an option");
                    break;
            }
        }
        static void Triangle()
        {
            Console.WriteLine("Enter side: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter height: ");
            double h = double.Parse(Console.ReadLine());
            double S = (a * h) / 2;
            Console.WriteLine("The area of the triangle is {0:F2} ", S);
            
        }
        static void Square()
        {
            Console.WriteLine("Enter side: ");
            double a = double.Parse(Console.ReadLine());
            double S = Math.Pow(a, 2);
            Console.WriteLine("The area of the square is {0:F2}", S);
            
            
            
        }  
         static void Radians()   
         {    
       
            Console.WriteLine("Enter the degrees you want to transform in radians: ");
            double b = double.Parse(Console.ReadLine());
            double Rad = (Math.PI / 180) * b;
            Console.WriteLine("Your degrees in radians are {0}", Rad);
            
         }
     }


}  
            
           
            
           
            
            
            
    



  

              
        
                    

                

        
        
    

