using System;
using System.IO;

namespace ModuleClassWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            //take the input form the user related to file 
            Console.WriteLine("Enter the name of the file (without extension):");
            string fileName = Console.ReadLine();
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            //generate he filepath for the file which will be in the desktop folder and append the file to the path
            string filePath = Path.Combine(desktopPath, $"{fileName}.cs");
            Console.WriteLine($"Creating file: {filePath}");

            //Generat a new class file 
            FileGenerator newClassFile = new FileGenerator();
            newClassFile.GenerateFile(fileName, filePath);

          
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
