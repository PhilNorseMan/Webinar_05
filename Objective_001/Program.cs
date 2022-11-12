/* Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]*/

int[] CreateIntervalWithRandomNumbers(int numbers = 4, int startInterval = -9, int endInterval = 9)
{
    var result = new int[numbers];

    Random random = new();

    for (int i = 0; i < numbers; i++)
    {
        result[i] = random.Next(startInterval, endInterval + 1);
    }

    return result;
}

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

int[] ConvertPositiveNegativeNumbers(int[] arr)
{
    int[] arrayConvert = new int[arr.Length];
    
    for (int i = 0; i < arr.Length; i++)
    {
        arrayConvert[i] = arr[i] * -1;   
    }

    return arrayConvert;
}

var array = CreateIntervalWithRandomNumbers();
Console.WriteLine("Generated array:");
Print(array);

var arrayConvert = ConvertPositiveNegativeNumbers(array);
Console.WriteLine("Converted array:");
Print(arrayConvert);
