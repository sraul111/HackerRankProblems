using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlusMinus
{
    class Program
    {
        static void plusMinus(int[] arr)
        {
            int p=0, z=0, n = 0;
            for (int i = 0; i < arr.Length; i++ )
            {
                if (arr[i] < 0)
                    n += 1;
                if (arr[i] == 0)
                    z += 1;
                if (arr[i] > 0)
                    p += 1;


            }
            Console.WriteLine(((double)p)/arr.Length);
            Console.WriteLine(((double) n)/ arr.Length);
            Console.WriteLine(((double)z)/ arr.Length);

            

            Console.Read();

        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
                
            plusMinus(arr);

            Console.Read();
        }
    }
}
