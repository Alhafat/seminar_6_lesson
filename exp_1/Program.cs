// Задача 39: Напишите программу, которая перевернёт 
// одномерный массив (последний элемент будет на первом 
// месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

int [] GetArray()
{
    System.Console.WriteLine("Введите количество значений массива:");
    int size=int.Parse(Console.ReadLine()!);
    System.Console.WriteLine("Введите минимальное значение массива:");
    int minValue=int.Parse(Console.ReadLine()!);
    System.Console.WriteLine("Введите максимальное значение массива:");
    int maxValue=int.Parse(Console.ReadLine()!);
    int [] array=new int[size];
    for (int i=0; i<size; i++)
    {
        array[i]= new Random().Next(minValue,maxValue+1);
    }
    return array;
}

void ReverseArray(int[] inArray)
{
    for (int i = 0; i < inArray.Length; i++)
    {
        int temp=inArray[i];
        inArray[i]=inArray[inArray.Length-1-i];
        inArray[inArray.Length-1-i]=temp;
    }
}

int[] ReversArray2(int[] inArray)
{
    int[] result=new int[inArray.Length];
    for (int i = 0; i < inArray.Length; i++)
    {
        result[i]=inArray[inArray.Length-1-i];
    }
    return result;
}

int[] array=GetArray();
Console.WriteLine(string.Join(", ", array));
ReverseArray(array);
Console.WriteLine(string.Join(", ", array));
int[] reversed=ReversArray2(array);
Console.WriteLine(string.Join(", ", reversed));

// int[] GetArray(int size, int minValue, int maxValue)
// {
//     int[] res = new int[size];

//     for (int i = 0; i < size; i++)
//     {
//         res[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return res;
// }

// void ReversArray(int[] inArray)
// {
//     for (int i = 0; i < inArray.Length / 2; i++)
//     {
//         int temp = inArray[i]; 
//         inArray[i] = inArray[inArray.Length - 1 - i];
//         inArray[inArray.Length - 1 - i] = temp;
//     }
// }

// int[] ReversArray2(int[] inArray)
// {
//     int length = inArray.Length;
//     int[] result = new int[length];

//     for (int i = 0; i < length; i++)
//     {
//         result[i] = inArray[length - 1 - i];
//     }
//     return result;
// }

// int[] array = GetArray(10, 0, 10);
// Console.WriteLine(String.Join(" ", array));

// // ReversArray(array);
// // Console.WriteLine(String.Join(" ", array));
// int[] reversed = ReversArray2(array);
// Console.WriteLine(String.Join(" ", reversed));
// Console.WriteLine(String.J