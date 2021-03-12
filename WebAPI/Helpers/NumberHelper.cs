using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Helpers
{
    public static class NumberHelper
    {
        const string FILE_NAME = @"D:\GithubRepositories\WebAPI\WebAPI\ResultData.txt";

        public static void ExecuteContainerActions(NumberContainer container)
        {
            int[] bubbleSortResults;
            int[] quickSortResults;
            long bubbleSortDuration;
            long quickSortDuration;
            SortNumbers(container, out bubbleSortDuration, out quickSortDuration, out bubbleSortResults, out quickSortResults);
            PrintDataToFile(bubbleSortResults, quickSortResults, bubbleSortDuration, quickSortDuration);
        }

        public static void SortNumbers(NumberContainer container, out long bubbleSortDuration, out long quickSortDuration, out int[] bubbleSortResults, out int[] quickSortResults)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            bubbleSortResults = container.BubbleSort();
            stopwatch.Stop();
            bubbleSortDuration = stopwatch.ElapsedMilliseconds;
            stopwatch.Reset();
            stopwatch.Start();
            quickSortResults = container.QuickSort();
            stopwatch.Stop();
            quickSortDuration = stopwatch.ElapsedMilliseconds;
        }

        private static void PrintDataToFile(int[] bubbleSortResults, int[] quickSortResults, long bubbleSortDuration, long quickSortDuration)
        {
            string resultText = "BubbleSort duration: " + bubbleSortDuration + "ms; "
                               + "\nQuickSort duration: " + quickSortDuration + "ms; "
                               + "\nBubbleSort results: " + String.Join("; ", bubbleSortResults)
                               + "\nQuickSort results: " + String.Join("; ", quickSortResults);
            using (StreamWriter writer = new StreamWriter(FILE_NAME))
            {
                writer.Write(resultText);
            }
        }

        public static string GetResultTextFromFile()
        {
            string resultText = "";
            using (StreamReader reader = new StreamReader(FILE_NAME))
            {
                resultText = reader.ReadToEnd();
            }
            return resultText;
        }
    }
}
