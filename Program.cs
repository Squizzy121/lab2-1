using System;

namespace Lab2_1
{
    class Array
    {
        public int[,] array;
        public int n1;
        public int m1;

        public void CreateArray(int n, int m)
        {
            n1 = n;
            m1 = m;
            array = new int[n, m];
        }

    public void PrintArray()
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write("{0,3}", array[i, j]);
                }
                Console.WriteLine();
            }
        }
        public int FindMax()
        {
            int max = int.MinValue;
            for (int i = 0; i < array.GetLength(0); i++) 
            {
                for(int j=0;j<array.GetLength(1);j++)
                {
                    if (array[i,j]>max)
                    {
                        max = array[i, j];
                    }
                }
            }
            return max;
        }
        public int FindMin()
        {
            int min = int.MaxValue;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] <min)
                    {
                        min = array[i, j];
                    }
                }
            }
            return min;
        }
        public int this[int i,int j]
        {
            set
            {
                array[i, j] = value;
            }
            get
            {
                return array[i, j];
            }
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Array Sizes");
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            Array arr = new Array();
            arr.CreateArray(n,m);
            Random rand = new Random();
            for(int i=0;i<n;i++)
            {
                for(int j=0;j<m;j++)
                {
                    arr[i, j] = rand.Next(-10, 10);
                    Console.Write("{0,3}", arr[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("{0}  {1}", arr.FindMin(), arr.FindMax());
        }
    }
}
