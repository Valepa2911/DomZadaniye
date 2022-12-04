// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Введите Число: ");
int numA = Convert.ToInt32(Console.ReadLine());

if (numA%2 == 0)
Console.WriteLine("Четное");

else

Console.WriteLine("Нечетное");
