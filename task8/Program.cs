Console.WriteLine("Введите 1 число в числовом виде.");
Console.Write("Число: ");
// use Convert.ToInt32() instead int.Parse()
int number = Convert.ToInt32(Console.ReadLine());

int i = 2;

Console.WriteLine($"Чётные числа от 1 до {number}:");

while(i <= number)
{
    Console.Write($"{i} ");
    i += 2;
}
// В конце выводим пустую строку чтобы сделать перенос строки в терминале
Console.WriteLine();
