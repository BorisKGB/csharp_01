Console.WriteLine("Введите 2 числа в числовом виде.");
Console.Write("Первое число: ");
// use Convert.ToInt32() instead int.Parse()
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Второе число: ");
int numB = Convert.ToInt32(Console.ReadLine());

if(numA > numB)
{
    Console.WriteLine($"Первое число {numA} больше чем второе {numB}");
}
else if(numA == numB)
{
    Console.WriteLine($"Числа {numA} и {numB} равны");
}
else
{
    Console.WriteLine($"Второе число {numB} больше чем первое {numA}");
}
