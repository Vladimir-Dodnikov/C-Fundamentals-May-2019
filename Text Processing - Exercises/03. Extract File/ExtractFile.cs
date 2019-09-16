using System;
using System.Linq;

namespace _03._Extract_File
{
    class Program
    {
        static void Main()
        {
            //string[] path = Console.ReadLine()
            //    .Split(@"\");

            //string[] lastItem = path
            //    .Last()
            //    .Split(".");

            //Console.WriteLine($"File name: {lastItem[0]}");
            //Console.WriteLine($"File extension: {lastItem[1]}");

            string filePath = Console.ReadLine();

            int fileNameStartIndex = filePath.LastIndexOf('\\') + 1;
            int dotIndex = filePath.LastIndexOf('.');

            string fileName = filePath.Substring(fileNameStartIndex, dotIndex - fileNameStartIndex);
            string extentsion = filePath.Substring(dotIndex + 1);

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {extentsion}");
        }
    }
}
