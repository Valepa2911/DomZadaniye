//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите два числа: ");
            int numA = Convert.ToInt32(Console.ReadLine());
            int numB = Convert.ToInt32(Console.ReadLine());

            if (numA > numB)
            {
                Console.WriteLine("Max: " + numA + " Min: " + numB);
            }
            else
            {
                Console.WriteLine("Max: " + numB + " Min: " + numA);
            }
          