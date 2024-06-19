using System;

namespace bookstuscks
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] mass = new string[5];
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = i.ToString();
                Console.WriteLine(mass[i]);
            }
            Console.WriteLine("___________________________________________________________");
            Console.ReadLine();

            int[] numbers = new int[3];
            numbers[0] = 1;
            numbers[1] = 3;
            numbers[2] = 15;
            int summ = 0;
            int max = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                summ = summ + numbers[i];
            }
            Console.WriteLine(summ);
            Console.WriteLine("___________________________________________________________");
            Console.ReadLine();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }
            Console.WriteLine(max);
            Console.WriteLine("___________________________________________________________");
            Console.ReadLine();


            string[,] map = new string[,]
                {
                    {"/ ", "\\", "/", " \\" },
                    {"\\", "  ", "  ","/" },
                    {" \\"," "," ", "/" },
                    {"  ","\\","/","  " }
                };
      
            

            for (int x = 0; x < map.GetLength(0); x++)
            {
                for (int y = 0; y < map.GetLength(1); y++)
                {
                    Console.Write(map[x,y]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("___________________________________________________________");
            Console.ReadLine();
        }
    }
}
