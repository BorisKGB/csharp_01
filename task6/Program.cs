Console.WriteLine("Введите 1 число в числовом виде.");
Console.Write("Число: ");
// use Convert.ToInt32() instead int.Parse()
int number = Convert.ToInt32(Console.ReadLine());

// % -> остаток от деления

if(number % 2 == 0)
{
    Console.WriteLine($"Число {number} чётное");
}
else
{
    Console.WriteLine($"Число {number} нечётное");
}
