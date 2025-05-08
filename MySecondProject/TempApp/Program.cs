// namespace String_Chars
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             string name = "a";
//             char letter = '\0';

//             Console.Write("Your name is: ");
//             Console.Write(name);

//             Console.WriteLine();

//             Console.WriteLine(letter);

//         }
//     }
// }


using System;
using System.Security.Cryptography;

namespace String_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            // string textAge = "-23";
            // int age = Convert.ToInt32(textAge);
            // Console.WriteLine(age);

            // string textBigNumber = "-900000000";
            // long bigNumber = Convert.ToInt64(textBigNumber);
            // Console.WriteLine(bigNumber);

            // long bigNumber = -900000000L;
            // Console.WriteLine(bigNumber);

            // double negative = -55.2D;
            // string textNegative = "-55.2";
            // double negative = Convert.ToDouble(textNegative);
            // Console.WriteLine(negative);

            // float precision = 5.0000001F;
            // string textPrecision = "5.0000001";
            // float precision = Convert.ToSingle(textPrecision);
            // Console.WriteLine(precision);

            // string textMoney = "4.99";
            // decimal money = 4.99M;
            // decimal money = Convert.ToDecimal(textMoney);
            // Console.WriteLine(money);

            // Console.ReadLine();  

            // string phrase = "Giraffe Academy" + "is cool!";   

            // Console.WriteLine(phrase.IndexOf("Academy")); // GIRAFFE ACADEMYIS COOL!
            // Console.WriteLine(phrase.Substring(8, 3)); // GIRAFFE ACADEMYIS COOL!

            // Console.WriteLine(Math.Sqrt(36));
            // Console.WriteLine(Math.Max(6,10));
            // Console.WriteLine(Math.Min(6,10));

            // Console.WriteLine(Math.Round(4.6));


            // Console.WriteLine("hello world");

            Console.Write("What is your name?: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name);

            // Paused the program and we can see the output
            Console.ReadLine();// This line waits for user to input something and paused the current execution of the problem
        }
    }
}