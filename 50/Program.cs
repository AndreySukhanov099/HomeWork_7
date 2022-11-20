//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет


Console.WriteLine("Введите количество строк  ");
int lineVolue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int ColumnsVolue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер строки  ");
int line = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца");
int Columns = Convert.ToInt32(Console.ReadLine());
int[,] array = GetArrayRandom(lineVolue, ColumnsVolue);
PrintArray(array);

if (line < lineVolue && Columns < ColumnsVolue) 
Console.WriteLine(array[line - 1, Columns - 1]);
else Console.WriteLine($"{line}{Columns} -> такого числа в массиве нет");

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

