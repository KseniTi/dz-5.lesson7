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

    int[,] numbers = new int[rows, colums];
    FillArray(numbers, -100, 100);
    PrintArray(numbers);
}

void FillArray(int[,] numbers, double minValue = 0, double maxValue = 9)
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

Zadacha47();