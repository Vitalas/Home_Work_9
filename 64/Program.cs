// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Write("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 1)
{
    Console.WriteLine("Некорректный ввод!");
    return;
}
Console.Write($"N = {number} -> \"");
void PrintNaturalNumbers(int num)
{
    int number1 = number;
    if (num == 1) return;
    Console.Write($"{num}, ");
    PrintNaturalNumbers(num - 1);
}

PrintNaturalNumbers(number);
Console.WriteLine("1\"");