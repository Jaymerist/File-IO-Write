namespace WriteNewCourses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declare variables
            const string FileAndPath = @"C:\Users\mkamiss1.NAIT\source\repos\WriteNewCourses\NewCourses.csv";
            // 1. Create a StreamWriter
            StreamWriter writer = null;
            try
            {
                //initializse streamwriter
                writer = File.CreateText(FileAndPath);
                string courseID,
                    output,
                    courseName = String.Empty;
                double credits;
                int count = 0;

                //prompt for courseID or zzz to quit

                Console.Write("Input courseID or zzz to quit: ");
                courseID = Console.ReadLine();

                //if courseID != zzz then prompt for name and credits
                if (!courseID.ToLower().Equals("zzz"))
                {
                    Console.Write("Enter the course name: ");
                    courseName = Console.ReadLine();
                    Console.Write("Enter the number of credits: ");
                    credits = double.Parse(Console.ReadLine());
                }
                else
                {
                    credits = 0;
                }

                //loop while last name is not zzz
                while (!courseID.ToLower().Equals("zzz"))
                {
                    //write to file in a format
                    output = String.Format("{0},{1},{2}", courseID, courseName, credits);

                    //write output string to file
                    writer.WriteLine(output);
                    count++;

                    //reprompt for courseID or zzz to quit
                    Console.Write("Input courseID or zzz to quit: ");
                    courseID = Console.ReadLine();
                    //if courseID != zzz prompt for name and credits
                    if (!courseID.ToLower().Equals("zzz"))
                    {
                        Console.Write("Enter the course name: ");
                        courseName = Console.ReadLine();
                        Console.Write("Enter the number of credits: ");
                        credits = double.Parse(Console.ReadLine());
                    }

                }
                Console.WriteLine($"\n{count} lines written to {FileAndPath}");
            }
            catch (Exception ex)
            {
                //display exception message
                Console.WriteLine(ex.Message);
            }
            finally
            {
                writer.Close();
            }

            Console.ReadLine();
        }
    }
}