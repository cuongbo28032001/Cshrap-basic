using System;
using System.IO;
namespace CopyFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourceFile = @"E:\C#\BT\inClass\HinhChuNhat\CopyFile\source\source.txt";
            string targetFile = @"E:\C#\BT\inClass\HinhChuNhat\CopyFile\target\target.txt";
            //CopyFileUseFileClass(sourceFile, targetFile);
            CopyFileWithStream(sourceFile, targetFile);
        }

        static void CopyFileWithStream(string source, string target)
        {
            var inputStream = new StreamReader(source);
            var outputStream = new StreamWriter(target, append: false);
            try
            {
                string line = "";
                while ((line = inputStream.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                    outputStream.WriteLine(line);
                }
                //outputStream.Write(inputStream.ReadToEnd());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        static void CopyFileUseFileClass(string source, string target)
        {
            try
            {
                File.Copy(source, target, true);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
