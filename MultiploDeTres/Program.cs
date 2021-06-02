using System;
using System.IO;
using System.Text;

namespace MultiploDeTres
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileIn = @"D:\Developments\Olimpia\MultiploDeTres\files\fileIn.txt";
            string fileOut = @"D:\Developments\Olimpia\MultiploDeTres\files\fileOut.txt";
            try
            {
                if (!File.Exists(fileIn))
                {
                    Console.WriteLine("El archivo a consultar no existe");
                    return;
                }

                string[] lines = File.ReadAllLines(fileIn, Encoding.UTF8);
                string[] salida = new string[lines.Length];
                int i = 0;
                foreach (string line in lines)
                {
                    bool isMultiplo = EsMultiplo(line);
                    if (isMultiplo)
                    {
                        salida[i] = "SI";
                    }
                    else
                    {
                        salida[i] = "NO";
                    }
                    i++;
                }

                CrearArchivoSalida(salida, fileOut);
                Console.WriteLine("Proceso terminado exitosamente");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Se ha presentado el siguiente error: {0}", ex.Message);
            }
        }

        private static void CrearArchivoSalida(string[] salida, string fileOut)
        {
            if (File.Exists(fileOut))
            {
                File.Delete(fileOut);
            }
            File.WriteAllLines(fileOut, salida, Encoding.UTF8);
        }

        private static bool EsMultiplo(string line)
        {
            int[] valores = { 3, 6, 9 };
            char[] nums = line.ToCharArray();
            int suma = 0;
            foreach (char num in nums)
            {
                int n = int.Parse(num.ToString());
                suma += n;
            }

            if (Array.Exists(valores, v => v == suma) || suma % 3 == 0)
            {
                return true;
            }

            return false;
        }
    }
}
