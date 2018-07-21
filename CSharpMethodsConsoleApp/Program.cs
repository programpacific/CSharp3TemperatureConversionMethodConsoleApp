using System;


namespace CSharpMethodsConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Welcome To The Temperature Conversion Tool");
                Console.WriteLine();
                Console.WriteLine("This tool will convert your *F value into");
                Console.WriteLine("Celsius, Kelvin, and Rankine! ");
                Console.WriteLine();
                Console.WriteLine("What would you like to convert?");
                double temperature = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                CelciusConversion sq = new CelciusConversion();
                Console.WriteLine("Your temperature in Celsius is: " + sq.Celcius(temperature));

                KelvinConversion su = new KelvinConversion();
                Console.WriteLine("Your temperature in Kelvin is: " + su.Kelvin(temperature));

                RankineConversion st = new RankineConversion();
                Console.WriteLine("Your temperature in Rankine is: " + st.Rankine(temperature));
                Console.WriteLine();

                Console.WriteLine("Thank you for using my tool! Press enter to exit.");
            }
                        
            catch (FormatException ex)
            {
                Console.WriteLine();
                Console.WriteLine("I'm sorry but that is not a valid number, please try again.");
                Console.WriteLine("Press enter to exit");
                return;
            }
            catch (OverflowException ex)
            {
                Console.WriteLine();
                Console.WriteLine("I'm sorry but that is too large a number for me to calculate, please try again.");
                Console.WriteLine("My operating parameters are -999999999 to 999999999");
                Console.WriteLine("Press enter to exit");
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
