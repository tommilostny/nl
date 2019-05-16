using System;

namespace nl
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                if (args[0] == "/?") Console.WriteLine("Help page for the nl command.");
                else Console.WriteLine("Use \"nl /?\" to display the help page.");
            }
            catch (IndexOutOfRangeException)
            {
                string line;
                for (int i = 1; (line = Console.ReadLine()) != null; i++)
                {
                    line = i.ToString() + "   " + line;
                    for (int y = 0; y < 6 - i.ToString().Length; y++) line = " " + line;
                    Console.WriteLine(line);
                }
            }
        }
    }
}