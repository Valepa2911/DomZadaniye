﻿// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите Число: ");
int N = Convert.ToInt32(Console.ReadLine());
int num = 1;

while (num<N);

{ 
    if (num%2 == 0);
    Console.WriteLine("Четные" + num);
    num++;
}

    num++;