/*Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21*/

int[] ArrayByString()
{
    Console.WriteLine("");

NewInput:

    Console.WriteLine("Please, input your numbers (!!! Separate them by commas!!!):");

    string str = Console.ReadLine()!;
    string[] strSep = str.Split(',');

    int[] result = new int[strSep.Length];

    for (int i = 0; i < strSep.Length; i++)
    {
        string temp = strSep[i].Trim();

        if (int.TryParse(temp, out int tempInt))
        {
            result[i] = tempInt;
        }
        else
        {
            Console.WriteLine($"ERROR: Incorrect input! (Symbol {i +1})");

            goto NewInput;
        }
    }

    return result;
}

void PrintArray(int[] arr)
{
    int count = arr.Length;
    int position = 0; 
    while (position < count)
    {
        Console.Write (arr[position] + " | "); 
        position++;         
    }
}

void ProductPairMirror(int[] arr) //зеркальное перемножение массива
{
    if(arr.Length % 2 == 0)
    {
        int frontCountEven = 0;
        int rearCountEven = arr.Length - 1;
        int centreEven = arr.Length / 2;
        int[] result = new int[arr.Length / 2];
        int index = 0;
   
        while(frontCountEven < centreEven && rearCountEven >= centreEven)
        {
            result[index] = arr[frontCountEven] * arr[rearCountEven];
            frontCountEven = frontCountEven+1;
            rearCountEven = rearCountEven-1;
            index++;      
        }
        Console.WriteLine("Result of operation is:");
        PrintArray(result);
    }
    else
    {
        int frontCountOdd = 0;
        int rearCountOdd = arr.Length - 1;
        int centreOdd = arr.Length / 2;
        int[] result = new int[arr.Length / 2 + 1];
        result[result.Length - 1] = arr[arr.Length / 2];
        int index = 0;
   
        while(frontCountOdd < centreOdd && rearCountOdd > centreOdd)
        {
            result[index] = arr[frontCountOdd] * arr[rearCountOdd];
            frontCountOdd = frontCountOdd + 1;
            rearCountOdd = rearCountOdd - 1;
            index++;      
        }
        Console.WriteLine("Result of operation is:");
        PrintArray(result);
    }


       
}



int[] array = ArrayByString();

PrintArray(array);
ProductPairMirror(array);


