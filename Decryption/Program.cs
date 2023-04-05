/*
Hello this is my decryption project. It is mainly for educational purposes in which it shows the basics of decrypting a asymetric encryption key 
 */
using System;
namespace code
{
    public class Program
    {
        static void Main(string[] args)
        {
            string prime = "------------------- Prime Numbers -------------------";
            Console.SetCursorPosition((Console.WindowWidth - prime.Length) / 2, Console.CursorTop);
            Console.WriteLine(prime);
            Console.WriteLine("");
            Console.WriteLine("Please enter a key: ");
            string key = Console.ReadLine();
            double keyInt = Convert.ToDouble(key);
            double guess = 1;
            while (true)
            {
                if ((keyInt / guess) % 1 == 0 && guess < keyInt)
                {
                    guess = guess + 1;
                    Console.WriteLine($"guess: {guess}");
                    
                }
                if ((keyInt / guess) % 1 != 0)
                {
                    Console.WriteLine(guess);
                    break;
                }
            }
        }
        void exponent(double guess)
        {
            Console.WriteLine(guess);
        }
    }
}