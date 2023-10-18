// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. 
// Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введитеи первое натуральное число (M): ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введитеи второе натуральное число (N): ");
int numberN = Convert.ToInt32(Console.ReadLine());

if (numberM < 1 || numberN < 1)
{
    Console.WriteLine("Некорректный ввод!");
    return;
}

int SumDigit(int numM, int numN)
{
    if (numM < numN)
    {
        if (numM == numN) return numN;
        return numM + SumDigit(numM + 1, numN);
    }

    else
    {
        if (numM == numN) return numN;
        return numM + SumDigit(numM - 1, numN);
    }
}

int sum = SumDigit(numberM, numberN);

Console.WriteLine($"M = {numberM}; N = {numberN} -> {sum}");