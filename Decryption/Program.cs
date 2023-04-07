/*
Hello this is my decryption project. It is mainly for educational purposes in which it shows the basics of decrypting a asymetric encryption key 
 */
using System;
using ConsoleTables;
using MathyInt = System.Int64;
namespace code
{
    public class Program
    {
        static void Main(string[] args)
        {
            string prime = "------------------- Prime Numbers -------------------";
            Console.SetCursorPosition((Console.WindowWidth - prime.Length) / 2, Console.CursorTop);
            Console.WriteLine(prime);
            using (var sr = new StreamReader("C:/Users/harry/source/repos/Decryption/Decryption/PrimeNumbers.txt"))
            {
                Console.WriteLine(sr.ReadToEnd());
            }
            Console.WriteLine("");
            Console.WriteLine("Please enter a first prime number: ");
            string prime_1 = Console.ReadLine();
            Console.WriteLine("Please enter a second prime number: ");
            string prime_2 = Console.ReadLine();
            double prime_1_double = Convert.ToDouble(prime_1);
            double prime_2_double = Convert.ToDouble(prime_2);
            double key = prime_1_double * prime_2_double;
            Console.WriteLine($"Your private key is: {prime_1_double} x {prime_2_double}\nYour public key is: {key}");
            double guess = 1;
            while (true)
            {
                if ((key / guess) % 1 == 0 && guess < key)
                {
                    guess = guess + 1;                  
                }
                if ((key / guess) % 1 != 0)
                {
                    Console.WriteLine($"Guess: {guess}");
                    break;
                }
            }
            // Mathematics part
            double x = 1;
            var table = new ConsoleTable($"g^x", $"Result", $"g^x / {key}", $"Remainder");
            while (true)
            {
                int Intkey = Convert.ToInt32(key);
                double doubleDividend = Math.Pow(guess, x);
                int dividend = Convert.ToInt32(doubleDividend);
                int quotient = dividend / Intkey;
                int remainder = dividend % Intkey;                
                table.AddRow($"{guess}^{x}", $"{dividend}", $"{quotient}", $"{remainder}");                
                if (remainder == 1)
                {
                    break;
                }
                x++;
            }
            table.Write();
            Console.WriteLine($"Exponent: {x}");
            double calculatation_quotient = Math.Pow(guess, x / 2) + 1;
            // euclids algorithm
            int intkey = Convert.ToInt32(key);
            int calculation_quotient_int = Convert.ToInt32(calculatation_quotient);
            int numerator = calculation_quotient_int;
            int denominator = intkey;
            var table_euclid = new ConsoleTable($"Numerator", $"Denominator", $"Result", $"Remainder");
            while (true)
            {
                int remainder_euclid = numerator % denominator;
                int devide_euclid = numerator / denominator;
                table_euclid.AddRow($"{numerator}", $"{denominator}", $"{devide_euclid}", $"{remainder_euclid}");
                numerator = denominator;
                denominator = remainder_euclid;
                
                if (remainder_euclid == 0)
                {
                    Console.WriteLine(denominator);
                    break;
                }
            }
            table_euclid.Write();
            Console.WriteLine($"The private key is: {numerator} x " + key / numerator);
        }
    }
}