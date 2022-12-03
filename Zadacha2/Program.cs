Console.WriteLine("Ведите два числа: ");
int numberA = Convert.ToInt32(Console.ReadLine());
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA>numberB)
{
    Console.Write("Max-" + numberA);
       Console.Write("Min-" + numberB);
   

}
else
{
    Console.Write("Max-" + numberB);
        Console.Write("Min-" + numberA);
}