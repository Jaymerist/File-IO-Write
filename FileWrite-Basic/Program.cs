/*
       Purpose:   Demonstrate how to write/create a file    
         Input:   name      
        Output:   StudentsList.txt    
    Written By:   Mihiri Kamiss
 Last Modified:   Oct 7
 */

//add the following namespace for reading/writing from/to a file
using System.IO;
namespace FileWrite_Basic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declare variables
            const string FileAndPath = @"C:\Users\mkamiss1.NAIT\Documents\C3\File-IO-main\StudentList.txt";
            string name;

            // 1. Create a StreamWriter
            StreamWriter writer = null;
            // 2. Use a try-catch-finally
            try
            {
                // 3. Initialize the StreamWriter
                writer =  File.CreateText(FileAndPath);
                // 4. Prompt for a name, or zzz to exit
                Console.Write("Enter a name or zzz to quit: ");
                name = Console.ReadLine();
                // 5. Loop while name is not "zzz"
                while (!name.ToLower().Equals("zzz"))
                {
                    // 6. Write the name to the file
                    writer.WriteLine(name);
                    // 7. Re-prompt for the name of zzz to exit
                    //    Do not write the "zzz" value to the file!
                    Console.Write("Enter a name or zzz to quit: ");
                    name = Console.ReadLine();
                }
            }
            catch (Exception ex)
            {
                // 8. Display the exception message if it occurs
                Console.WriteLine(ex.Message);
            }
            finally
            {
                // 9. Close the StreamWriter
                writer.Close();
            }
            Console.ReadLine();
        }
    }
}