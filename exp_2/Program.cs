// Задача 40: Напишите программу, которая принимает на вход три 
// числа и проверяет, может ли существовать треугольник с сторонами 
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника 
// меньше суммы двух других сторон.



// int[] getArray()
// {
//     System.Console.WriteLine("Введите количество значений массива:");
//     int size=int.Parse(Console.ReadLine()!);
//     int [] array=new int[size];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i]= new Random().Next(1, 10);
//     }
//     return array; 
// }

// void summArray(int[] result)
// {
//     if (result[0] < result[1]+result[2])&&) 
//     {
//         System.Console.WriteLine("True");
//         i++;
//     }
//     else
//     if (numA < sum - numA && numB < sum - numB && numC < sum - numC) return true
//     // return true
//     // else return false
// }

// int[] result=getArray();
// System.Console.WriteLine(string.Join(", ", result));

int Input(string text)
{
    Console.Write($"{text}: ");
    int tempNum = int.Parse(Console.ReadLine()!);
    return tempNum;
}

int Check(int numA, int numB, int numC)
{
    int sum = numA + numB + numC;
    if (numA < sum - numA && numB < sum - numB && numC < sum - numC) return 1;
    else return 0;
}

void main()
{
    Console.Clear();
    int a = Input("Введите сторону A");
    int b = Input("Введите сторону B");
    int c = Input("Введите сторону B");
    int checkResult = Check(a, b, c);
    if (checkResult == 1) Console.Write($"Треугольник со сторонами {a}, {b} и {c} может существовать");
    else Console.Write($"Треугольник со сторонами {a}, {b} и {c} не может существовать");
}

main();