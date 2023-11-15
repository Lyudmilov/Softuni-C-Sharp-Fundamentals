using System;

namespace _4.PasswordValidator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //85/100

            string pass = Console.ReadLine();
            

                bool onlyLettersOrDigits = pass.All(char.IsLetterOrDigit);

            onlyLettersOrDigits = CorrectPassOrWrongLenght(pass, onlyLettersOrDigits);

            OnlyLettersOrDigits(onlyLettersOrDigits);

            LessThenTwoDigits(pass);
        }

        private static void LessThenTwoDigits(string pass)
        {
            if (pass.Count(char.IsDigit) < 2)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
        }

        private static void OnlyLettersOrDigits(bool onlyLettersOrDigits)
        {
            if (!onlyLettersOrDigits)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
        }

        private static bool CorrectPassOrWrongLenght(string pass, bool onlyLettersOrDigits)
        {
            if (pass.Length >= 6 && pass.Length <= 10)
            {
                if (onlyLettersOrDigits)
                {
                    if (onlyLettersOrDigits = pass.Count(char.IsDigit) >= 2)
                    {
                        Console.WriteLine("Password is valid");
                    }
                }
            }
            else
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }

            return onlyLettersOrDigits;
        }
    }
}