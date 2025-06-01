using Microsoft.VisualBasic;
using System.ComponentModel;
using System.Globalization;
using System.Numerics;
using System.Security.Cryptography;

namespace Syntaxia.MathTesterWithScore
{
    internal class Program
    {
        private static Random random = new Random();

        static void Main(string[] args)
        {
            Console.Write("Please Enter Your Name : "); string userName = Console.ReadLine();

            int userScore = 0;
            bool Continue = true;
            while (Continue)
            {
                string answer = CreateRandomOperation(GetRandomNumber(), GetRandomNumber());

                if (answer == "correct")
                    userScore += 1;
                else if (answer == "wrong")
                    userScore -= 1;

                Console.Write("Continue ? (y/n) : "); string continueAnswer = Console.ReadLine();
                if (continueAnswer == "n")
                    Continue = false;
            }
            Console.WriteLine($"\nYour Final Score is {userScore}\n");

        }

        public static double GetRandomNumber()
        {
            double number = random.Next(12);
            return number;
        }





        private static string CreateRandomOperation(double number1, double number2)
        {
            List<string> Operators = new List<string>();
            Operators.Add("+");
            Operators.Add("-");
            Operators.Add("*");
            Operators.Add("/");

            int randomIndex = random.Next(0, Operators.Count - 1);

            string selectedOperator = Operators[randomIndex];


            if (selectedOperator == "+")
            {
                var correctAnswer = number1 + number2;
                Console.Write($"{number1} + {number2} = ? "); int userAnswer = int.Parse(Console.ReadLine());
                if (userAnswer == correctAnswer)
                {
                    string msg = $"Correct Answer";
                    Console.WriteLine(msg);
                    string answer = "correct";
                    return answer;
                }
                else
                {
                    string msg = $"Wrong Answer";
                    Console.WriteLine(msg);
                    string answer = "wrong";
                    return answer;
                }
            }
            else if (selectedOperator == "-")
            {
                var correctAnswer = number1 - number2;
                Console.Write($"{number1} - {number2} = ? "); int userAnswer = int.Parse(Console.ReadLine());
                if (userAnswer == correctAnswer)
                {
                    string msg = $"Correct Answer";
                    Console.WriteLine(msg);
                    string answer = "correct";
                    return answer;
                }
                else
                {
                    string msg = $"Wrong Answer";
                    Console.WriteLine(msg);
                    string answer = "wrong";
                    return answer;
                }
            }
            else if (selectedOperator == "*")
            {
                var correctAnswer = number1 * number2;
                Console.Write($"{number1} * {number2} = ? "); int userAnswer = int.Parse(Console.ReadLine());
                if (userAnswer == correctAnswer)
                {
                    string msg = $"Correct Answer";
                    Console.WriteLine(msg);
                    string answer = "correct";
                    return answer;
                }
                else
                {
                    string msg = $"Wrong Answer";
                    Console.WriteLine(msg);
                    string answer = "wrong";
                    return answer;
                }
            }
            else if (selectedOperator == "/")
            {
                var correctAnswer = number1 + number2;
                Console.Write($"{number1} + {number2} = ? "); int userAnswer = int.Parse(Console.ReadLine());
                if (userAnswer == correctAnswer)
                {
                    string msg = $"Correct Answer";
                    Console.WriteLine(msg);
                    string answer = "correct";
                    return answer;
                }
                else
                {
                    string msg = $"Wrong Answer";
                    Console.WriteLine(msg);
                    string answer = "wrong";
                    return answer;
                }
            }
            return "Done";

        }
    }

}
