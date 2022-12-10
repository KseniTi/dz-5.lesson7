/*
Задача 47. Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами, округлёнными до одного знака.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

void Zadacha47()
{
    Console.WriteLine("Введите количество строк ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов ");
    int colums = Convert.ToInt32(Console.ReadLine());

    double[,] numbers = new double[rows, colums];
    FillArray(numbers, -5, 10);
    PrintArray(numbers);
}

void FillArray(double[,] numbers, int minValue, int maxValue)
{
    minValue = -minValue;
    Random rand = new Random();
    int rows = numbers.GetLength(0);
    int colums = numbers.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            numbers[i, j] = Math.Round(rand.NextDouble() * maxValue - minValue, 1);
        }
    }
}

void PrintArray(double[,] numbers)
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

Zadacha47();