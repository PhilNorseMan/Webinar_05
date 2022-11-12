/*Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
3; массив [6, 7, 19, 345, 3] -> да*/

/*void FillRandomArray(int[] arr) 
{
    int length = arr.Length;
    int index = 0;
    while (index < length)
    {
        arr[index] = new Random().Next(-999, 999); 
        index++; 
    }
}*/

void Print(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i]);

        if (i != arr.Length - 1)
            Console.Write(" | ");
    }

    Console.WriteLine();
}

void FindNumberYesNo(int[] arr, int find)
{
    int index = 0;
    
    while (index < arr.Length)
    {
        if (arr[index] == find)
        {
            Console.WriteLine("Yes");
            break;
        }
        else
        {
            index++;
        }
    }
    if (index == arr.Length)
        Console.WriteLine("No");
}

Console.WriteLine("Number to find:");
int userNumber = int.Parse(Console.ReadLine()!);

int[] array = { 6, 7, 19, 345, 3 };
Console.WriteLine("Array is:");
Print(array);

FindNumberYesNo(array, userNumber);

