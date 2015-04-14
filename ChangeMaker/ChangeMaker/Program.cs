using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            //calling the function with the bonus credit.  
       
            ChangeAmount(151.25m);

            Console.ReadKey();
        }

        public static Change ChangeAmount(decimal amount) 
        {
            //this is our object that will hold the data of how many coins of each type to return
            Change amountAsChange = new Change();
        



            //saves the original amount
            decimal originalAmount = amount;
           //writes to console the original amount
            Console.WriteLine("Amount: $" + originalAmount);

            //adds the benjamins
            int hundreds = Convert.ToInt32(Math.Truncate(amount / 100));
            amount = amount % 100;
            amountAsChange.Hundred = hundreds;
            Console.WriteLine("Hundreds: " + amountAsChange.Hundred);

            //adds the fifties
            int fifties = Convert.ToInt32(Math.Truncate(amount / 50));
            amount = amount % 50;
            amountAsChange.Fifties = fifties;
            Console.WriteLine("Fifties: " + amountAsChange.Fifties);

            //adds the 20s
            int twenties = Convert.ToInt32(Math.Truncate(amount / 20));
            amount = amount % 20;
            amountAsChange.Twenties = twenties;
            Console.WriteLine("Twenties: " + amountAsChange.Twenties);

            //adds the 10s
            int tens = Convert.ToInt32(Math.Truncate(amount / 10));
            amount = amount % 10;
            amountAsChange.Tens = tens;
            Console.WriteLine("Tens: " + amountAsChange.Tens);

            //adds the 5s
            int fives = Convert.ToInt32(Math.Truncate(amount / 5));
            amount = amount % 5;
            amountAsChange.Fives = fives;
            Console.WriteLine("Fives: " + amountAsChange.Fives);

            //adds the ones
            int ones = Convert.ToInt32(Math.Truncate(amount / 1));
            amount = amount % 1;
            amountAsChange.Ones = ones;
            Console.WriteLine("Ones: " + amountAsChange.Ones);




            //Calculates the number of quaters that can be returned for this amount
            int quarters =Convert.ToInt32(Math.Truncate((amount *100 / 25)));
            //deducts the quarters amount from the amount
            amount = amount % 0.25m;
            //adds the quarter to the structure
            amountAsChange.Quarters = Convert.ToInt32(quarters);
            Console.WriteLine("Quarters: " + amountAsChange.Quarters);
            //Calculates the number of dimes 

            int dimes = Convert.ToInt32(Math.Truncate(amount * 100/ 10));
            //deducts the dimes 
            amount = amount % 0.10m;
            //adds the dimes to the structure
            amountAsChange.Dimes = Convert.ToInt32(dimes);
            Console.WriteLine("Dimes: " + amountAsChange.Dimes);
            //calculates the number of nickels
            int nickels = Convert.ToInt32(Math.Truncate((amount*100 / 5)));
            //deducts the nickels
            amount = amount % 0.05m;
            //add the nickels to the structure
            amountAsChange.Nickles = Convert.ToInt32(nickels);
            Console.WriteLine("Nickels: " + amountAsChange.Nickles);
            //calculate the pennies
            decimal pennies = amount*100 ;
            //adds the pennies 
            amountAsChange.Pennies = Convert.ToInt32(pennies);
            Console.WriteLine("Pennies: " + amountAsChange.Pennies);

            //return our Change Object
            return amountAsChange;
        }

        /// <summary>
        /// Example using the Change class to store data
        /// </summary>
        public static Change Example(decimal amount)
        {
            //creating a new object of our class Change
            Change amountAsChange = new Change();

            //increasing the number of quarters
            amountAsChange.Quarters++;
            amountAsChange.Quarters += 1;
            amountAsChange.Quarters = amountAsChange.Quarters + 1;


            //outputting to the console
            Console.WriteLine("Quarters: " + amountAsChange.Quarters);

            //returning the object
            return amountAsChange;
        }

    }

    public class Change
    {

        

   
        /// <summary>
        /// This is the propierty to count 100 dollars
        /// </summary>
        public int Hundred {get; set;}

        /// <summary>
        /// This propierty count the 50s
        /// </summary>
        public int Fifties { get; set; }

        /// <summary>
        /// This propierty counts the 20s
        /// </summary>
        public int Twenties { get; set; }

        /// <summary>
        /// Propierty counts the 10s
        /// </summary>
        public int Tens { get; set; }

        /// <summary>
        /// Propierty counts the 5s
        /// </summary>
        public int Fives { get; set; }


        /// <summary>
        /// Propierty that counts the dollars
        /// </summary>
        public int Ones { get; set; }
        /// <summary>
        /// This is property to hold the number of Quarters to be returned as change
        /// </summary>

        public int Quarters { get; set; }

        /// <summary>
        /// This is property to hold the number of Dimes to be returned as change
        /// </summary>
        public int Dimes { get; set; }

        /// <summary>
        /// This is property to hold the number of Nickles to be returned as change
        /// </summary>
        public int Nickles { get; set; }

        /// <summary>
        /// This is property to hold the number of Pennies to be returned as change
        /// </summary>public int Nickles { get; set; }
        public int Pennies { get; set; }

        /// <summary>
        /// This is a constructor, it initializes a new instance of the class (called an object).  This sets it's default values.
        /// </summary>
        public Change()
        {
            this.Hundred = 0;
            this.Fifties = 0;
            this.Twenties = 0;
            this.Tens = 0;
            this.Fives = 0;
            this.Ones = 0;
            this.Quarters = 0;
            this.Dimes = 0;
            this.Nickles = 0;
            this.Pennies = 0;
        }
    }
}
