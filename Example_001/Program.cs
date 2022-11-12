/* Задать массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
Найти сумму отрицательных и положительных элементов массива.
[3,9,-8,1,0,-7,2,-1,8,-3,-1,6] -> сумма положительных 29, сумма отрицательных -20.  */

int[] CreateIntervalWithRandomNumbers(int numbers = 12, int startInterval = -9, int endInterval = 9)
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

int SumPositiveNumbers(int[] arr)
{
    int result = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
            result += arr[i];
    }

    return result;
}

int SumNegativeNumbers(int[] arr)
{
    int result = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < 0)
            result += arr[i];
    }

    return result;
}

var array = CreateIntervalWithRandomNumbers();
Print(array);

var positiveSum = SumPositiveNumbers(array);
Console.WriteLine("Sum of positive numbers: " + positiveSum);

var negativeSum = SumNegativeNumbers(array);
Console.WriteLine($"Sum of negative numbers: {negativeSum}");