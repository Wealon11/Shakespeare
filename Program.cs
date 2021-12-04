using Shakespeare.Sorting_algorithms;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Shakespeare
{
    class Program
    {



        static void Main(string[] args)
        {

            Stopwatch stopwatch = new Stopwatch();
            string shakespearText = System.IO.File.ReadAllText("C:/Users/45422/Desktop/Shakespeare/smallShakespeare.txt").ToLower();
 
            Regex regex = new Regex("[^a-z]");
            string shakespearLetters = regex.Replace(shakespearText, " ");


            string[] shakespearLettersArray1 = shakespearLetters.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string[] shakespearLettersArray2 = shakespearLetters.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string[] shakespearLettersArray3 = shakespearLetters.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string[] shakespearLettersArray4 = shakespearLetters.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string[] shakespearLettersArray5 = shakespearLetters.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);


            //Selection sort
            stopwatch.Start();
   
            Selection.selectionSort(shakespearLettersArray1);
            stopwatch.Stop();
            Console.WriteLine("Selection sort time: " + stopwatch.Elapsed);
            stopwatch.Restart();

            
            //Insertion sort
            stopwatch.Start();
            Insertion.InsertSort(shakespearLettersArray2);
            stopwatch.Stop();
            Console.WriteLine("Insertions sort time: " + stopwatch.Elapsed);
            stopwatch.Restart();

            //Merge sort
            stopwatch.Start();
            Merge.mergeSort(shakespearLettersArray3);
            stopwatch.Stop();
            Console.WriteLine("Merge sort time: " + stopwatch.Elapsed);
            stopwatch.Restart();

            //Heap sort
            stopwatch.Start();
            Heap.heapSort(shakespearLettersArray4, shakespearLettersArray4.Length);
            stopwatch.Stop();
            Console.WriteLine("Heap sort time: " + stopwatch.Elapsed);
            stopwatch.Restart();

            ////Trie sort
            //stopwatch.Start();
            //string[] trie = shakespearLettersArray5;
            //Trie.printInSortedOrder(trie);
            //stopwatch.Stop();
            //Console.WriteLine("Trie sort time: " + stopwatch.Elapsed);
            //stopwatch.Restart();



            Console.ReadKey();
        }
    }
}



     

      


