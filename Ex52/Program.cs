// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов");
int colum = Convert.ToInt32(Console.ReadLine());

int[,] numbers = new int[rows, colum];
GetMatrix(numbers);


for (int j = 0; j < numbers.GetLength(1); j++)
{
    double avarage = 0;
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        avarage = (avarage + numbers[i, j]);
    }
    avarage = Math.Round((avarage / rows), 2);
    Console.Write (avarage + "; \t");
}
Console.WriteLine();
PrintMatrix(numbers);


void GetMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++) // строчки
    {
        for (int j = 0; j < array.GetLength(1); j++) // столбцы
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
