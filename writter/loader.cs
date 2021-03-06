﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace writter
{
    public class loader
    {
        public const int final = 0;
        public const String NAME_FILE_Aleatorio_10_2 = "Aleatorio-10^2";
        public const String NAME_FILE_Aleatorio_10_4 = "Aleatorio-10^4";
        public const String NAME_FILE_Aleatorio_10_6 = "Aleatorio-10^6";
        public const String NAME_FILE_Orden_Ascendente_10_2 = "Orden-Ascendente-10^2";
        public const String NAME_FILE_Orden_Ascendente_10_4 = "Orden-Ascendente-10^4";
        public const String NAME_FILE_Orden_Ascendente_10_6 = "Orden-Ascendente-10^6";
        public const String NAME_FILE_Orden_Descendente_10_2 = "Orden-Descendente-10^2";
        public const String NAME_FILE_Orden_Descendente_10_4 = "Orden-Descendente-10^4";
        public const String NAME_FILE_Orden_Descendente_10_6 = "Orden-Descendente-10^6";

        static void Main(string[] args)
        {
            Console.WriteLine("Inicia");
            //Writter1(NAME_FILE_Aleatorio_10_2, 100);
            Writter1(NAME_FILE_Aleatorio_10_4, 10000);
            Writter1(NAME_FILE_Aleatorio_10_6, 1000000);

            //Writter2(NAME_FILE_Orden_Ascendente_10_2, 100, true);
            Writter2(NAME_FILE_Orden_Ascendente_10_4, 10000, true);
            Writter2(NAME_FILE_Orden_Ascendente_10_6, 1000000, true);

            //Writter2(NAME_FILE_Orden_Descendente_10_2, 100, false);
            Writter2(NAME_FILE_Orden_Descendente_10_4, 10000, false);
            Writter2(NAME_FILE_Orden_Descendente_10_6, 1000000, false);

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

                StreamWriter sw = new StreamWriter("..\\..\\..\\Data\\" + fileName + ".txt", true);

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
