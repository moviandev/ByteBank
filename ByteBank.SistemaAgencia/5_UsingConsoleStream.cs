using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    public static partial class Program
    {
        private static void UsingInputStream()
        {
            using (var inputStream = Console.OpenStandardInput())
            using (var fs = new FileStream("consoleInput.txt", FileMode.Create))
            {
                var buffer = new byte[1024];
                while (true)
                {
                    var readBytes = inputStream.Read(buffer, 0, 1024);
                    fs.Read(buffer, 0, readBytes);
                    fs.Flush();
                    Console.WriteLine($"Read byte in Console: {readBytes}");
                }
            }
        }
    }
}