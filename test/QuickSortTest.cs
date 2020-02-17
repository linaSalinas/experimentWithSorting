﻿using System;
using sorting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace test
{
    [TestClass]
    public class QuickSortTest
    {
        private QuickSort quick;
        private String[] testArray;


        public const String NAME_FILE_Aleatorio_10_2 = "Aleatorio-10^2";
        public const String NAME_FILE_Aleatorio_10_5 = "Aleatorio-10^5";
        public const String NAME_FILE_Aleatorio_10_8 = "Aleatorio-10^8";
        public const String NAME_FILE_Orden_Ascendente_10_2 = "Orden-Ascendente-10^2";
        public const String NAME_FILE_Orden_Ascendente_10_5 = "Orden-Ascendente-10^5";
        public const String NAME_FILE_Orden_Ascendente_10_8 = "Orden-Ascendente-10^8";
        public const String NAME_FILE_Orden_Descendente_10_2 = "Orden-Ascendente-10^2";
        public const String NAME_FILE_Orden_Descendente_10_5 = "Orden-Ascendente-10^5";
        public const String NAME_FILE_Orden_Descendente_10_8 = "Orden-Ascendente-10^8";

        public const String REPORT_ROUT = "..\\..\\..\\data\\ReportQuick.txt";


        public void setUpScenary1()
        {

        }

        public void setUpScenary2()
        {
            quick = new QuickSort();
            testArray = new String[] { "1", "4", "2", "0", "15", "8", "20", "7" };
        }

        public void setUpScenary3()
        {
            Reader(NAME_FILE_Aleatorio_10_2);
        }

        public void setUpScenary4()
        {
            Reader(NAME_FILE_Aleatorio_10_5);
        }

        public void setUpScenary5()
        {
            Reader(NAME_FILE_Aleatorio_10_8);
        }

        public void setUpScenary6()
        {
            Reader(NAME_FILE_Orden_Ascendente_10_2);
        }

        public void setUpScenary7()
        {
            Reader(NAME_FILE_Orden_Ascendente_10_5);
        }

        public void setUpScenary8()
        {
            Reader(NAME_FILE_Orden_Ascendente_10_8);
        }

        public void setUpScenary9()
        {
            Reader(NAME_FILE_Orden_Descendente_10_2);
        }

        public void setUpScenary10()
        {
            Reader(NAME_FILE_Orden_Descendente_10_5);
        }

        public void setUpScenary11()
        {
            Reader(NAME_FILE_Orden_Descendente_10_8);
        }

        [TestMethod]
        public void TestQuickSortConstructor()
        {
            setUpScenary1();
            quick = new QuickSort();
            Assert.IsNotNull(quick);
        }

        [TestMethod]
        public void TestQuickSort()
        {
            setUpScenary2();
            quick.quickSort(testArray, 0, testArray.Length - 1);
            for (int i = 0; i < testArray.Length; i++)
            {
                Assert.IsTrue(testArray[i] < testArray[i + 1]);
            }
        }

        [TestMethod]
        public void TestQuickSortTime1()
        {
            String report = "TestMergeSortTime1\n setUpSceneary3\n";
            String[] cloneArray = (String[])testArray.Clone();
            setUpScenary3();
            // Inicia el contador:
            DateTime tiempo1 = DateTime.Now;

            quick.quickSort(cloneArray, 0, cloneArray.Length - 1);

            // Para el contador e imprime el resultado:
            DateTime tiempo2 = DateTime.Now;
            TimeSpan total = new TimeSpan(tiempo2.Ticks - tiempo1.Ticks);

            report = report + "Prueba 1 - Tiempo de ejecución :" + total.ToString() + "\n";

            cloneArray = (String[])testArray.Clone();

            // Inicia el contador:
            tiempo1 = DateTime.Now;

            quick.quickSort(cloneArray, 0, cloneArray.Length - 1);

            // Para el contador e imprime el resultado:
            tiempo2 = DateTime.Now;
            total = new TimeSpan(tiempo2.Ticks - tiempo1.Ticks);

            report = report + "Prueba 2 - Tiempo de ejecución :" + total.ToString() + "\n\n";

            Console.Write(report);
            Writter(report);
        }

        [TestMethod]
        public void TestQuickSortTime2()
        {
            String report = "TestMergeSortTime2\n setUpSceneary4\n";
            String[] cloneArray = (String[])testArray.Clone();
            setUpScenary4();
            // Inicia el contador:
            DateTime tiempo1 = DateTime.Now;

            quick.quickSort(cloneArray, 0, cloneArray.Length - 1);

            // Para el contador e imprime el resultado:
            DateTime tiempo2 = DateTime.Now;
            TimeSpan total = new TimeSpan(tiempo2.Ticks - tiempo1.Ticks);

            report = report + "Prueba 1 - Tiempo de ejecución :" + total.ToString() + "\n";

            cloneArray = (String[])testArray.Clone();

            // Inicia el contador:
            tiempo1 = DateTime.Now;

            quick.quickSort(cloneArray, 0, cloneArray.Length - 1);

            // Para el contador e imprime el resultado:
            tiempo2 = DateTime.Now;
            total = new TimeSpan(tiempo2.Ticks - tiempo1.Ticks);

            report = report + "Prueba 2 - Tiempo de ejecución :" + total.ToString() + "\n\n";

            Console.Write(report);
            Writter(report);
        }

        [TestMethod]
        public void TestQuickSortTime3()
        {
            String report = "TestMergeSortTime3\n setUpSceneary5\n";
            String[] cloneArray = (String[])testArray.Clone();
            setUpScenary5();
            // Inicia el contador:
            DateTime tiempo1 = DateTime.Now;

            quick.quickSort(cloneArray, 0, cloneArray.Length - 1);

            // Para el contador e imprime el resultado:
            DateTime tiempo2 = DateTime.Now;
            TimeSpan total = new TimeSpan(tiempo2.Ticks - tiempo1.Ticks);

            report = report + "Prueba 1 - Tiempo de ejecución :" + total.ToString() + "\n";

            cloneArray = (String[])testArray.Clone();

            // Inicia el contador:
            tiempo1 = DateTime.Now;

            quick.quickSort(cloneArray, 0, cloneArray.Length - 1);

            // Para el contador e imprime el resultado:
            tiempo2 = DateTime.Now;
            total = new TimeSpan(tiempo2.Ticks - tiempo1.Ticks);

            report = report + "Prueba 2 - Tiempo de ejecución :" + total.ToString() + "\n\n";

            Console.Write(report);
            Writter(report);
        }

        [TestMethod]
        public void TestQuickSortTime4()
        {
            String report = "TestMergeSortTime4\n setUpSceneary6\n";
            String[] cloneArray = (String[])testArray.Clone();
            setUpScenary6();
            // Inicia el contador:
            DateTime tiempo1 = DateTime.Now;

            quick.quickSort(cloneArray, 0, cloneArray.Length - 1);

            // Para el contador e imprime el resultado:
            DateTime tiempo2 = DateTime.Now;
            TimeSpan total = new TimeSpan(tiempo2.Ticks - tiempo1.Ticks);

            report = report + "Prueba 1 - Tiempo de ejecución :" + total.ToString() + "\n";

            cloneArray = (String[])testArray.Clone();

            // Inicia el contador:
            tiempo1 = DateTime.Now;

            quick.quickSort(cloneArray, 0, cloneArray.Length - 1);

            // Para el contador e imprime el resultado:
            tiempo2 = DateTime.Now;
            total = new TimeSpan(tiempo2.Ticks - tiempo1.Ticks);

            report = report + "Prueba 2 - Tiempo de ejecución :" + total.ToString() + "\n\n";

            Console.Write(report);
            Writter(report);
        }

        [TestMethod]
        public void TestQuickSortTime5()
        {
            String report = "TestMergeSortTime5\n setUpSceneary7\n";
            String[] cloneArray = (String[])testArray.Clone();
            setUpScenary7();
            // Inicia el contador:
            DateTime tiempo1 = DateTime.Now;

            quick.quickSort(cloneArray, 0, cloneArray.Length - 1);

            // Para el contador e imprime el resultado:
            DateTime tiempo2 = DateTime.Now;
            TimeSpan total = new TimeSpan(tiempo2.Ticks - tiempo1.Ticks);

            report = report + "Prueba 1 - Tiempo de ejecución :" + total.ToString() + "\n";

            cloneArray = (String[])testArray.Clone();

            // Inicia el contador:
            tiempo1 = DateTime.Now;

            quick.quickSort(cloneArray, 0, cloneArray.Length - 1);

            // Para el contador e imprime el resultado:
            tiempo2 = DateTime.Now;
            total = new TimeSpan(tiempo2.Ticks - tiempo1.Ticks);

            report = report + "Prueba 2 - Tiempo de ejecución :" + total.ToString() + "\n\n";

            Console.Write(report);
            Writter(report);
        }

        [TestMethod]
        public void TestQuickSortTime6()
        {
            String report = "TestMergeSortTime6\n setUpSceneary8\n";
            String[] cloneArray = (String[])testArray.Clone();
            setUpScenary8();
            // Inicia el contador:
            DateTime tiempo1 = DateTime.Now;

            quick.quickSort(cloneArray, 0, cloneArray.Length - 1);

            // Para el contador e imprime el resultado:
            DateTime tiempo2 = DateTime.Now;
            TimeSpan total = new TimeSpan(tiempo2.Ticks - tiempo1.Ticks);

            report = report + "Prueba 1 - Tiempo de ejecución :" + total.ToString() + "\n";

            cloneArray = (String[])testArray.Clone();

            // Inicia el contador:
            tiempo1 = DateTime.Now;

            quick.quickSort(cloneArray, 0, cloneArray.Length - 1);

            // Para el contador e imprime el resultado:
            tiempo2 = DateTime.Now;
            total = new TimeSpan(tiempo2.Ticks - tiempo1.Ticks);

            report = report + "Prueba 2 - Tiempo de ejecución :" + total.ToString() + "\n\n";

            Console.Write(report);
            Writter(report);
        }

        [TestMethod]
        public void TestQuickSortTime7()
        {
            String report = "TestMergeSortTime7\n setUpSceneary9\n";
            String[] cloneArray = (String[])testArray.Clone();
            setUpScenary9();
            // Inicia el contador:
            DateTime tiempo1 = DateTime.Now;

            quick.quickSort(cloneArray, 0, cloneArray.Length - 1);

            // Para el contador e imprime el resultado:
            DateTime tiempo2 = DateTime.Now;
            TimeSpan total = new TimeSpan(tiempo2.Ticks - tiempo1.Ticks);

            report = report + "Prueba 1 - Tiempo de ejecución :" + total.ToString() + "\n";

            cloneArray = (String[])testArray.Clone();

            // Inicia el contador:
            tiempo1 = DateTime.Now;

            quick.quickSort(cloneArray, 0, cloneArray.Length - 1);

            // Para el contador e imprime el resultado:
            tiempo2 = DateTime.Now;
            total = new TimeSpan(tiempo2.Ticks - tiempo1.Ticks);

            report = report + "Prueba 2 - Tiempo de ejecución :" + total.ToString() + "\n\n";

            Console.Write(report);
            Writter(report);
        }

        [TestMethod]
        public void TestQuickSortTime8()
        {
            String report = "TestMergeSortTime8\n setUpSceneary10\n";
            String[] cloneArray = (String[])testArray.Clone();
            setUpScenary10();
            // Inicia el contador:
            DateTime tiempo1 = DateTime.Now;

            quick.quickSort(cloneArray, 0, cloneArray.Length - 1);

            // Para el contador e imprime el resultado:
            DateTime tiempo2 = DateTime.Now;
            TimeSpan total = new TimeSpan(tiempo2.Ticks - tiempo1.Ticks);

            report = report + "Prueba 1 - Tiempo de ejecución :" + total.ToString() + "\n";

            cloneArray = (String[])testArray.Clone();

            // Inicia el contador:
            tiempo1 = DateTime.Now;

            quick.quickSort(cloneArray, 0, cloneArray.Length - 1);

            // Para el contador e imprime el resultado:
            tiempo2 = DateTime.Now;
            total = new TimeSpan(tiempo2.Ticks - tiempo1.Ticks);

            report = report + "Prueba 2 - Tiempo de ejecución :" + total.ToString() + "\n\n";

            Console.Write(report);
            Writter(report);
        }

        [TestMethod]
        public void TestQuickSortTime9()
        {
            String report = "TestMergeSortTime9\n setUpSceneary11\n";
            String[] cloneArray = (String[])testArray.Clone();
            setUpScenary11();
            // Inicia el contador:
            DateTime tiempo1 = DateTime.Now;

            quick.quickSort(cloneArray, 0, cloneArray.Length - 1);

            // Para el contador e imprime el resultado:
            DateTime tiempo2 = DateTime.Now;
            TimeSpan total = new TimeSpan(tiempo2.Ticks - tiempo1.Ticks);

            report = report + "Prueba 1 - Tiempo de ejecución :" + total.ToString() + "\n";

            cloneArray = (String[])testArray.Clone();

            // Inicia el contador:
            tiempo1 = DateTime.Now;

            quick.quickSort(cloneArray, 0, cloneArray.Length - 1);

            // Para el contador e imprime el resultado:
            tiempo2 = DateTime.Now;
            total = new TimeSpan(tiempo2.Ticks - tiempo1.Ticks);

            report = report + "Prueba 2 - Tiempo de ejecución :" + total.ToString() + "\n\n";

            Console.Write(report);
            Writter(report);
        }

        private void Reader(String Namefile)
        {
            try
            {
                StreamReader sr = new StreamReader("..\\..\\..\\" + Namefile + ".txt");
                testArray = sr.ReadToEnd().Split(' ');
                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }

        public void Writter(String report)
        {
            try
            {
                StreamWriter sw = new StreamWriter(REPORT_ROUT, true);
                sw.Write(report);
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }
    }
}
}
