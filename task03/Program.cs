// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("введите количество строк");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int b = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[a, b];
RandomNumbers(array);
PrintArray(array);
PrintSrAr(array);

void RandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = Convert.ToInt32(new Random().Next(0, 2));
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j],3} \t  ");
        }
        Console.WriteLine();
    }
}
void PrintSrAr(int[,] array)
{
    for (int i = 0; i < a; i++)
    {
        int srAr = 0;
        for (int t = 0; t < a; t++)
        srAr += array[t, i];
        Console.WriteLine($"Cреднее арифметическое элементов столбца {i + 1} = {(double)srAr / a}");
    }
}