/*
Задача 50. Напишите программу, которая на вход принимает индексы элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

1, 3 -> 3
*/

void Zadacha50()
{
    Console.WriteLine("Введите количество строк ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов ");
    int colums = Convert.ToInt32(Console.ReadLine());

    int[,] numbers = new int[rows, colums];
    FillArray(numbers, -100, 100);
    Console.WriteLine();
    PrintArray(numbers);
    Console.WriteLine();

    Console.WriteLine("Введите номер строки ");
    int valueRows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите номер столбца ");
    int valueColums = Convert.ToInt32(Console.ReadLine());
    FindNumber(numbers, valueRows, valueColums);
}

void FillArray(int[,] numbers, int minValue = 0, int maxValue = 9)
{
    maxValue++;
    Random rand = new Random();
    int rows = numbers.GetLength(0);
    int colums = numbers.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            numbers[i, j] = rand.Next(minValue, maxValue);
        }
    }
}

void PrintArray(int[,] numbers)
{
    int rows = numbers.GetLength(0);
    int colums = numbers.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            Console.Write($"{numbers[i, j]}\t");
        }
        Console.WriteLine();
    }
}

void FindNumber(int[,] numbers, int valueRows, int valueColums)
{
    int rows = numbers.GetLength(0);
    int colums = numbers.GetLength(1);
    int count = 0;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            if (i == valueRows && j == valueColums)
            {
                Console.WriteLine("Число: " + numbers[i, j]);
                count++;
            }
        }
    }
    if (count == 0) Console.WriteLine("Такого элемента нет");
}

Zadacha50();