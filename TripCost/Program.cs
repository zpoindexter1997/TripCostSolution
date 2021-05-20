using System;

namespace TripCost
{
    class Program
    {
        static void Main(string[] args)
        {//Creates variable runAgain, sets = to true (initializing as boolean)
            var runAgain = true;
            //While loop, checking to see if runAgain = true
            while (runAgain == true)
            {
                //creates a variable trip, sets = to a new instance of class Trip()
                var trip = new Trip();
                //Asks the user to enter a value for Miles
                Console.Write("Please enter how many miles in your trip: ");
                //creates a variable miles, sets = to user input
                var miles = Console.ReadLine();
                //using variable trips, pointing to Miles property, set = an integer of the converted value for variable miles
                trip.Miles = int.Parse(miles);
                //Prompts the user for mpg
                Console.Write("Please enter how many miles per galon your car drives: ");
                //creates variable mpg, sets = to user input
                var mpg = Console.ReadLine();
                //using variable trip, pointing to Mpg property, sets = integer of converted value of variable mpg
                trip.Mpg = int.Parse(mpg);
                //Prompts user for cost of gas per gallon
                Console.Write("Please enter how much gas costs per gallon: ");
                //creates variable gasPrice, sets = to user input
                var gasPrice = Console.ReadLine();
                //using varibale trip, pointing to property GasPrice, sets = to decimal of converted value of variable gasPrice
                trip.GasPrice = decimal.Parse(gasPrice);
                //creates variable cost, sets = to variable trip pointing at Cost method
                var cost = trip.Cost();
                //Writes out how many miles were entered, and the result of Cost method with entered data
                Console.WriteLine($"For your trip of {miles} miles, it will cost {cost} in gas.");
                //Prompts user if they would like to do another one
                Console.Write("Would you like to calculate a new trip? Y/N: ");
                //creates variable answer, sets = to user input
                var answer = Console.ReadLine();
                //checks if the users input = Y or = y, if so, run this
                if (answer == "Y" || answer == "y")
                {//sets variable runAgain = true, continuing the loop
                    runAgain = true;
                }//if the user didn't input Y or y
                else
                {//sets variable runAgain to false, stopping the loop
                    runAgain = false;
                    //Says goodbye to user
                    Console.WriteLine("Calculator complete, have a good day!");
                }
            }

        }
    }
}
