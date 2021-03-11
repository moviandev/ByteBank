using System;
using System.Collections.Generic;
using System.Linq;
using ByteBank.Modelos;
using ByteBank.SistemaAgencia.Comparers;
using ByteBank.SistemaAgencia.Extensoes;
using System.IO;
using System.Text;

namespace ByteBank.SistemaAgencia
{
    public static partial class Program
    {
        public static void CreateFile()
        {
            var newFilePath = "exportedAccount.csv";

            using (var streamFile = new FileStream(newFilePath, FileMode.Create))
            {
                var accountAsString = "333,33333,4445.4,Gustavo Santos";
                var enconding = Encoding.UTF8;

                var bytes = enconding.GetBytes(accountAsString);

                streamFile.Write(bytes, 0, bytes.Length);
            }
        }

        public static void CreateFileWithWriter()
        {
            var newFilePath = "exportedAccounts.csv";

            using (var fileStream = new FileStream(newFilePath, FileMode.Create))
            using (var writer = new StreamWriter(fileStream))
            {
                writer.Write("333,3333,3333.22,Pedro Silva", Encoding.UTF8);
            }
        }

        private static void WriteTest()
        {
            var filePath = "test.txt";

            using (var fileStream = new FileStream(filePath, FileMode.Create))
            using (var writer = new StreamWriter(fileStream))
            {
                for (int i = 0; i < 10000000; i++)
                {
                    writer.WriteLine($"Line {i}");
                    writer.Flush();
                    Console.WriteLine($"line {i} has been written");
                    Console.ReadLine();
                }
            }
        }
    }
}