using System;
using System.Collections.Generic;

namespace Basic_13
{
    class Program
    {

        public static void printNum()
        {
            for(int i = 1; i <=255; i++) {
                Console.WriteLine(i);
            }
        }

        public static void printOdd()
        {
            for(int i = 1; i <=255; i++) {
                if(i % 2 != 0) {
                    Console.WriteLine(i);
                }
            }
        }

        public static void printSum()
        {
            int sum = 0;
            for(int i = 0; i <=255; i++)
            {
                sum += i;
                Console.WriteLine("Number: {0}, Sum: {1}", i, sum);
            }
        }

        public static void itterateArray()
        {
            int[] arr = {1,3,5,7,9,13};
            foreach(int num in arr) {
                Console.WriteLine(num);
            }
        }

        public static int findMax(int[] arr)
        {
            int max = arr[0];
            foreach(int num in arr) {
                if (num > max)
                {
                    max = num;
                }
            }
            return max;
        }

        public static int findMin(int[] arr)
        {
            int min = arr[0];
            foreach(int num in arr) {
                if (num < min)
                {
                    min = num;
                }
            }
            return min;
        }

        public static float findAverage(int[] arr)
        {
            int sum = 0;
            foreach(int num in arr)
            {
                sum += num;
            }

            float average = sum / arr.Length;
            return average;
        }

        public static int[] OddNumbers() 
        {
            int count = (255/2) + 1;
            int[] arr = new int[count];
            int counter = 0;
            for(var i = 1; i <= 255; i++)
            {
                if(i % 2 != 0)
                {
                    arr[counter] = i;
                    counter++;
                }
            }

            return arr;
        }

        public static int greaterThanY(int[] arr, int y)
        {
            int count = 0;
            foreach(int num in arr)
            {
                if (num > y)
                {
                    count++;
                }
            }

            return count;
        }

        public static int[] squareValues(int[] arr)
        {
           for(int x = 0; x < arr.Length; x++)
           {
               arr[x] *= arr[x];
           }

           return arr;
        }

        public static int[] eliminateNegative(int[] arr)
        {
            for(int x = 0; x < arr.Length; x++)
            {
                if(arr[x] < 0)
                {
                    arr[x] = 0;
                }
            }
            return arr;
        }

        public static void minMaxAverage(int[] arr)
        {
            int min = findMin(arr);
            int max = findMax(arr);
            float mean = findAverage(arr);

            Console.WriteLine("Min: {0}", min);
            Console.WriteLine("Max: {0}", max);
            Console.WriteLine("Average: {0}", mean);
        }

        public static int[] shiftValues(int[] arr)
        {
            for(int x = 1; x < arr.Length; x++)
            {
                if(x == arr.Length - 1)
                {
                    arr[x] = 0;
                }
                else
                {
                    arr[x-1] = arr[x];
                }
            }

            return arr;
        }

        public static List<object> numToString(int[] arr)
        {
            List<object> myList = new List<object>();
           for(int i = 0; i < arr.Length; i++)
           {
               if(arr[i] < 0)
               {
                   myList.Add("Dojo");
               }
               else
               {
                   myList.Add(arr[i]);
               }
           }

           return myList;
        }

        

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            printNum();
            Console.WriteLine();
            printOdd();
            Console.WriteLine();
            printSum();
            Console.WriteLine();
            itterateArray();
            Console.WriteLine();
            int[] myArr = {-3, 6, -2, 5, 9};
            Console.WriteLine(findMax(myArr));
            Console.WriteLine();
            Console.WriteLine(findAverage(myArr));
            int[] myArr2 = OddNumbers();
            foreach(int num in myArr2)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine();

            int[] myArr3 = squareValues(myArr);
            foreach(int num in myArr3)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine();
            int[] myArrNew = {-3, 6, -2, 5, 9};
            Console.WriteLine("Elim Neg");
            int[] elminNegArr = eliminateNegative(myArrNew);
            foreach(int x in elminNegArr)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine();
            
            minMaxAverage(myArrNew);

            Console.WriteLine();
            int[] myCoolArr = {1,5,10,7,-2};
            int[] myCoolArr1 = shiftValues(myCoolArr);
            foreach(int x in myCoolArr1)
            {
                Console.WriteLine(x);
            } 

            Console.WriteLine();

            int[] foo = {-1,-3,2};
            List<object> potato = numToString(foo);
            foreach(var q in potato)
            {
                Console.WriteLine(q);
            }
           
            
        }
    }
}
