using System;
using System.IO;

namespace ModuleClassWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the name of the file (without extension):");
            string fileName = Console.ReadLine();

            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filePath = Path.Combine(desktopPath, $"{fileName}.cs");

            Console.WriteLine($"Creating file: {filePath}");

            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    Console.WriteLine("Enter the content for the file (press Enter to finish):");

                    string line;
                    while ((line = Console.ReadLine()) != "")
                    {
                        writer.WriteLine(line);
                    }
                }

                Console.WriteLine("File created successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while creating the file: {ex.Message}");
            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
