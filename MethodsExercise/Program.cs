using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Mehtod
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Excerise 1


            //Name: Micheal
            //Favorite Color: Blue
            //Favorite Animal: Walrus
            //Favorite Band: The Beatles


            
            Console.WriteLine("What is your name?");
            string username = Console.ReadLine();

            Console.WriteLine("What your favorite color?");
            string color  = Console.ReadLine();



            Console.WriteLine("What your favorite animal?");
            string Animal = Console.ReadLine();

            Console.WriteLine("what your favorite band?");
            string band = Console.ReadLine();

            Console.WriteLine($"Name: {username}");
            Console.WriteLine($"Favorite color: {color}");
            Console.WriteLine($"Favorite animal: {Animal}");
            Console.WriteLine($"Favorite Band: {band}");

            int addedNums = Add(2, 4);
            Console.WriteLine(addedNums);


            int multiplynums = Multiply(10, 2);
            Console.WriteLine(multiplynums);


        }

        public static int Add(int num1, int num2)
        { 
            var answer = num1 + num2;   
            return num1 + num2;    
            
         
        
        
        
        }
        public static int Multiply(int num1, int num2)
      
        {
            var answer = (num1 * num2);
            return num1 * num2;

        
        }

    
    
    
    
    
    }      
}