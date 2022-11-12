/*Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5*/

void FillArray(int[] arr) 
{
    int index = 0;
    while (index < arr.Length)
    {
        arr[index] = new Random().Next(0, 123);
        index++;
    }
}

int FindElementsFromTill(int[] arr, int startFind, int endFind)
{
    int result = 0;
    int index = 0;
    while (index < arr.Length)
    {
        if (arr[index] > startFind && arr[index] < endFind)
            result++;

        index++;
    }
    
    return result;
}

Console.WriteLine("Please, set borders for search:");
Console.WriteLine("Set bottom value:");
int start = int.Parse(Console.ReadLine()!);

Console.WriteLine("Set upper value:");
int end = int.Parse(Console.ReadLine()!);

int[] array = new int[123];

FillArray(array);
int result = FindElementsFromTill(array, start, end);

Console.WriteLine($"Number of numbers between {start} and {end} is {result}.");
