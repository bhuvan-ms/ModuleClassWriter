using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleClassWriter
{
    public class ContentWriter
    {
        public void WriteContents(string nameSpace, string filePath, string fileName)
        {
            try
            {
                //take the input form the user that should be in the file
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    //scan and get the namespace
                    string[] parts = nameSpace.Split('.');
                    string projLib = parts[0];

                    //logic to write files ATM

                    //using files section
                    string newFile = $"using System;using System.Data;using Framework.DB;using {projLib}.Classes.ADM;using System.Globalization;using System.Data.SqlClient;using System.Linq;using System.Collections;using System.Collections.Generic;";
                    string formattedFile = newFile.Replace(";", ";" + Environment.NewLine);
                    writer.WriteLine(formattedFile);

                    //space
                    writer.WriteLine("");

                    //method section
                    writer.WriteLine($"namespace {nameSpace}");
                    writer.WriteLine("{");
                    writer.WriteLine($"\t public class {fileName}");
                    writer.WriteLine("\t{");
                    //more methods to be added here
                    writer.WriteLine("\t}");
                    writer.WriteLine("}");

                }

                Console.WriteLine("File created successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while creating the file: {ex.Message}");
            }
        }
    }
}
