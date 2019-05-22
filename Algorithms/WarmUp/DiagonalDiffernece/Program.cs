using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagonalDifference
{
    class Solution
    {

        // Complete the diagonalDifference function below.
        static int diagonalDifference(int[][] arr, int n)
        {
            
            int d1 = 0, d2 = 0;
            for (int i = 0; i < n; i++)
            {
                        d1 += arr[i][i];
                        d2 += arr[i][n - i - 1];

            }

            return Math.Abs(d1 - d2);
        }

        static void Main(string[] args)
        {
           // TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine());

            int[][] arr = new int[n][];

            for (int i = 0; i < n; i++)
            {
                arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            }

            int result = diagonalDifference(arr,n);

            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
