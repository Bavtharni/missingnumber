using System;

namespace ConsoleApp4
{
    class Program
    {
       static  int GetMissingNo(int[] a, int n)
        {
            int total = (n + 1) * (n + 2) / 2;

            int sum = findingsum(a);

                return total -= sum; 
            }
       static  int findingsum(int[] a)
        {
            int sumvalue = 0;
            for (int i = 0; i < a.Length; i++)
                sumvalue = sumvalue + a[i];
            return sumvalue;

                }

                /* program to test above function */
                public static void Main()
            {
                int[] A = { 1, 2, 4, 5, 6 };
            
                int miss = GetMissingNo(A, 5);
                Console.Write(miss);
            }
        }
    }
    

