/*
       Purpose:   Demonstrate how to write/create a file    
         Input:   name      
        Output:   StudentData.csv  
    Written By:   Mihiri Kamiss
 Last Modified:   Oct 7
 */

//add the following namespace for reading/writing from/to a file
using System;
using System.IO;
using System.Xml.Linq;

namespace FileWrite_Medium
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declare variables
            const string FileAndPath = @"C:\Users\mkamiss1.NAIT\Documents\C3\File-IO-main\StudentData.csv";
            // 1. Create a StreamWriter
            StreamWriter writer = null;
            // 2. Use a try-catch-finally
            try
            {
                // 3. Initialize the StreamWriter
                writer = File.CreateText(FileAndPath);
                string lastName,
                    firstName = String.Empty,
                    output;
                int mark,
                    count = 0;

                // 4. Prompt for lastname or zzz to quit

                Console.Write("Enter a last name or zzz to quit: ");
                lastName = Console.ReadLine();

                // 5. If last name is not zzz, then prompt for firstname and mark
                if (!lastName.ToLower().Equals("zzz"))
                {
                    Console.Write("Enter a first name: ");
                    firstName = Console.ReadLine();
                    Console.Write("Enter student mark: ");
                    mark = int.Parse(Console.ReadLine());
                }
                else
                {
                    mark = 0;
                }

                // 6. Loop while lastname is not zzz
                while (!lastName.ToLower().Equals("zzz"))
                {
                    // 7. Create an output string to write to the file
                    output = String.Format("{0},{1},{2}", lastName, firstName, mark);

                    // 8. Write the output string to the file
                    writer.WriteLine(output);
                    count++;

                    // 9. Reprompt for last name or zzz to quit

                    Console.Write("Enter a last name or zzz to quit: ");
                    lastName = Console.ReadLine();

                    // 10. if lastname is not zzz, then prompt for firstname and mark
                    if (!lastName.ToLower().Equals("zzz"))
                    {
                        Console.Write("Enter a first name: ");
                        firstName = Console.ReadLine();
                        Console.Write("Enter student mark: ");
                        mark = int.Parse(Console.ReadLine());
                    }

                }
                Console.WriteLine($"\n{count} lines written to {FileAndPath}");

            }
            catch (Exception ex)
            {
                // 11. Display the exception message if it occurs
                Console.WriteLine(ex.Message);
            }
            finally
            {
                // 12. Close the StreamWriter
                writer.Close();
            }

            Console.ReadLine();
        }
    }
}