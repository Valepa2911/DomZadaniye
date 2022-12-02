Console.WriteLine("Ведите два числа: ");
int numberA = Convert.ToInt32(Console.ReadLine());
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA>numberB)
{
    Console.Write("Max-");
    Console.Write(numberA);
    Console.Write("Min-");
    Console.Write(numberB);

}
else
{
    Console.Write("Max-");
    Console.Write(numberB);
    Console.Write("Min-");
    Console.Write(numberA);
}