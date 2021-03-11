using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    public partial class Program
    {
        private static void BinaryWriter()
        {
            using (var fs = new FileStream("contaCorrente.txt", FileMode.Create))
            using (var writer = new BinaryWriter(fs))
            {
                writer.Write(3434); // agency
                writer.Write(34234234); // account
                writer.Write(12133.112); // limit
                writer.Write("Matheus");
            }
        }

        private static void BinaryReader()
        {
            using (var fs = new FileStream("contaCorrente.txt", FileMode.Open))
            using (var reader = new BinaryReader(fs))
            {
                var agency = reader.ReadInt32();
                var account = reader.ReadInt32();
                var limit = reader.ReadDouble();
                var costumer = reader.ReadString();

                Console.WriteLine($"{agency}/{account}/{costumer}/{limit}");
            }
        }
    }
}