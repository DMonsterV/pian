namespace pian
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите октаву");
            Console.WriteLine("F3 - третья октава");
            Console.WriteLine("F4 - Четверта октава");
            Console.WriteLine("F5 - Пятая октава");
            ConsoleKeyInfo viboroctav = Console.ReadKey();

            while (viboroctav.Key != ConsoleKey.Escape)

            {
                if (viboroctav.Key == ConsoleKey.F3)
                {

                    vibor1();
                }

                if (viboroctav.Key == ConsoleKey.F4)
                {
                    vibor2();
                }

                if (viboroctav.Key == ConsoleKey.F5)
                {
                    vibor3();

                }
                Console.WriteLine("Выберите октаву");
                Console.WriteLine("F3 - третья октава");
                Console.WriteLine("F4 - Четверта октава");
                Console.WriteLine("F5 - Пятая октава");
                Console.WriteLine("Escape - Выйти из программы");
                ConsoleKeyInfo viboroctav2 = Console.ReadKey();
                viboroctav = viboroctav2;

            }

            static void volume(int octava)
            {
                Console.Beep(octava, 300);
            }
            static void vibor1()
            {
                int[] octava3 = new int[] { 130, 138, 146, 155, 164, 174, 185, 196, 207, 220, 233, 246 };
                Console.WriteLine(" Вы выбрали 3 октаву");
                ConsoleKeyInfo key = Console.ReadKey();
                while (key.Key != ConsoleKey.Escape)
                {
                    if (key.Key == ConsoleKey.A)
                    {
                        Console.Clear();
                        volume(octava3[0]);
                    }
                    if (key.Key == ConsoleKey.Z)
                    {
                        Console.Clear();
                        volume(octava3[1]);
                    }
                    if (key.Key == ConsoleKey.S)
                    {
                        Console.Clear();
                        volume(octava3[2]);
                    }
                    if (key.Key == ConsoleKey.X)
                    {
                        Console.Clear();
                        volume(octava3[3]);
                    }
                    if (key.Key == ConsoleKey.D)
                    {
                        Console.Clear();
                        volume(octava3[4]);
                    }
                    if (key.Key == ConsoleKey.C)
                    {
                        Console.Clear();
                        volume(octava3[5]);
                    }
                    if (key.Key == ConsoleKey.F)
                    {
                        Console.Clear();
                        volume(octava3[6]);
                    }
                    if (key.Key == ConsoleKey.V)
                    {
                        Console.Clear();
                        volume(octava3[7]);
                    }
                    if (key.Key == ConsoleKey.G)
                    {
                        Console.Clear();
                        volume(octava3[8]);
                    }
                    if (key.Key == ConsoleKey.B)
                    {
                        Console.Clear();
                        volume(octava3[9]);
                    }
                    if (key.Key == ConsoleKey.H)
                    {
                        Console.Clear();
                        volume(octava3[10]);
                    }
                    if (key.Key == ConsoleKey.N)
                    {
                        Console.Clear();
                        volume(octava3[11]);
                    }
                    ConsoleKeyInfo key2 = Console.ReadKey();
                    key = key2;
                }
            }

            static void vibor2()
            {
                int[] octava4 = new int[] { 261, 277, 293, 311, 329, 349, 370, 392, 415, 440, 466, 493 };
                Console.WriteLine("Вы выбрали 4 октаву");
                ConsoleKeyInfo key = Console.ReadKey();
                while (key.Key != ConsoleKey.Escape)
                {
                    if (key.Key == ConsoleKey.A)
                    {
                        Console.Clear();
                        volume(octava4[0]);
                    }
                    if (key.Key == ConsoleKey.Z)
                    {
                        Console.Clear();
                        volume(octava4[1]);
                    }
                    if (key.Key == ConsoleKey.S)
                    {
                        Console.Clear();
                        volume(octava4[2]);
                    }
                    if (key.Key == ConsoleKey.X)
                    {
                        Console.Clear();
                        volume(octava4[3]);
                    }
                    if (key.Key == ConsoleKey.D)
                    {
                        Console.Clear();
                        volume(octava4[4]);
                    }
                    if (key.Key == ConsoleKey.C)
                    {
                        Console.Clear();
                        volume(octava4[5]);
                    }
                    if (key.Key == ConsoleKey.F)
                    {
                        Console.Clear();
                        volume(octava4[6]);
                    }
                    if (key.Key == ConsoleKey.V)
                    {
                        Console.Clear();
                        volume(octava4[7]);
                    }
                    if (key.Key == ConsoleKey.G)
                    {
                        Console.Clear();
                        volume(octava4[8]);
                    }
                    if (key.Key == ConsoleKey.B)
                    {
                        Console.Clear();
                        volume(octava4[9]);
                    }
                    if (key.Key == ConsoleKey.H)
                    {
                        Console.Clear();
                        volume(octava4[10]);
                    }
                    if (key.Key == ConsoleKey.N)
                    {
                        Console.Clear();
                        volume(octava4[11]);
                    }
                    ConsoleKeyInfo key2 = Console.ReadKey();
                    key = key2;
                }
            }

            static void vibor3()
            {
                int[] octava5 = new int[] { 523, 554, 587, 622, 659, 698, 740, 784, 830, 880, 932, 987 };
                Console.WriteLine(" Вы выбрали 5 октаву");
                ConsoleKeyInfo key = Console.ReadKey();
                while (key.Key != ConsoleKey.Escape)
                {
                    if (key.Key == ConsoleKey.A)
                    {
                        Console.Clear();
                        volume(octava5[0]);
                    }
                    if (key.Key == ConsoleKey.Z)
                    {
                        Console.Clear();
                        volume(octava5[1]);
                    }
                    if (key.Key == ConsoleKey.S)
                    {
                        Console.Clear();
                        volume(octava5[2]);
                    }
                    if (key.Key == ConsoleKey.X)
                    {
                        Console.Clear();
                        volume(octava5[3]);
                    }
                    if (key.Key == ConsoleKey.D)
                    {
                        Console.Clear();
                        volume(octava5[4]);
                    }
                    if (key.Key == ConsoleKey.C)
                    {
                        Console.Clear();
                        volume(octava5[5]);
                    }
                    if (key.Key == ConsoleKey.F)
                    {
                        Console.Clear();
                        volume(octava5[6]);
                    }
                    if (key.Key == ConsoleKey.V)
                    {
                        Console.Clear();
                        volume(octava5[7]);
                    }
                    if (key.Key == ConsoleKey.G)
                    {
                        Console.Clear();
                        volume(octava5[8]);
                    }
                    if (key.Key == ConsoleKey.B)
                    {
                        Console.Clear();
                        volume(octava5[9]);
                    }
                    if (key.Key == ConsoleKey.H)
                    {
                        Console.Clear();
                        volume(octava5[10]);
                    }
                    if (key.Key == ConsoleKey.N)
                    {
                        Console.Clear();
                        volume(octava5[11]);
                    }
                    ConsoleKeyInfo key2 = Console.ReadKey();
                    key = key2;
                }
            }




        }
    }
}