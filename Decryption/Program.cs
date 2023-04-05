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
            using (var sr = new StreamReader("A:/Visual Studio 2022/C#/Decryption/Decryption/prime.txt"))
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
                    Console.WriteLine($"guess: {guess}");
                    
                }
                if ((key / guess) % 1 != 0)
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