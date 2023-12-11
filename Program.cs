namespace DotnetTrngDay1
{
    class Program
    {
        static void Main(string[] args)
        {
            //     Int128 a = 0;
            //     Int128 b = 1;
            //     Int128 i = 2;
            //     Int128 d = 0;

            //     while (i <= 100)
            //     {
            //         Int128 c = a + b;
            //         if (a % 2 == 0)
            //         {
            //             Console.WriteLine(a);
            //         }
            //         else
            //         {
            //             d = d + a;
            //         }
            //         a = b;
            //         b = c;
            //         i++;
            //     }
            //     Console.WriteLine(d);


            int[] nameArray = new int[5];
            Console.WriteLine("Enter elements in array");
            // for (int i = 0; i < nameArray.Length; i++)
            // {
            //     nameArray[i] = Convert.ToInt32(Console.ReadLine());
            // }

            // Console.WriteLine("Elements in array are:");
            // foreach (int x in nameArray)
            // {
            //     Console.WriteLine(x);
            // }

            int[,] multiArray = new int[2, 3];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    multiArray[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Elements in array are:");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine(multiArray[i, j]);
                }
            }
        }
    }
}