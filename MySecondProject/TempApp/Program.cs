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


// using System;
// using System.Security.Cryptography;

// namespace String_Chars
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             string textAge = "-23";
//             int age = Convert.ToInt32(textAge);
//             Console.WriteLine(age);

//             string textBigNumber = "-900000000";
//             long bigNumber = Convert.ToInt64(textBigNumber);
//             Console.WriteLine(bigNumber);

//             long bigNumber = -900000000L;
//             Console.WriteLine(bigNumber);

//             double negative = -55.2D;
//             string textNegative = "-55.2";
//             double negative = Convert.ToDouble(textNegative);
//             Console.WriteLine(negative);

//             float precision = 5.0000001F;
//             string textPrecision = "5.0000001";
//             float precision = Convert.ToSingle(textPrecision);
//             Console.WriteLine(precision);

//             string textMoney = "4.99";
//             decimal money = 4.99M;
//             decimal money = Convert.ToDecimal(textMoney);
//             Console.WriteLine(money);

//             Console.ReadLine();  

//             string phrase = "Giraffe Academy" + "is cool!";   

//             Console.WriteLine(phrase.IndexOf("Academy")); // GIRAFFE ACADEMYIS COOL!
//             Console.WriteLine(phrase.Substring(8, 3)); // GIRAFFE ACADEMYIS COOL!

//             Console.WriteLine(Math.Sqrt(36));
//             Console.WriteLine(Math.Max(6,10));
//             Console.WriteLine(Math.Min(6,10));

//             Console.WriteLine(Math.Round(4.6));


//             Console.WriteLine("hello world");

//             Console.Write("What is your name?: ");
//             string name = Console.ReadLine();
//             Console.WriteLine("Hello " + name);

//             int num = Convert.ToInt32("55rww");
//             Console.WriteLine(num + 5);

//             Console.Write("Enter a number: ");
//             double num1 = Convert.ToDouble(Console.ReadLine());
//             Console.Write("Enter another number: ");
//             double num2 = Convert.ToDouble(Console.ReadLine());
//             Console.WriteLine(num1 + num2);

//             Paused the program and we can see the output
//             Console.ReadLine();// This line waits for user to input something and paused the current execution of the problem

//             string color, pluralNoun, celebrity;

//             Console.Write("Write a color: ");
//             color = Console.ReadLine();

//             Console.Write("Write a plural noun:");
//             pluralNoun = Console.ReadLine();

//             Console.Write("Write a celebrity:");
//             celebrity = Console.ReadLine();

//             Console.WriteLine("Roses are " + color);
//             Console.WriteLine(pluralNoun + " are blue");
//             Console.WriteLine("I love you " + celebrity);
//             Console.ReadLine();

//             int [] luckyNumber = {4, 3, 6, 7, 4};
//             string[] friends = new string[5];
//             friends[0] = "Jim";
//             friends[1] = "Karen";

//             Console.WriteLine(friends[1]);
//             Console.ReadLine();
//         }
//     }
// }



// using System;

// namespace Giraffe
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             SayHi("Mike", 23);
//             SayHi("John", 45);
//             SayHi("Tom", 67);
//             Console.ReadLine();
//         }

//         static void SayHi(string name, int age)
//         {
//             Console.WriteLine("Hello user " + name + " You are " + age);
//         }
//     }
// }



// Return statements
// using System;

// namespace Giraffe
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int cubeNumber = cube(5);
//             Console.WriteLine(cubeNumber);
//             Console.WriteLine("Hello");
//             Console.ReadLine();
//         }

//         static int cube(int num)
//         {
//             int result = num * num * num;
//             return result;
//         }
//     }
// }