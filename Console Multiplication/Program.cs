using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Multiplication
{
    class Program
    {
        static void Main(string[] args)
        {

            // Declaring Variables

            int start, stop, multiplier, result;

            
            // Initializing Values to Variables 

            result = 1;
            stop = 12;  //Stating the Value where the Loop will stop executiny 


            try // Catching Exceptions for wrong inputs
                
            {

                // Stating where the user will input the Start Value 

                Console.WriteLine("Enter your Start Value");
                start = int.Parse(Console.ReadLine());


                // Stating where the user will input the Multiplier Value 

                Console.WriteLine("Enter your Multiplier Value");
                multiplier = int.Parse(Console.ReadLine());


                // Performing the Loop

                for (int i = start; i <= stop; i++)
                {

                    // Doing the calculation

                    result = multiplier * i;


                    // Concatenating and Displaying the result

                    Console.WriteLine(multiplier + " " + "Times" + " " + i + " " + "=" + " " + result.ToString());
                }

            }
            catch (FormatException ex) // Catching Format Exception
            {
                
                Console.WriteLine(ex.Message);  // Displaying Error Message for wrong input
 
            }
                
            //Displaying all the results once and making the answer not to disappear

            Console.ReadLine();        

        }
    }
}
