using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Feedback is available here http://goo.gl/forms/OiPem2zZ0ot152Wn2
             *  
             * 
             * 
             * notes.txt
             */



            //title and window size
            Console.Title = "GTA V Online Crate Counter  (GTAVOCC)";
            Console.SetWindowSize(100,25);

            //declaring vars before loop
            int addamount = 0;
            int currentamount = 0;
            int specialamount = 0;
            string sel = "";
            int estamount = 0;
            double esthrs = 0;          

            int loop = 1; //loop controller
                  
            //entry menu
            Console.WriteLine();
            Console.WriteLine("Please enter the amount of crates that will be farmed (1,2,3)");
            addamount = Convert.ToInt32(Console.ReadLine());

            //main loop
            while (loop == 1)
            {
                //main menu
                Console.Clear();
                Console.WriteLine("                                     Normal Crates = " + currentamount);
                Console.WriteLine();
                Console.WriteLine("                                     Special Crates = " + specialamount);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Enter y to add " + addamount + " to the crates");
                Console.WriteLine("Enter x to add 1 to the special crates");
                Console.WriteLine("Enter e to get an estimate");
                Console.WriteLine("Enter a to change the amount of crates that you are farming");
                Console.WriteLine("Enter c to enter a custom amount for normal crates");
                Console.WriteLine("Enter s to enter a custom amount for special crates");
                Console.WriteLine("Enter exit to quit");

                sel = Console.ReadLine().ToLower();

                if (sel == "y") // add to the normal amount
                {
                    currentamount = currentamount + addamount;
                }
                else if (sel == "exit") //exit loop
                {
                    loop--;
                }
                else if (sel == "c") // cusotom normal crate amount
                {
                    Console.Clear();
                    Console.WriteLine("Please enter a custom amount of crates ");
                    currentamount = Convert.ToInt32(Console.ReadLine());
                }
                else if (sel == "s") //custom special crate amount
                {
                    Console.Clear();
                    Console.WriteLine("Please enter a custom amount of crates ");
                    specialamount = Convert.ToInt32(Console.ReadLine());
                }
                else if (sel == "e")// estimate
                {
                    Console.Clear();
                    Console.WriteLine("Enter the amount of crates you wish to complete");
                    estamount = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();

                    Console.WriteLine("At an average of 6 mins per crate " + estamount);
                    Console.WriteLine();
                    //display tripple creates
                    esthrs = (estamount * 6) / 3; // multiply the amount of crates by 6 to get minutes divided by 3 because of double crates
                    Console.WriteLine("Tripple creates would take about:");
                    Console.WriteLine(esthrs + " mins");// display mins
                    esthrs = esthrs / 60; // divide mins by 60 to get hrs
                    Console.WriteLine("or");
                    Console.WriteLine(esthrs + " hrs");// display hrs
                    Console.WriteLine("-----------------------------------------------------------------------------------------");


                    //display double creates
                    esthrs = (estamount * 6) / 2; // multiply the amount of crates by 6 to get minutes divided by 2 because of double crates
                    Console.WriteLine();
                    Console.WriteLine("Double creates would take about:");
                    Console.WriteLine(esthrs + " mins");// display mins
                    esthrs = esthrs / 60; // divide mins by 60 to get hrs
                    Console.WriteLine("or");
                    Console.WriteLine(esthrs + " hrs");// display hrs
                    Console.WriteLine();
                    Console.WriteLine("-----------------------------------------------------------------------------------------");

                    //single crates
                    esthrs = (estamount * 6); //multiply the amount of crates by 6 to get minutes
                    Console.WriteLine();
                    Console.WriteLine("Single creates would take about:");
                    Console.WriteLine(esthrs + " mins");// display mins
                    esthrs = esthrs / 60; // divide mins by 60 to get hrs
                    Console.WriteLine("or");
                    Console.WriteLine(esthrs + " hrs");// display hrs


                    Console.ReadKey(); //wait for user and go back to the start
                }

                else if (sel == "a") //change the amount of crates that will be farmed
                {
                    Console.Clear();
                    Console.WriteLine("Enter the new amount of crates you are farming:");
                    addamount = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("New farm rate = " + addamount);
                    Console.ReadKey();
                }             
            }
        }
    }
}
