// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// функция ack(n, m)
//    пока n ≠ 0
//      если m = 0
//        m:= 1
//      иначе
//        m:= ack(n, m - 1)
//      n:= n - 1
//    вернуть m + 1

int Ack(int n, int m)
{
    while (n != 0)
    {
        if (m == 0) m = 1;
        else
        {
            m = Ack(n, m - 1);
        }
        n--;
    }
    return m + 1;
}

int ack1 = Ack(4, 0);
Console.WriteLine($"n = 4, m = 0 -> {ack1}");

int ack2 = Ack(3, 11);
Console.WriteLine($"n = 3, m = 11 -> {ack2}");