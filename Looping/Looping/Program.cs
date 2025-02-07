namespace Looping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = { { 0, 1, 2 }, { 3, 4, 5 }, { 6, 7, 8, } };
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}                     

