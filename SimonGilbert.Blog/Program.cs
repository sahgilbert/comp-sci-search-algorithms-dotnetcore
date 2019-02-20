using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using SimonGilbert.Blog.Algorithms;
using SimonGilbert.Blog.Data;

namespace SimonGilbert.Blog
{
    class Program : DataSetBase
    {
        static void Main(string[] args)
        {
            var results = SearchPerformanceFirst();

            Console.Write(Environment.NewLine);
            Console.WriteLine("RESULTS (First):");
            foreach (var result in results)
                Console.WriteLine($"Version {result.Key} : {result.Value}");

            Console.Write(Environment.NewLine);
            Console.WriteLine("WINNER:");
            var keyAndValue = results.OrderBy(kvp => kvp.Value).First();
            Console.WriteLine("{0} => {1}", keyAndValue.Key, keyAndValue.Value);

            results = SearchPerformanceMiddle();

            Console.Write(Environment.NewLine);
            Console.WriteLine("RESULTS (First):");
            foreach (var result in results)
                Console.WriteLine($"Version {result.Key} : {result.Value}");

            Console.Write(Environment.NewLine);
            Console.WriteLine("WINNER:");
            keyAndValue = results.OrderBy(kvp => kvp.Value).First();
            Console.WriteLine("{0} => {1}", keyAndValue.Key, keyAndValue.Value);

            results = SearchPerformanceLast();

            Console.Write(Environment.NewLine);
            Console.WriteLine("RESULTS (First):");
            foreach (var result in results)
                Console.WriteLine($"Version {result.Key} : {result.Value}");

            Console.Write(Environment.NewLine);
            Console.WriteLine("WINNER:");
            keyAndValue = results.OrderBy(kvp => kvp.Value).First();
            Console.WriteLine("{0} => {1}", keyAndValue.Key, keyAndValue.Value);

            Console.ReadKey();
        }

        private static Dictionary<string, TimeSpan> SearchPerformanceFirst()
        {
            var results = new Dictionary<string, TimeSpan>();
            var valueToFind = 4;

            var stopWatch = Stopwatch.StartNew();
            var linearSearchResult = LinearSearch.Find(_dataSetNumbersLarge, valueToFind);
            stopWatch.Stop();
            results.Add("LinearSearch.Find", stopWatch.Elapsed);

            stopWatch.Restart();
            var linearSearchResultLambda = LinearSearch.FindUsingLambda(_dataSetNumbersLarge, valueToFind);
            stopWatch.Stop();
            results.Add("LinearSearch.FindUsingLambda", stopWatch.Elapsed);

            stopWatch.Restart();
            var jumpSearchResult = JumpSearch.Find(_dataSetNumbersLarge, valueToFind);
            stopWatch.Stop();
            results.Add("JumpSearch.Find", stopWatch.Elapsed);

            stopWatch.Restart();
            var binarySearchResult = BinarySearch.Find(_dataSetNumbersLarge, valueToFind);
            stopWatch.Stop();
            results.Add("BinarySearch.Find", stopWatch.Elapsed);

            stopWatch.Restart();
            var binarySearchResultLibraryMethod = BinarySearch.FindUsingLibraryMethod(_dataSetNumbersLarge, valueToFind);
            stopWatch.Stop();
            results.Add("BinarySearch.FindUsingLibraryMethod", stopWatch.Elapsed);

            return results;
        }

        private static Dictionary<string, TimeSpan> SearchPerformanceMiddle()
        {
            var results = new Dictionary<string, TimeSpan>();
            var valueToFind = 475;

            var stopWatch = Stopwatch.StartNew();
            var linearSearchResult = LinearSearch.Find(_dataSetNumbersLarge, valueToFind);
            stopWatch.Stop();
            results.Add("LinearSearch.Find", stopWatch.Elapsed);

            stopWatch.Restart();
            var linearSearchResultLambda = LinearSearch.FindUsingLambda(_dataSetNumbersLarge, valueToFind);
            stopWatch.Stop();
            results.Add("LinearSearch.FindUsingLambda", stopWatch.Elapsed);

            stopWatch.Restart();
            var jumpSearchResult = JumpSearch.Find(_dataSetNumbersLarge, valueToFind);
            stopWatch.Stop();
            results.Add("JumpSearch.Find", stopWatch.Elapsed);

            stopWatch.Restart();
            var binarySearchResult = BinarySearch.Find(_dataSetNumbersLarge, valueToFind);
            stopWatch.Stop();
            results.Add("BinarySearch.Find", stopWatch.Elapsed);

            stopWatch.Restart();
            var binarySearchResultLibraryMethod = BinarySearch.FindUsingLibraryMethod(_dataSetNumbersLarge, valueToFind);
            stopWatch.Stop();
            results.Add("BinarySearch.FindUsingLibraryMethod", stopWatch.Elapsed);

            return results;
        }

        private static Dictionary<string, TimeSpan> SearchPerformanceLast()
        {
            var results = new Dictionary<string, TimeSpan>();
            var valueToFind = 983;

            var stopWatch = Stopwatch.StartNew();
            var linearSearchResult = LinearSearch.Find(_dataSetNumbersLarge, valueToFind);
            stopWatch.Stop();
            results.Add("LinearSearch.Find", stopWatch.Elapsed);

            stopWatch.Restart();
            var linearSearchResultLambda = LinearSearch.FindUsingLambda(_dataSetNumbersLarge, valueToFind);
            stopWatch.Stop();
            results.Add("LinearSearch.FindUsingLambda", stopWatch.Elapsed);

            stopWatch.Restart();
            var jumpSearchResult = JumpSearch.Find(_dataSetNumbersLarge, valueToFind);
            stopWatch.Stop();
            results.Add("JumpSearch.Find", stopWatch.Elapsed);

            stopWatch.Restart();
            var binarySearchResult = BinarySearch.Find(_dataSetNumbersLarge, valueToFind);
            stopWatch.Stop();
            results.Add("BinarySearch.Find", stopWatch.Elapsed);

            stopWatch.Restart();
            var binarySearchResultLibraryMethod = BinarySearch.FindUsingLibraryMethod(_dataSetNumbersLarge, valueToFind);
            stopWatch.Stop();
            results.Add("BinarySearch.FindUsingLibraryMethod", stopWatch.Elapsed);

            return results;
        }
    }
}
