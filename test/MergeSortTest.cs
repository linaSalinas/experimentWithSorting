﻿using System;
using sorting;
using writter;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace test
{
    [TestClass]
    public class MergeSortTest
    {
        private MergeSort merge;
        private String[] testArray;

        public const String REPORT_ROUT = "..\\..\\..\\data\\ReportMerge.txt";

        public void setUpScenary1() {
            
        }

        public void setUpScenary2() {
            merge = new MergeSort();
            testArray = new String[] { "1", "4", "2", "0", "15", "8", "20", "7"};
        }
     
        public void setUpScenary3()
        {
            Reader(loader.NAME_FILE_Aleatorio_10_2);
        }

        public void setUpScenary4()
        {
            Reader(loader.NAME_FILE_Aleatorio_10_4);
        }

        public void setUpScenary5()
        {
            Reader(loader.NAME_FILE_Aleatorio_10_6);
        }

        public void setUpScenary6()
        {
            Reader(loader.NAME_FILE_Orden_Ascendente_10_2);
        }

        public void setUpScenary7()
        {
            Reader(loader.NAME_FILE_Orden_Ascendente_10_4);
        }

        public void setUpScenary8()
        {
            Reader(loader.NAME_FILE_Orden_Ascendente_10_6);
        }

        public void setUpScenary9()
        {
            Reader(loader.NAME_FILE_Orden_Descendente_10_2);
        }

        public void setUpScenary10()
        {
            Reader(loader.NAME_FILE_Orden_Descendente_10_4);
        }

        public void setUpScenary11()
        {
            Reader(loader.NAME_FILE_Orden_Descendente_10_6);
        }
        
        [TestMethod]
        public void TestMergeSortConstructor()
        {
            setUpScenary1();
            merge = new MergeSort();
            Assert.IsNotNull(merge);
        }

        [TestMethod]
        public void TestMergeSort() 
        {
            setUpScenary2();
            merge.mergeSort(testArray, 0, testArray.Length-1);
            for(int i = 0; i < testArray.Length-1; i++) 
            {
                long comp = testArray[i].CompareTo(testArray[i + 1]);
                Console.WriteLine(value:testArray[i]);
            }
        }
        
        [TestMethod]
        public void TestMergeSortTime1()
        {
            String report = "TestMergeSortTime1\n setUpScenary3\n";
            String[] cloneArray = (String[])testArray.Clone();
            setUpScenary3();
            // Inicia el contador:
            DateTime tiempo1 = DateTime.Now;

            merge.mergeSort(cloneArray, 0, cloneArray.Length - 1);

            // Para el contador e imprime el resultado:
            DateTime tiempo2 = DateTime.Now;
            TimeSpan total = new TimeSpan(tiempo2.Ticks - tiempo1.Ticks);

            report = report + "Prueba 1 - Tiempo de ejecución :" +total.ToString()+"\n";

            cloneArray = (String[])testArray.Clone();

            // Inicia el contador:
            tiempo1 = DateTime.Now;

            merge.mergeSort(cloneArray, 0, cloneArray.Length - 1);

            // Para el contador e imprime el resultado:
            tiempo2 = DateTime.Now;
            total = new TimeSpan(tiempo2.Ticks - tiempo1.Ticks);

            report = report + "Prueba 2 - Tiempo de ejecución :" + total.ToString() + "\n\n";

            Console.Write(report);
            Writter(report);
        }

        [TestMethod]
        public void TestMergeSortTime2()
        {
            String report = "TestMergeSortTime2\n setUpScenary4\n";
            String[] cloneArray = (String[])testArray.Clone();
            setUpScenary4();
            // Inicia el contador:
            DateTime tiempo1 = DateTime.Now;

            merge.mergeSort(cloneArray, 0, cloneArray.Length - 1);

            // Para el contador e imprime el resultado:
            DateTime tiempo2 = DateTime.Now;
            TimeSpan total = new TimeSpan(tiempo2.Ticks - tiempo1.Ticks);

            report = report + "Prueba 1 - Tiempo de ejecución :" + total.ToString() + "\n";

            cloneArray = (String[])testArray.Clone();

            // Inicia el contador:
            tiempo1 = DateTime.Now;

            merge.mergeSort(cloneArray, 0, cloneArray.Length - 1);

            // Para el contador e imprime el resultado:
            tiempo2 = DateTime.Now;
            total = new TimeSpan(tiempo2.Ticks - tiempo1.Ticks);

            report = report + "Prueba 2 - Tiempo de ejecución :" + total.ToString() + "\n\n";

            Console.Write(report);
            Writter(report);
        }

        [TestMethod]
        public void TestMergeSortTime3()
        {
            String report = "TestMergeSortTime3\n setUpScenary5\n";
            String[] cloneArray = (String[])testArray.Clone();
            setUpScenary5();
            // Inicia el contador:
            DateTime tiempo1 = DateTime.Now;

            merge.mergeSort(cloneArray, 0, cloneArray.Length - 1);

            // Para el contador e imprime el resultado:
            DateTime tiempo2 = DateTime.Now;
            TimeSpan total = new TimeSpan(tiempo2.Ticks - tiempo1.Ticks);

            report = report + "Prueba 1 - Tiempo de ejecución :" + total.ToString() + "\n";

            cloneArray = (String[])testArray.Clone();

            // Inicia el contador:
            tiempo1 = DateTime.Now;

            merge.mergeSort(cloneArray, 0, cloneArray.Length - 1);

            // Para el contador e imprime el resultado:
            tiempo2 = DateTime.Now;
            total = new TimeSpan(tiempo2.Ticks - tiempo1.Ticks);

            report = report + "Prueba 2 - Tiempo de ejecución :" + total.ToString() + "\n\n";

            Console.Write(report);
            Writter(report);
        }

        [TestMethod]
        public void TestMergeSortTime4()
        {
            String report = "TestMergeSortTime4\n setUpScenary6\n";
            String[] cloneArray = (String[])testArray.Clone();
            setUpScenary6();
            // Inicia el contador:
            DateTime tiempo1 = DateTime.Now;

            merge.mergeSort(cloneArray, 0, cloneArray.Length - 1);

            // Para el contador e imprime el resultado:
            DateTime tiempo2 = DateTime.Now;
            TimeSpan total = new TimeSpan(tiempo2.Ticks - tiempo1.Ticks);

            report = report + "Prueba 1 - Tiempo de ejecución :" + total.ToString() + "\n";

            cloneArray = (String[])testArray.Clone();

            // Inicia el contador:
            tiempo1 = DateTime.Now;

            merge.mergeSort(cloneArray, 0, cloneArray.Length - 1);

            // Para el contador e imprime el resultado:
            tiempo2 = DateTime.Now;
            total = new TimeSpan(tiempo2.Ticks - tiempo1.Ticks);

            report = report + "Prueba 2 - Tiempo de ejecución :" + total.ToString() + "\n";

            Console.Write(report);
            Writter(report);
        }

        [TestMethod]
        public void TestMergeSortTime5()
        {
            String report = "TestMergeSortTime5\n setUpScenary7\n";
            String[] cloneArray = (String[])testArray.Clone();
            setUpScenary7();
            // Inicia el contador:
            DateTime tiempo1 = DateTime.Now;

            merge.mergeSort(cloneArray, 0, cloneArray.Length - 1);

            // Para el contador e imprime el resultado:
            DateTime tiempo2 = DateTime.Now;
            TimeSpan total = new TimeSpan(tiempo2.Ticks - tiempo1.Ticks);

            report = report + "Prueba 1 - Tiempo de ejecución :" + total.ToString() + "\n";

            cloneArray = (String[])testArray.Clone();

            // Inicia el contador:
            tiempo1 = DateTime.Now;

            merge.mergeSort(cloneArray, 0, cloneArray.Length - 1);

            // Para el contador e imprime el resultado:
            tiempo2 = DateTime.Now;
            total = new TimeSpan(tiempo2.Ticks - tiempo1.Ticks);

            report = report + "Prueba 2 - Tiempo de ejecución :" + total.ToString() + "\n";

            Console.Write(report);
            Writter(report);
        }

        [TestMethod]
        public void TestMergeSortTime6()
        {
            String report = "TestMergeSortTime6\n setUpScenary8\n";
            String[] cloneArray = (String[])testArray.Clone();
            setUpScenary8();
            // Inicia el contador:
            DateTime tiempo1 = DateTime.Now;

            merge.mergeSort(cloneArray, 0, cloneArray.Length - 1);

            // Para el contador e imprime el resultado:
            DateTime tiempo2 = DateTime.Now;
            TimeSpan total = new TimeSpan(tiempo2.Ticks - tiempo1.Ticks);

            report = report + "Prueba 1 - Tiempo de ejecución :" + total.ToString() + "\n";

            cloneArray = (String[])testArray.Clone();

            // Inicia el contador:
            tiempo1 = DateTime.Now;

            merge.mergeSort(cloneArray, 0, cloneArray.Length - 1);

            // Para el contador e imprime el resultado:
            tiempo2 = DateTime.Now;
            total = new TimeSpan(tiempo2.Ticks - tiempo1.Ticks);

            report = report + "Prueba 2 - Tiempo de ejecución :" + total.ToString() + "\n";

            Console.Write(report);
            Writter(report);
        }

        [TestMethod]
        public void TestMergeSortTime7()
        {
            String report = "TestMergeSortTime7\n setUpScenary9\n";
            String[] cloneArray = (String[])testArray.Clone();
            setUpScenary9();
            // Inicia el contador:
            DateTime tiempo1 = DateTime.Now;

            merge.mergeSort(cloneArray, 0, cloneArray.Length - 1);

            // Para el contador e imprime el resultado:
            DateTime tiempo2 = DateTime.Now;
            TimeSpan total = new TimeSpan(tiempo2.Ticks - tiempo1.Ticks);

            report = report + "Prueba 1 - Tiempo de ejecución :" + total.ToString() + "\n";

            cloneArray = (String[])testArray.Clone();

            // Inicia el contador:
            tiempo1 = DateTime.Now;

            merge.mergeSort(cloneArray, 0, cloneArray.Length - 1);

            // Para el contador e imprime el resultado:
            tiempo2 = DateTime.Now;
            total = new TimeSpan(tiempo2.Ticks - tiempo1.Ticks);

            report = report + "Prueba 2 - Tiempo de ejecución :" + total.ToString() + "\n";

            Console.Write(report);
            Writter(report);
        }

        [TestMethod]
        public void TestMergeSortTime8()
        {
            String report = "TestMergeSortTime8\n setUpScenary10\n";
            String[] cloneArray = (String[])testArray.Clone();
            setUpScenary10();
            // Inicia el contador:
            DateTime tiempo1 = DateTime.Now;

            merge.mergeSort(cloneArray, 0, cloneArray.Length - 1);

            // Para el contador e imprime el resultado:
            DateTime tiempo2 = DateTime.Now;
            TimeSpan total = new TimeSpan(tiempo2.Ticks - tiempo1.Ticks);

            report = report + "Prueba 1 - Tiempo de ejecución :" + total.ToString() + "\n";

           cloneArray = (String[])testArray.Clone();

            // Inicia el contador:
            tiempo1 = DateTime.Now;

            merge.mergeSort(cloneArray, 0, cloneArray.Length - 1);

            // Para el contador e imprime el resultado:
            tiempo2 = DateTime.Now;
            total = new TimeSpan(tiempo2.Ticks - tiempo1.Ticks);

            report = report + "Prueba 2 - Tiempo de ejecución :" + total.ToString() + "\n";

            Console.Write(report);
            Writter(report);
        }

        [TestMethod]
        public void TestMergeSortTime9()
        {
            String report = "TestMergeSortTime9\n setUpScenary11\n";
            String[] cloneArray = (String[])testArray.Clone();
            setUpScenary11();
            // Inicia el contador:
            DateTime tiempo1 = DateTime.Now;

            merge.mergeSort(cloneArray, 0, cloneArray.Length - 1);

            // Para el contador e imprime el resultado:
            DateTime tiempo2 = DateTime.Now;
            TimeSpan total = new TimeSpan(tiempo2.Ticks - tiempo1.Ticks);

            report = report + "Prueba 1 - Tiempo de ejecución :" + total.ToString() + "\n";

            cloneArray = (String[])testArray.Clone();

            // Inicia el contador:
            tiempo1 = DateTime.Now;

            merge.mergeSort(cloneArray, 0, cloneArray.Length - 1);

            // Para el contador e imprime el resultado:
            tiempo2 = DateTime.Now;
            total = new TimeSpan(tiempo2.Ticks - tiempo1.Ticks);

            report = report + "Prueba 2 - Tiempo de ejecución :" + total.ToString() + "\n";

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