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



// Learning Return statements
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


// Learning If statements

// using System;
// using System.ComponentModel;
// using System.Runtime.CompilerServices;

// namespace Giraffe
// {
//     class Program
//     {
//         // static void Main(string[] args)
//         // {
//         //     bool isMale = true;
//         //     bool isTall = false;

//         //     if(isMale && isTall)
//         //     {
//         //         Console.WriteLine("You are a tall Male");
//         //     } else if(isMale && !isTall)
//         //     {
//         //         Console.WriteLine("You are Male but not tall");
//         //     } else
//         //     {
//         //         Console.WriteLine("You are not male and also not tall");
//         //     }

//         //     Console.ReadLine();
//         // }

//         // static void Main(string[] args)
//         // {
//         //     Console.WriteLine(GetMax(50, 40, 20));
//         //     Console.ReadLine();
//         // }

//         // static int GetMax(int num1, int num2, int num3)
//         // {
//         //     int result;
//         //     if(num1 > num2 && num1 > num3)
//         //     {
//         //         result = num1;
//         //     }
//         //     else if(num2 > num1 && num2 > num3)
//         //     {
//         //         result = num2;
//         //     }
//         //     else
//         //     {
//         //         result = num3;
//         //     }
//         //     return result;
//         // }
//     }
// }

// using System;

// namespace YouTubeTutorials
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Enter a number: ");
//             double num1 = Convert.ToDouble(Console.ReadLine());

//             Console.WriteLine("Enter the operator: ");
//             string op = Console.ReadLine();

//             Console.WriteLine("Enter another operator: ");
//             double num2 = Convert.ToDouble(Console.ReadLine());

//             if(op == "+")
//             {
//                 Console.WriteLine(num1 + num2);
//             }
//             else if(op == "-")
//             {
//                 Console.WriteLine(num1 - num2);
//             }
//             else if(op == "*")
//             {
//                 Console.WriteLine(num1 * num2);
//             }
//             else if(op == "/")
//             {
//                 Console.WriteLine(num1 / num2);
//             }
//             else
//             {
//                 Console.WriteLine("Invalid operator");
//             }
//             Console.ReadLine();
//         }
//     }
// };


// Learning Switch statements
// using System;

// namespace Youtube
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             // 0 --> "Sunday
//             // 1 --> "Monday"
//             // 2 --> "Tuesday"

//             Console.WriteLine("Enter a number between 0 and 6: ");
//             int dayNum = Convert.ToInt32(Console.ReadLine());
//             string dayName = GetDay(dayNum);
//             Console.WriteLine("The day is: " + dayName);
//             Console.ReadLine();
//         }

//         static string GetDay(int dayNum)
//         {
//             string dayName;
            
//             switch(dayNum)
//             {
//                 case 0: 
//                    dayName = "Sunday";
//                    break;
//                 case 1:
//                    dayName = "Monday";
//                    break;
//                 case 2:
//                    dayName = "Tuesday";
//                    break;
//                 case 3:
//                    dayName = "Wednesday";
//                    break;
//                 case 4:
//                    dayName = "Thursday";
//                    break;
//                 case 5:
//                    dayName = "Friday";
//                    break;
//                 case 6:
//                    dayName = "Saturday";
//                    break;
//                 default:
//                   dayName = "Invalid day number";
//                   break;
//             }
//             return dayName;
//         }
//     }
// }

// Learning while loops

// using System;

// namespace YoutubeTutorials
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int index = 7;
//             // while(index <= 6)
//             // {
//             //     Console.WriteLine(index);
//             //     index++;
//             // }
//             do
//             {
//                 Console.WriteLine(index);
//                 index++;
//             } while(index <= 6);

//             Console.ReadLine();
//         }
//     }
// }


// Build a guessing game

// using System;

// namespace YoutubeTutorials
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             string secretWord = "giraffe";
//             string guess = "";
//             bool outOfGuesses = false;
//             int guessCount = 0;
//             int guessLimit = 3;
//             while(guess != secretWord && !outOfGuesses)
//             {
//                 if(guessCount < guessLimit)
//                 {
//                     Console.Write("Enter your guess: ");
//                     guess = Console.ReadLine();
//                     guessCount++;
//                 } else {
//                     outOfGuesses = true;
//                 }
//             }
//             if(outOfGuesses)
//             {
//                 Console.WriteLine("You lose!");
//             }
//             else
//             {
//                 Console.WriteLine("You guessed it!");
//             }
//             Console.ReadLine();
//         }
//     }
// }

// Using for loops

// using System;

// namespace YoutubeTutorials
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int[] luckyNumber = {4, 5, 3, 7, 2};
//             for(int i = 0; i < luckyNumber.Length; i++) {
//                 Console.WriteLine(luckyNumber[i]);
//             }
//             Console.ReadLine();
//         }
//     }
// }

using System;

namespace YoutubeTutorials
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetPower(3, 2));
            Console.ReadLine();
        }

        static int GetPower(int baseNum, int PowerNum)
        {
            int result = 1;
            for(int i = 0; i < PowerNum; i++)
            {
                result *= baseNum;
            }

            return result;
        }
    }
}