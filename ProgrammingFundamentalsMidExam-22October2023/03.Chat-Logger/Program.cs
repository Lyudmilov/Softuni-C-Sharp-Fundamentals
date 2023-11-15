using Microsoft.VisualBasic;
using System;

namespace _03.Chat_Logger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* "Chat {message}"

               o "Delete {message}"

               o "Edit {message} {editedVersion}"

               o "Pin {message}"

               o "Spam {message1} {message2} {messageN}"

               o "end"
            */
            /*
              Chat Hello                
              Chat darling                
              Edit darling Darling                
              Spam how are you                
              Delete Darling                
              end
            */

            List<string> logFile = new List<string>();
            string commands = string.Empty;

            while ((commands = Console.ReadLine()) != "end")
            {
                List<string> input = commands.Split().ToList();
                //string input[0] = input[0];
                //string input[1] = input[1];

                if (input[0] == "Chat")
                {
                    logFile.Add(input[1]);
                }
                else if (input[0] == "Delete")
                {
                    if (logFile.Contains(input[1]))
                    {
                        logFile.Remove(input[1]);
                    }
                }
                else if (input[0] == "Edit")
                {
                    /*if (logFile.Contains(message))
                    {
                        string editedMes = input[2];
                        var indexOfTheMessage = logFile.FindIndex(x => x.Contains(message));
                        logFile.RemoveAt(indexOfTheMessage);
                        logFile.Insert(indexOfTheMessage, editedMes);
                    }*/
                    int index = logFile.IndexOf(input[1]);
                    if (index != -1)
                    {
                        logFile[index] = input[2];
                    }
                }
                else if (input[0] == "Pin")
                {
                    /*if (logFile.Contains(message))
                    {
                        var indexOfTheMessage = logFile.FindIndex(x => x.Contains(message));
                        logFile.RemoveAt(indexOfTheMessage);
                        logFile.Add(message);
                    }*/
                    int index = logFile.IndexOf(input[1]);
                    if (index != -1)
                    {
                        logFile.RemoveAt(index);
                        logFile.Add(input[1]);
                    }
                }
                else if (input[0] == "Spam")
                {
                    /* foreach (string words in logFile)
                     {
                         logFile.Add(message);
                     }*/
                    for (int i = 1; i < input.Count; i++)
                    {
                        logFile.Add(input[i]);
                    }
                }
            }

            foreach (string str in logFile)
            {
                Console.WriteLine(str);
            }
        }
    }
}