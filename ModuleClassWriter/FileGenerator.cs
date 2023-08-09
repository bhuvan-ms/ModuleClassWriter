using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleClassWriter
{
    public class FileGenerator
    {
        //will consist of logic realted to file generation and inputs to be written in the file
        public void GenerateFile(string fileName, string filePath)
        {
            //ask questions to the user regarding the file library, namespace and properties and their types
            Console.WriteLine("Enter the namespace of the project for example Srishti.Classes.QuestionPassage (the class file is inside the QuestionPassage folder)");
            Console.WriteLine("Warning: Entering wrong namespace may result in errors");
            string nameSpace = Console.ReadLine();

            ContentWriter userContet = new ContentWriter();
            userContet.WriteContents( nameSpace, filePath, fileName);
        }
    }
}
