// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
//  Использовать рекурсию, не использовать циклы.

void PrintNum(int num1, int num2)        
{
    if (num1 > num2)
    {
        return; 
    }

    if (num1 == num2)
    {
        Console.Write($"{num1} ");
        return;
    }
    Console.Write($"{num1} ");
    PrintNum(num1 + 1, num2 );
    // Console.Write($"{num1} ");
}

Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
PrintNum(m,n);
