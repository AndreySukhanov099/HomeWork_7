//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Введите количество строк  ");
int lineVolue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int ColumnsVolue = Convert.ToInt32(Console.ReadLine());

int[,] array = GetArrayRandom(lineVolue, ColumnsVolue);
PrintArray(array);
ArithmeticMeanColumns(array);

int [,] GetArrayRandom(int lineVolue, int ColumnsVolue, int minValue = 0, int maxValue = 10)
{
    int[,] array = new int[lineVolue, ColumnsVolue];
    var rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j =0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(minValue, maxValue );
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void ArithmeticMeanColumns(int[,] array)
{
for (int i = 0; i < array.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum = sum + array[j,i];
        }
        Console.Write($"{ sum / array.GetLength(0)} ");
    }
}