using System;
using System.Diagnostics;
using System.Threading;
using System.Linq;

namespace Algorithms
{
    public class Algorithm
    {

        public int[] Randomize(int n)
        {
            Random rnd = new Random();
            int[] rand = new int[n];
            for (int i = 0; i < n; i++)
            {
                int number = rnd.Next(10*n+1);
                rand[i] = number;
            }

            return rand;
        }

        public int[] Prepare(int n)
        {
            int[] list_empty = new int[n];

            return list_empty;
        }

        public void Insertion_sort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (arr[j - 1] > arr[j])
                    {
                        int temp = arr[j - 1];
                        arr[j - 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }

        public void Selection_sort(int[] arr)
        {
            int i, j, min;
            
            for (i = 0; i < arr.Length; i++)
            {
                min = i;
                for (j = 0; j < arr.Length; j++)
                {
                    if (arr[j] > arr[min])
                    {
                        min = j;
                        Swapp(ref arr[i], ref arr[min]); 
                    }
                }
            }
        }
        private void Swapp(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        public void Bubble_sort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = arr.Length - 1; j > i; j--)
                {
                    if (arr[j] < arr[j - 1])
                    {
                        Swapp(ref arr[j], ref arr[j - 1]);
                    }
                }
            } 
        }

        public void MergeSort(int[] arr, int left, int right)
        { 

            if (left < right)
            {
                int middle = (left + right) / 2;

                MergeSort(arr, left, middle);
                MergeSort(arr, middle + 1, right);

                Merge(arr, left, middle, right);
            }  
        }
        

        private void Merge(int[] input, int left, int middle, int right)
        {
            int[] leftArray = new int[middle - left + 1];
            int[] rightArray = new int[right - middle];

            Array.Copy(input, left, leftArray, 0, middle - left + 1);
            Array.Copy(input, middle + 1, rightArray, 0, right - middle);

            int i = 0;
            int j = 0;
            for (int k = left; k < right + 1; k++)
            {
                if (i == leftArray.Length)
                {
                    input[k] = rightArray[j];
                    j++;
                }
                else if (j == rightArray.Length)
                {
                    input[k] = leftArray[i];
                    i++;
                }
                else if (leftArray[i] <= rightArray[j])
                {
                    input[k] = leftArray[i];
                    i++;
                }
                else
                {
                    input[k] = rightArray[j];
                    j++;
                }
            } 
        }

        public void QuickSort(int[] arr, int start, int end)
        {
            
            int i;
            if (start < end)
            {
                i = Partition(arr, start, end);

                QuickSort(arr, start, i - 1);
                QuickSort(arr, i + 1, end);
            }
            
        }

        private int Partition(int[] arr, int start, int end)
        {
            int temp;
            int p = arr[end];
            int i = start - 1;

            for (int j = start; j <= end - 1; j++)
            {
                if (arr[j] <= p)
                {
                    i++;
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
    
            temp = arr[i + 1];
            arr[i + 1] = arr[end];
            arr[end] = temp;
            return i + 1;
        }
        public void Lambda(int[] arr)
        {   //lambda sort. list created 
            var list = arr.Select(i => i).ToList();
            list.Sort();  
        }
        //delegate create
        public delegate void point (int[] arr);

        public delegate void point_multi(int[] arr, int left, int right);
       
        public double Running(int[] arrai, point einfach)
            {// time measurement for delegated functions that only have the array as input parameter
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            einfach.Invoke(arrai);
    
            stopwatch.Stop();
            double erg = stopwatch.Elapsed.TotalMilliseconds * 1000; 
            return erg;
            }
        
        public double Runnings(int[] arrai, point_multi einfacher)
        {   //time measurement for delegated functions that have three input parameters 
            //providing the extra input parameters to the delegate einfacher
            int k = 0;
            int l = arrai.Length - 1;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
 
            einfacher.Invoke(arrai,k , l);
       
            stopwatch.Stop();
            
            var el = stopwatch.Elapsed.TotalMilliseconds*1000;
            
            return el;
        }
    }
}
