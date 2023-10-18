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
    int sum = 0;
    if (numM < numN)
    {
        sum += numM;
        if (numM == numN) return sum;
        return sum + SumDigit(numM + 1, numN);
    }

    else
    {   
        sum += numM;
        if (numM == numN) return sum;
        return sum + SumDigit(numM - 1, numN);
    }
}

int sum1 = SumDigit(numberM, numberN);

Console.WriteLine($"M = {numberM}; N = {numberN} -> {sum1}");

// Я так и не смог сделать без переменной "sum". Если не сложно напишите код.