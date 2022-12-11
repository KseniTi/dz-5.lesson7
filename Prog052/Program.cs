/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 5 3
8 4 6 4

Среднее арифметическое каждого столбца: 4,6; 5,6; 6; 3.
*/

void Zadacha52()
{
    Console.WriteLine("Введите количество строк ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов ");
    int colums = Convert.ToInt32(Console.ReadLine());

    int[,] numbers = new int[rows, colums];
    FillArray(numbers, 0, 5);
    Console.WriteLine();
    PrintArray(numbers);
    Console.WriteLine();

    FindArray(numbers);

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

void FindArray(int[,] numbers)
{
    int rows = numbers.GetLength(0);
    int colums = numbers.GetLength(1);
    double summ = 0;
    for (int j = 0; j < colums; j++)
    {
        for (int i = 0; i < rows; i++)
        {
            summ += numbers[i, j];
        }
        Console.WriteLine($"Среднее арифметическое столбца {j}: {Math.Round(summ / rows, 1)}");
        summ = 0;
    }
}


Zadacha52();