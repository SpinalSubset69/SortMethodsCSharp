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
                    array[i] = random.Next();
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
                await Task.Run(() =>
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
                });

                return array;            
        }        
    }
}
