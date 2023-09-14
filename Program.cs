namespace _8_ministers
{
    internal class Program
    {

        static void validator(int i, int j, int[,] a)
        {
            int jp = 0;
            int ip = 0;
            a[i, j] = 1;
            for (jp = 0; jp <= 7; ++jp)
            {
                a[i, jp] = 1;
            }
            for (ip = 0; ip <= 7; ip++)
            {
                a[ip, j] = 1;
            }
            ip = i;
            jp = j;

            while (ip < 7 && jp < 7)
            {
                ip++;
                jp++;
                a[ip, jp] = 1;
            }
            
            ip = i;
            jp = j;
            while (ip > 0 && jp > 0)
            {
                ip--;
                jp--;
                a[ip, jp] = 1;
            }

        }
        static void NullFinder(int i, int j, int[,] a)
        {
            while (a[i, j] != 0)
            {
                for (i = 0; i < 7; i++)
                {
                    for (j = 0; j < 7; j++)
                    {
                        if (a[i, j] == 0)
                            break;
                    }
                    if (a[i, j] == 0) break;
                }
                if ((a[i, j] == 0)) break;
            }
        }

        static void Main(string[] args)
        {
            int numberator = 0;

            
            for (int i = 0; i <= 7; i++)
            {
                for (int j = 0; j <= 7; j++)
                {
                    int[,] a = new int[8, 8];
                    validator(i, j, a);
                    int i2 = 0;
                    int j2 = 0;
                    NullFinder(i2, j2, a);
                    a[i2, j2] = 1;
                    validator(i2, j2, a);
                    int i3 = 0;
                    int j3 = 0;
                    NullFinder(i3, j3, a);
                    a[i3, j3] = 1;
                    validator(i3, j3, a);
                    int i4 = 0;
                    int j4 = 0;
                    NullFinder(i4, j4, a);
                    a[i4, j4] = 1;
                    validator(i4, j4, a);
                    int i5 = 0;
                    int j5 = 0;
                    NullFinder(i5, j5, a);
                    a[i5, j5] = 1;
                    validator(i5, j5, a);
                    int i6 = 0;
                    int j6 = 0;
                    NullFinder(i6, j6, a);
                    a[i6, j6] = 1;
                    validator(i6, j6, a);
                    int i7 = 0;
                    int j7 = 0;
                    NullFinder(i7, j7, a);
                    a[i7, j7] = 1;
                    validator(i7, j7, a);
                    int i8 = 0;
                    int j8 = 0;
                    NullFinder(i8, j8, a);
                    a[i8, j8] = 1;
                    validator(i8, j8, a);
                    numberator++;
                    Console.Clear();
                    Console.WriteLine(numberator);
                    



                }
            }
            Console.ReadKey();
        }
    }
}