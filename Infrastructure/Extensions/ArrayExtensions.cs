using Entities.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Infrastructure.Extensions
{
    public static class ArrayExtensions
    {
        public static async Task<int[]> GenerateAndFillArrayWithRandomNumbers(this int[] array)
        {
            await Task.Run(() =>
            {                
                Random random = new Random(DateTime.Now.Millisecond);
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = random.Next(0, 10);
                }
            }
                );
            
            return array;
        }

        public static async Task<int[]> BurbleSort(this int[] array)
        {
            if(array == null)
            {
                throw new ArrayException("El array es nulo, inicialza el array primero");
            }
               return await Task.Run(() =>
                {                   
                    for (int i = 0; i < array.Length; i++)
                    {
                        for (int j = 0; j < array.Length - 1; j++)
                        {
                            if (array[j + 1] < array[j])
                            {
                                int aux = array[j];
                                array[j] = array[j + 1];
                                array[j + 1] = aux;
                            }
                        }
                    }
                    return array;
                });                      
        }
        public static async  Task<int[]> Selection(this int[] array)
        {
            return await Task.Run(() =>
            {
                int aux, min;
                for (int i = 0; i < array.Length; i++)
                {
                    min = i;
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        if (array[j] > array[min])
                        {
                            min = j;
                        }
                    }
                    aux = array[i];
                    array[i] = array[min];
                    array[min] = aux;
                }
                return array;
            });
        }

        public static async Task<int[]> InsertionSort(this int[] array)
        {
            return await Task.Run(() =>
            {
                int pos, aux;
                for (int i = 0; i < array.Length; i++)
                {
                    pos = i;
                    aux = array[pos];
                    while (i > 0 && array[pos] > aux)
                    {
                        array[pos] = array[pos - 1];
                        pos--;
                    }
                    array[pos] = aux;
                }

                return array;
            });
        }

        public static async Task QuickSort(this int[] vector, int primero, int ultimo)
        {
            await Task.Run(async () =>
           {
               int i, j, central;
               double pivote;
               central = (primero + ultimo) / 2;
               pivote = vector[central];
               i = primero;
               j = ultimo;
               do
               {
                   while (vector[i] < pivote) i++;
                   while (vector[j] > pivote) j--;
                   if (i <= j)
                   {
                       int temp;
                       temp = vector[i];
                       vector[i] = vector[j];
                       vector[j] = temp;
                       i++;
                       j--;
                   }
               } while (i <= j);

               if (primero < j)
               {
                   await QuickSort(vector, primero, j);
               }
               if (i < ultimo)
               {
                   await QuickSort(vector, i, ultimo);
               }
           });       
        }

        public static async  Task<int[]> mergeSort(this int[] array)
        {
            return await Task.Run(async () =>
            {
                int[] left;
                int[] right;
                int[] result = new int[array.Length];
                //As this is a recursive algorithm, we need to have a base case to 
                //avoid an infinite recursion and therfore a stackoverflow
                if (array.Length <= 1)
                    return array;
                // The exact midpoint of our array  
                int midPoint = array.Length / 2;
                //Will represent our 'left' array
                left = new int[midPoint];

                //if array has an even number of elements, the left and right array will have the same number of 
                //elements
                if (array.Length % 2 == 0)
                    right = new int[midPoint];
                //if array has an odd number of elements, the right array will have one more element than left
                else
                    right = new int[midPoint + 1];
                //populate left array
                for (int i = 0; i < midPoint; i++)
                    left[i] = array[i];
                //populate right array   
                int x = 0;
                //We start our index from the midpoint, as we have already populated the left array from 0 to 

                for (int i = midPoint; i < array.Length; i++)
                {
                    right[x] = array[i];
                    x++;
                }
                //Recursively sort the left array
                left = await mergeSort(left);
                //Recursively sort the right array
                right = await mergeSort(right);
                //Merge our two sorted arrays
                result = await merge(left, right);
                return result;
            });
        }

        //This method will be responsible for combining our two sorted arrays into one giant array
        public static async  Task<int[]> merge(int[] left, int[] right)
        {
            return await Task.Run(() =>
            {
                int resultLength = right.Length + left.Length;
                int[] result = new int[resultLength];
                //
                int indexLeft = 0, indexRight = 0, indexResult = 0;
                //while either array still has an element
                while (indexLeft < left.Length || indexRight < right.Length)
                {
                    //if both arrays have elements  
                    if (indexLeft < left.Length && indexRight < right.Length)
                    {
                        //If item on left array is less than item on right array, add that item to the result array 
                        if (left[indexLeft] <= right[indexRight])
                        {
                            result[indexResult] = left[indexLeft];
                            indexLeft++;
                            indexResult++;
                        }
                        // else the item in the right array wll be added to the results array
                        else
                        {
                            result[indexResult] = right[indexRight];
                            indexRight++;
                            indexResult++;
                        }
                    }
                    //if only the left array still has elements, add all its items to the results array
                    else if (indexLeft < left.Length)
                    {
                        result[indexResult] = left[indexLeft];
                        indexLeft++;
                        indexResult++;
                    }
                    //if only the right array still has elements, add all its items to the results array
                    else if (indexRight < right.Length)
                    {
                        result[indexResult] = right[indexRight];
                        indexRight++;
                        indexResult++;
                    }
                }
                return result;
            });
        }

        public static int? SecuentialSearch(this int[] array, int numberToSearch)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == numberToSearch)
                {
                    return i;
                }
            }

            return null;
        }

        public static int? BinarySearch(this int[] array, int numberToSearch)
        {
            int low = 0;
            int high = array.Length - 1;
            while (low <= high)
            {
                int mid = (high + low);
                int guess = array[mid];

                if (guess == numberToSearch)
                {
                    return mid; //Elemento encontrado
                }
                if (guess > numberToSearch)
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid - 1;
                }
            }

            return null;
        }

    }
}
