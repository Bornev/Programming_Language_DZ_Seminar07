// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

Random rnd = new Random();

int[] FiilArray(int[] arr, int index)
{
    if (index < arr.Length)
    {
        arr[index] = rnd.Next(1, 21);
        // Console.Write(arr[index] + " ");      
        arr = FiilArray(arr, index + 1);
    }
    return arr;
}

void PrintArray(int[] arr, int index = 0)
{
    if (index < arr.Length)
    {
        PrintArray(arr, index + 1);
        Console.Write(arr[index] + " ");
    }
}

Console.Write("Введите размер массива: ");
int numbers = Convert.ToInt32(Console.ReadLine());
int[] array = new int[numbers];
FiilArray(array, 0);
// Console.WriteLine();  
PrintArray(array);
