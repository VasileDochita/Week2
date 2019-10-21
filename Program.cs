using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrsSum
{
    class Program
    {


        static void Main(string[] args)
        {
            //ArrSum();
            //Average();
            //index();
            //palindrom();
            CommonElements();
            //InsertAtCertainIndex();
            //MinMax();
            //mergeArray();


            Console.ReadLine();

        }

        private static void ArrSum()
        {
            int[] number = new int[] { 20, 22, 66, 321, 9 };

            int sum = 0;
            for (int i = 0; i < number.Length; i++)
            {
                sum += number[i];
            }
            Console.WriteLine("The sum of the array is " + sum);
            Console.ReadLine();
        }

        private static void Average()
        {
            int[] number = new int[] { 20, 22, 66, 321, 9 };

            double sum = 0;
            double media = 0;
            for (int i = 0; i < number.Length; i++)
            {
                sum += number[i];
            }
            media = sum / number.Length;
            Console.WriteLine("The average of the array is " + media);
            Console.ReadLine();
        }

        private static void index()
        {
            int[] Array = { 22, 65, 33, 3, 4, 85, 96 };
            int Element = 85;


            for (int i = 0; i < Array.Length; i++)
            {
                if (Element == Array[i])
                {
                    int Index;

                    Index = i;
                    Console.WriteLine("Indexul numarului 85 este : " + Index);

                }

            }

        }

        private static void InsertAtCertainIndex()
        {
            int i = 0;
            int pos = 0;
            int item = 0;
            int[] arr = new int[10];


            Console.WriteLine("Enter numbers : ");

            for (i = 0; i < 5; i++)
            {
                Console.Write("Element[" + (i + 1) + "]: ");
                arr[i] = int.Parse(Console.ReadLine());
            }


            Console.Write("Enter position : ");
            pos = int.Parse(Console.ReadLine());

            Console.Write("Enter new item : ");
            item = int.Parse(Console.ReadLine());


            for (i = 4; i >= pos; i--)
            {
                arr[i] = arr[i - 1];
            }

            arr[pos - 1] = item;


            Console.WriteLine("Array elements after insertion : ");
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("Element[" + (i + 1) + "]: " + arr[i]);
            }

            Console.WriteLine();
        }

        private static void palindrom()
        {
            string cuvant;
            string cuvantIntors = string.Empty;
            Console.Write("Enter a word : ");
            cuvant = Console.ReadLine();
            if (cuvant != null)
            {
                for (int i = cuvant.Length - 1; i >= 0; i--)
                {
                    cuvantIntors += cuvant[i].ToString();
                }
                if (cuvantIntors == cuvant)
                {
                    Console.WriteLine("Your word is Palindrome : " + cuvant + "=" + cuvantIntors);
                }
                else
                {
                    Console.WriteLine("Your word is not Palindrome : " + cuvant + "---is different from---" + cuvantIntors);
                }
            }
            Console.ReadLine();
        }

        private static void CommonElements()
        {
            int[] sir1 = { 25, 33, 76, 55, 89, 12, 34 };
            Console.WriteLine("First array is : 25, 33, 76, 55, 89, 12, 34");
            int[] sir2 = { 76, 10, 11, 34, 13, 15 };
            Console.WriteLine("Second array is : 76, 10, 11, 34, 13, 15 ");
            for (int i = 0; i < sir1.Length; i++)
            {
                for (int j = 0; j < sir2.Length; j++)
                {
                    if (sir1[i] == sir2[j])
                    {
                        Console.WriteLine("Common elements are : " + sir1[i]);
                    }
                }
            }
        }



        private static void MinMax()
        {
            Console.WriteLine("Enter number of elements : ");
            int nrElemente = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the numbers of your array : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[n];
            int Min = numbers[0];
            int Max = numbers[0];



            for (int i = 1; i < n; i++)
            {

                Console.WriteLine("Enter number {0}", i + 1);
                numbers[i] = Convert.ToInt32(Console.ReadLine());

            }
            for (int i = 0; i < n; i++)
            {
                if (Min > numbers[i]) Min = numbers[i];
                if (Max < numbers[i]) Max = numbers[i];
            }
            Console.WriteLine("Maximum element = {0}", Max);
            Console.WriteLine("Minimum element = {0}", Min);
        }

        private static void mergeArray()
        {
            int[] sir1 = { 22, 55, 43, 12, 15 };
            int[] sir2 = { 11, 88, 90, 12, 14, 16 };

            Console.WriteLine("Array one :");
            foreach (int element in sir1)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine("Array two : ");
            foreach (int element in sir2)
            {
                Console.WriteLine(element);
            }
            var myList = new List<int>();
            myList.AddRange(sir1);
            myList.AddRange(sir2);
            int[] sir3 = myList.ToArray();
            Console.WriteLine("Combined array elements : ");
            foreach (int result in sir3)
            {
                Console.WriteLine(result);
            }

        }
    }
}
