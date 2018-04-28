using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmering1_Sauna {
    class Program {
        static void Main(string[] args) {

            //  DEFINING SOME DATA
            int fahrTemp = 167;
            double celsTemp = 75;
            bool endLoop = false;

            const int minTempF = 163;
            const int maxTempF = 170;

            double maxTempC = FahrToCels(maxTempF);
            double minTempC = FahrToCels(minTempF);

            //      INPUT
            Console.WriteLine("=== SAUNA ===");
            do {
                do {
                    Console.Write("Choose a temperature between {0} and {1} fahrenheit: ", minTempF, maxTempF);
                    try {
                        fahrTemp = Convert.ToInt32(Console.ReadLine());
                        endLoop = true; /* To end the do-while loop when after the user 
                                           has enterd an integer without any exceptions. */
                    }
                    catch(FormatException) { 
                        Console.WriteLine("Please write an integer.");
                    }
                    catch(OverflowException) {
                        Console.WriteLine("That number is too big or too small.");
                    }
                } while(endLoop != true);

                celsTemp = FahrToCels(fahrTemp);    // To convert fahrenheit to celcius 
                //Console.WriteLine("Control: {0:f1}Celsius",celsTemp);

                //      OUTPUT
                if(celsTemp < minTempC) { // To prevent the sauna from being too cold
                    Console.WriteLine("That is too cold");
                }
                else if(celsTemp > maxTempC) { // To prevent the sauna from being too warm
                    Console.WriteLine("That is too warm");
                }
                else {
                    Console.WriteLine("The current temperature is now {0} fahrenheit", fahrTemp);
                }

            } while(celsTemp < minTempC || celsTemp > maxTempC);
            Console.WriteLine("Thank you for this time");
            Console.ReadKey();
        }


        /************** FahrToCels *************\
        |  A method to convert a temperature    |
        |  from fahrenheit to celsius           |
        \***************************************/
        static double FahrToCels(int fahrenheit) {
            Convert.ToDouble(fahrenheit);   // To be able to calculate with decimals.
            double celsius = (fahrenheit - 32) / 1.8;
            return celsius;
        }
    }
}
