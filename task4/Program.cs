Console.WriteLine("Введите 3 числа в числовом виде.");
Console.Write("Первое число: ");
// use Convert.ToInt32() instead int.Parse()
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Второе число: ");
int numB = Convert.ToInt32(Console.ReadLine());
Console.Write("Третье число: ");
int numC = Convert.ToInt32(Console.ReadLine());

int maxNum = numA;

if(numB > maxNum)
{
    maxNum = numB;
}
if(numC > maxNum)
{
    maxNum = numC;
}

Console.WriteLine($"Из введённых чисел максимальным оказалось {maxNum}");
