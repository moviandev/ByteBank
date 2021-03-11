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
    partial class Program
    {
        private static void HandlingFileStremDirectly()
        {
            var filePath = "contas.txt";

            using (var fileStream = new FileStream(filePath, FileMode.Open))
            {
                var buffer = new byte[1024];
                var readBytesQuantity = -1;

                while (readBytesQuantity != 0)
                {
                    readBytesQuantity = fileStream.Read(buffer, 0, 1024);
                    WriteBuffer(buffer, readBytesQuantity);
                }
            }
        }

        public static void WriteBuffer(byte[] buffer, int readBytes)
        {
            var utf8 = Encoding.Default;

            var text = utf8.GetString(buffer, 0, readBytes);

            Console.Write(text);

            //foreach (var myByte in buffer)
            //{
            //    Console.Write(myByte);
            //    Console.Write("  ");
            //}
        }
    }
}