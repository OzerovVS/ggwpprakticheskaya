while (true)
{
    try
    {
        Console.Clear();
        Console.WriteLine("Выберите программу, которую хотите запустить: ");
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("1. Угадай число");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("2. Таблица умножения");
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("3. Вывод делителей числа");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("4. Закрыть программу");
        Console.ForegroundColor = ConsoleColor.Green;
        int g = Convert.ToInt32(Console.ReadLine());
        if (g == 1)
        {
            Console.ResetColor();
            Console.WriteLine("Необходимо угадать число находящееся в дапазоне от 1 до 100");
            Random r = new Random();
            int b = r.Next(1, 101);
            int c;
            do
            {
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Green;
                c = Convert.ToInt32(Console.ReadLine());
                if (c > 100)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Вы ввели число больше 100,пожалуйста введите число меньше 100");
                    continue;

                }
                if (c < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Вы ввели число меньше 0, пожалуйста введите число больше 0");
                    continue;
                }
                if (c == b)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Вы угадали. Поздравляем!");
                    Thread.Sleep(5000);
                    break;
                }
                if (c > b)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Нужно меньше");
                    continue;
                }
                if (c < b)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Нужно больше");
                }
            }
            while (c != b);
            continue;
        }
        if (g == 2)
        {
            Console.WriteLine("Таблица умножения: ");
            Console.ResetColor();
            while (true)
            {
                int[,] c = new int[9, 9]
                {
                        {1,2,3,4,5,6,7,8,9},
                        {2,4,6,8,10,12,14,16,18},
                        {3,6,9,12,15,18,21,24,27},
                        {4,8,12,16,20,24,28,32,36},
                        {5,10,15,20,25,30,35,40,45},
                        {6,12,18,24,30,36,42,48,54},
                        {7,14,21,28,35,42,49,56,63},
                        {8,16,24,32,40,48,56,64,72},
                        {9,18,27,36,45,54,64,72,81}
                };
                for (int m = 0; m < c.GetLength(0); m++)
                {
                    for (int n = 0; n < c.GetLength(1); n++)
                    {
                        if (c[m, n] < 10)
                        {
                            Console.Write(c[m, n] + "    ");
                        }
                        else
                        {
                            Console.Write(c[m, n] + "   ");
                        }
                    }
                    Console.WriteLine();
                }
                Thread.Sleep(5000);
                break;
            }
        }
        if (g == 3)
        {
            while (true)
            {
                Console.ResetColor();
                Console.WriteLine("Введите число, которого Вы хотите узнать делители");
                Console.ForegroundColor = ConsoleColor.Green;
                int a = Convert.ToInt32(Console.ReadLine());
                for (int i = a; i > 0; i--)
                {
                    {
                        if (a % i == 0)
                        {
                            Console.Write(a / i + " ");
                        }
                    }
                }
                Thread.Sleep(5000);
                break;
            }
        }
    }
    catch
    {
        Console.WriteLine("Значение нужно ввести с помощью цифр...");
        Thread.Sleep(1000);
        Environment.Exit(0);
    }
}