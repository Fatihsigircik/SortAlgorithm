
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace YazilimUniversitesi
{
    class Example
    {
        public static void Main()
        {
            yyy();
            xxx();
            
            Console.ReadLine();
        }

        static void xxx()
        {
            var array = new int[] { 51, 21, 52, 85, 35, 2, 83, 27, 7, 54, 79, 40, 25, 74, 12, 37, 1, 58, 30, 11, 67, 56, 14, 43, 9, 16, 78, 19, 90, 60, 9, 93, 90, 74, 59, 42, 70, 6, 48, 5, 18, 53, 8, 99, 77, 24, 43, 22, 47, 5, 64, 98, 39, 53, 95, 94, 7, 8, 76, 18, 23, 64, 36, 47, 45, 85, 50, 50, 15, 69, 67, 94, 9, 24, 92, 14, 47, 15, 65, 85, 73, 55, 71, 84, 95, 10, 54, 36, 79, 64, 34, 61, 30, 30, 82, 54, 16, 61, 53, 92 };
            //var array = GetArray(100);
            Stopwatch sw = new Stopwatch();
            sw.Start();
            var tempArray = new int[array.Length];
            tempArray[0] = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                int item = array[i];
                int index1 = 0;
                int index2 = i;

                if (item < tempArray[0])
                {
                    for (int j = i - 1; j >= 0; j--)
                    {
                        tempArray[j + 1] = tempArray[j];
                    }
                    tempArray[0] = item;
                    //index++;
                    continue;
                }

                if (item > tempArray[i - 1])
                {
                    tempArray[i] = item;
                    //index++;
                    continue;
                }

                while (true)
                {
                    if (index2 - index1 == 1)
                    {

                        for (int j = i - 1; j > index1; j--)
                        {
                            tempArray[j + 1] = tempArray[j];
                        }
                        tempArray[index1 + 1] = item;
                        //index++;
                        break;

                    }

                    var tempIndex = index1 + ((index2 - index1) / 2);
                    var tempItem = tempArray[tempIndex];
                    if (item < tempItem)
                    {
                        index2 = tempIndex;
                    }
                    else if (item >= tempItem)
                    {
                        index1 = tempIndex;
                    }
                    else
                    {
                        for (int j = i - 1; j >= tempIndex; j--)
                        {
                            tempArray[j + 1] = tempArray[j];
                        }
                        tempArray[0] = item;
                        //index++;
                    }
                }
            }

            sw.Stop();
            Console.WriteLine(sw.Elapsed);

            //Console.WriteLine(string.Join(",", array) + Environment.NewLine);
            //Console.WriteLine(string.Join(",", tempArray));


            
        }

        static void yyy()
        {
            var array = new int[] { 51, 21, 52, 85, 35, 2, 83, 27, 7, 54, 79, 40, 25, 74, 12, 37, 1, 58, 30, 11, 67, 56, 14, 43, 9, 16, 78, 19, 90, 60, 9, 93, 90, 74, 59, 42, 70, 6, 48, 5, 18, 53, 8, 99, 77, 24, 43, 22, 47, 5, 64, 98, 39, 53, 95, 94, 7, 8, 76, 18, 23, 64, 36, 47, 45, 85, 50, 50, 15, 69, 67, 94, 9, 24, 92, 14, 47, 15, 65, 85, 73, 55, 71, 84, 95, 10, 54, 36, 79, 64, 34, 61, 30, 30, 82, 54, 16, 61, 53, 92 };
            //var array = GetArray(100);
            Stopwatch sw = new Stopwatch();
            sw.Start();

            Array.Sort(array);

            sw.Stop();
            Console.WriteLine(sw.Elapsed);
        }

        static int[] GetArray(int length)
        {
            var retVal = new int[length];
            var rnd = new Random();
            for (int i = 0; i < length; i++)
            {
                //retVal[i] = rnd.Next(100000);
                retVal[i] = rnd.Next(100);
            }

            return retVal;
        }

    }
}
