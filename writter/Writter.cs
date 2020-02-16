using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace writter
{
    class Writter
    {

        public const String NAME_FILE_Aleatorio_10_2 = "Aleatorio-10^2";
        public const String NAME_FILE_Aleatorio_10_5 = "Aleatorio-10^5";
        public const String NAME_FILE_Aleatorio_10_8 = "Aleatorio-10^8";
        public const String NAME_FILE_Orden_Ascendente_10_2 = "Orden-Ascendente-10^2";
        public const String NAME_FILE_Orden_Ascendente_10_5 = "Orden-Ascendente-10^5";
        public const String NAME_FILE_Orden_Ascendente_10_8 = "Orden-Ascendente-10^8";
        public const String NAME_FILE_Orden_Descendente_10_2 = "Orden-Ascendente-10^2";
        public const String NAME_FILE_Orden_Descendente_10_5 = "Orden-Ascendente-10^5";
        public const String NAME_FILE_Orden_Descendente_10_8 = "Orden-Ascendente-10^8";

        static void Main(string[] args)
        {
            Console.WriteLine("Inicia");
            Writter1(NAME_FILE_Aleatorio_10_2, 100);
            Writter1(NAME_FILE_Aleatorio_10_5, 100000);
            Writter1(NAME_FILE_Aleatorio_10_8, 100000000);

            Writter2(NAME_FILE_Orden_Ascendente_10_2, 100, true);
            Writter2(NAME_FILE_Orden_Ascendente_10_5, 100000, true);
            Writter2(NAME_FILE_Orden_Ascendente_10_8, 100000000, true);

            Writter2(NAME_FILE_Orden_Descendente_10_2, 100, false);
            Writter2(NAME_FILE_Orden_Descendente_10_5, 100000, false);
            Writter2(NAME_FILE_Orden_Descendente_10_8, 100000000, false);

            Console.WriteLine("Termino");
            Console.Read();

        }

        public static void Writter1(String fileName, int size)
        {
            try
            {

                StreamWriter sw = new StreamWriter("..\\..\\..\\Data\\" + fileName + ".txt", true);

                Random rmd = new Random();
                for (int i = 0; i < size; i++)
                {

                    sw.Write(rmd.Next(size) + " ");
                    Console.WriteLine("nums");
                }
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }

        public static void Writter2(String fileName, int size, Boolean order)
        {
            try
            {

                StreamWriter sw = new StreamWriter("..\\..\\..\\Data" + fileName + ".txt", true);

                if (order)
                {
                    int flag = 0;
                    while (flag < size)
                    {
                        sw.Write(flag + " ");
                        Console.WriteLine(value:flag);
                        flag++;
                    }
                }
                else
                {
                    while (size > 0)
                    {
                        sw.Write(size + " ");
                        Console.WriteLine(size+" ");
                        size--;
                    }
                }
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }
    }
}
