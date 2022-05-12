using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Searching_Array_In_Even_And_Odd_Number
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = new int[6];

            for (int i = 0; i < 6; i++)
            {
                Console.Write("Enter the value of array:");
                arr[i] = int.Parse(Console.ReadLine());

            }

            Console.Write("my array:");
            for (int j = 0; j < 6; j++)
            {
                Console.Write(" " + arr[j]);
            }

            Console.WriteLine();
            Console.WriteLine("Enter The Any No Of Array");
            Console.Write("search No Even And Odd :");
            int search = int.Parse(Console.ReadLine());

            bool flag = false;
            for (int p = 0; p < 6; p++)
            {
                if (arr[p] == search)
                {
                    flag = true;
                    break;
                }
            }

            if (flag == true)
            {
                Console.WriteLine("No is  Avilable :");

                if (search % 2 == 0)
                {
                    Console.WriteLine("Even number : " + search);
                }
                else
                {
                    Console.WriteLine("Odd : " + search);
                }
            }
            else
            {
                Console.Write("No is Not Avilable. ? ");
            }


            Console.ReadLine();
        }
    }
}
