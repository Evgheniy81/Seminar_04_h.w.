/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

void PrintArray(int[] array)
{
    int N = array.Length;
    int index = 0;
    while (index<N)
    {
    array[index] = new Random().Next(-3, 10);
    index++;
    }
}
int [] array = new int [10];
PrintArray(array);
Console.Write($"Наш массив состоит из [{string.Join(", ", array)}]");

///////// Второй вариант
/*
Console.Write($"Данно множество случайных чисел: ");
int [] array = new int [8];

int N = array.Length;
    int index = 0;
    while (index<N)
    {
    array[index] = new Random().Next(1, 10);
    index++;
    }
Console.Write($"[{string.Join(". ", array)}]");
*/