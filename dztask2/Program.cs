// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// using System.Numerics;
// BigInteger Ack(BigInteger m, BigInteger n)

long Ack(long m, long n)

{
    if (m == 0) return n + 1;

    else if (m > 0 && n == 0)
    {
        return Ack(m - 1, 1);
    }
    else if (m > 0 && n > 0)
    {
        return Ack(m - 1, Ack(m, n - 1));
    }
    return n;
}

Console.Write("Введите число m: ");
long m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
long n = Convert.ToInt32(Console.ReadLine());

Console.Write(Ack(m, n));