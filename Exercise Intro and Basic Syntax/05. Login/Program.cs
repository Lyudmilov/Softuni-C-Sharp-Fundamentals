using System.Diagnostics.Metrics;

namespace _05._Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             5. Login
             On the first line, you will be given a username and your task is to try to log in the user. 
             The user's password is the username reversed. On the next lines, you will receive passwords:
             • If the password is incorrect, print "Incorrect password. Try again.".
             • If the password is correct, print "User {username} logged in." and stop the program.
             Keep in mind that if the password is still incorrect on the fourth attempt, you should print: 
             "User {username} blocked!".
             Then the program stops.

             Examples
             Input      Output
             Acer
             login
             go
             let me in
             recA
                        Incorrect password. Try again.
                        Incorrect password. Try again.
                        Incorrect password. Try again.
                        User Acer logged in.
             momo
             omom
                        User momo logged in.
             sunny
             rainy
             cloudy
             sunny
             not sunny
                        Incorrect password. Try again.
                        Incorrect password. Try again.
                        Incorrect password. Try again.
                        User sunny blocked! 
             */

            string username = Console.ReadLine();
            string input = Console.ReadLine();
            string result = "";
            string reversedUsername = "";
            int counter = 0;

            for (int i = username.Length - 1; i >= 0; i--)
            {
                reversedUsername += username[i];
            }
            while (true)
            {
                for (int i = input.Length - 1; i >= 0; i--)
                {
                    result += input[i];
                }
                if (result == reversedUsername)
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }
                else
                {
                    if (counter > 3)
                    {
                        Console.WriteLine($"User {username} blocked!");
                        break;
                    }
                    Console.WriteLine("Incorrect password. Try again.");
                    counter++;
                }
                    input = Console.ReadLine();
                result = "";
            }
        }
    }
}