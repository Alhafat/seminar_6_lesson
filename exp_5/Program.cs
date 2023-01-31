// Задача 45: Напишите программу, которая будет создавать 
// копию заданного массива с помощью поэлементного 
// копирования.

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

int[] copyArray(int[] array)
{
    // var newArray = array.ToArray();
    int[] newArray=new int[array.Length];
    for (int i = 0; i < newArray.Length; i++)
    {
        newArray[i]=array[i];
    }
    return newArray;
}

int[] array=GetArray();
Console.WriteLine(string.Join(", ", array));

int[] reversed = copyArray(array);
Console.WriteLine(string.Join(", ", reversed));