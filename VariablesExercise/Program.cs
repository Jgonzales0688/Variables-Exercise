using System.Globalization;

namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            String myName = "Jessica Gonzales";
            int currYear = 2022;
            char midInital = 'M';
            bool inCollege = true;
            double yrsInCollege = 2.5;
            decimal rndmDecimal = 3.2546m;
            
            Console.WriteLine("My name is " + myName);
            Console.WriteLine("The year is " + currYear);
                Console.WriteLine("My middle initial is " + midInital);
            if (inCollege) {
                Console.WriteLine("I have been in college for " + yrsInCollege + " years.");
            }
                Console.WriteLine("This is my random decimal " + rndmDecimal);


                
        }
    }
}
