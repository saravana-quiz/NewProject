using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace File_System_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            string targetPath = @"D:\Assignment 09 Aug\source folder";
            string targetPath1 = @"D:\Assignment 09 Aug\source folder\target folder";
            string imgSourcePath1 = @"D:\Source Images";

            Directory.CreateDirectory(targetPath);
            Directory.CreateDirectory(targetPath1);

            string writeText = "Gislen Software The source text to copy";
            string writeText1 = "Duplicate The source text to copy";
            string txtPath1 = @"D:\Assignment 09 Aug\source folder\textfile1.txt";
            string txtPath2 = @"D:\Assignment 09 Aug\source folder\textfile2.txt";
            string targetTxtPath1 = @"D:\Assignment 09 Aug\source folder\target folder\copyOfFile1.txt";
            string imgTargetPath = @"D:\Assignment 09 Aug\source folder\target folder";
            File.WriteAllText(txtPath1, writeText);
            File.WriteAllText(txtPath2, writeText1);

            string[] filesText = Directory.GetFiles(targetPath);

            foreach (string filename in filesText)
            {                           
                var text = File.ReadAllText(filename);                
                if (Regex.IsMatch(filename, @"\.txt$") && text.Contains("Gislen Software"))
                {
                    File.Copy(filename, targetTxtPath1, true);
                }             
            }
            string[] imgFiles = Directory.GetFiles(imgSourcePath1);

            foreach (string filename in imgFiles)
            {
                FileInfo imagFiles = new FileInfo(filename);

                var file=Path.Combine(imgTargetPath,imagFiles.Name);

                if (Regex.IsMatch(filename, @"\.jpg$|\.png$|\.gif$") && imagFiles.Length <= 3e+6)
                {
                    File.Copy(filename, file);
                }

            }        
        }
    }
}
