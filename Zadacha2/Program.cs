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
          