// Напишите программу, которая на вход принимает значение элемента в двумерном массиве, и возвращает позицию этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.WriteLine("введите количество строк");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int b = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[a, b];
RandomNumber(array);
PrintArray(array);

Console.WriteLine("Введите координаты строки");
int c = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты столбца");
int d = Convert.ToInt32(Console.ReadLine());

if (c > a || d > b)
    Console.WriteLine("Такой координаты в таблице нет!");
else
{
    Console.WriteLine($"На указанных координатах располагается число: {array.GetValue(c,d)}");
}

void RandomNumber(int[,] array){
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
        array[i, j] = Convert.ToInt32(new Random().Next(-99, 100));
}}
void PrintArray(int[,] array){
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
        Console.Write($"{array[i, j],3}\t");
    Console.WriteLine();
}}