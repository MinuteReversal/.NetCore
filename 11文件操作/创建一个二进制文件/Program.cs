using System;
using System.IO;

namespace 创建一个二进制文件
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "1.dat";
            char[] bts = { 'h', 'e', 'l', 'l', 'o' };
            FileStream fsw = File.Create(fileName);
            BinaryWriter binaryWriter = new BinaryWriter(fsw);
            for (var i = 0; i < bts.Length; i++)
            {
                binaryWriter.Write(bts[i]);
            }
            binaryWriter.Close();
            fsw.Close();

            FileStream fsr = File.OpenRead(fileName);
            BinaryReader binaryReader = new BinaryReader(fsr);
            for (var i = 0; i < bts.Length; i++)
            {
                Console.Write(binaryReader.ReadChar());
            }
            binaryReader.Close();
            fsr.Close();
        }
    }
}
