using System;
using System.IO;

namespace TepTin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            WriterDemo("TaiLieu.txt");
            Convert_txt("TaiLieu.txt");
        }

        static void WriterDemo(string fileName)
        {
            StreamWriter sw = new StreamWriter(fileName, false);
            sw.WriteLine("Doan Quoc Cường");
            sw.WriteLine("Sinh vien cua co Nga");
            sw.Close();
        }
        static void ReaderDemo(string fileName)
                {
                    string a = File.ReadAllText(fileName);
                    Console.WriteLine(a);
                }
        static void Convert_txt(string fileName)
        {
            try
            {
                int count = 0;
                StreamReader sw = new StreamReader(fileName);
                StreamWriter sw1 = new StreamWriter("TaiLieu1.txt");
                string line = "";
                while ((line = sw.ReadLine()) != null)
                {
                    sw1.WriteLine(line.ToUpper());
                    string[] worlds = line.Split(' ');
                    count += worlds.Length;
                }
                sw1.WriteLine(count);
                sw1.Close();
                sw.Close();

            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("Sai đường dẫn file cần đọc");
            }
            Console.WriteLine("file khởi tao ban đầu: ");
            ReaderDemo("TaiLieu.txt");
            Console.WriteLine("file sau chuyển chữ hoa: ");
            ReaderDemo("TaiLieu1.txt");
        }
        
    }
}
