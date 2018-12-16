using System;
using System.IO;

namespace 创建一个二进制文件
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "1.dat";
            FileStream fsw = File.Create(fileName);
            byte[] bts = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            // fs.Write(bts, 0, bts.Length);
            // fs.Flush();

            BinaryWriter binaryWriter = new BinaryWriter(fsw);
            for (var i = 0; i < bts.Length; i++)
            {
                binaryWriter.Write(i);
            }
            binaryWriter.Close();
            fsw.Close();

            FileStream fsr = File.OpenRead(fileName);
            BinaryReader binaryReader = new BinaryReader(fsr);
            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine(binaryReader.ReadChar());
            }
            binaryReader.Close();
            fsr.Close();
        }
    }
}
