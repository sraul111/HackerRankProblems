﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVeryBigSum
{
    class Solution
    {
        protected Solution()
        {

        }
        // Complete the aVeryBigSum function below.
        static long aVeryBigSum(long[] ar)
        {
            if (ar.Length >10)
            { throw new ArgumentException("length of array is greater than 10");}
            for (int i = 0; i < ar.Length; i++)
            {
                if (ar[i] > (10 ^ 10))
                    throw new ArgumentException("an element of array is more than 10^10");

            }



            return ar.Sum();
        }

        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int arCount = Convert.ToInt32(Console.ReadLine());

            long[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt64(arTemp))
                ;
            long result = aVeryBigSum(ar);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
