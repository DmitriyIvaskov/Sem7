
//  Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает 
//  значение этого элемента или же указание, что такого элемента нет.
//  Во вводе первая цифра - номер строки, вторая - столбца. Цифры не больше 9.
//  Например, задан массив:
//  1 4 7 2
//  5 9 2 3
//  8 4 2 4
//  17 -> такого числа в массиве нет
 

Console.Write("Введите номер строки: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите номер cтолбца: ");
int colums = Convert.ToInt32(Console.ReadLine());

int [,] numbers = new int [5,5];
GetMatrix(numbers);

if (rows > numbers.GetLength(0) || colums > numbers.GetLength(1))
{
    Console.WriteLine("Такого номера нет!");
}
else
{
    Console.WriteLine($"Число индекса строки {rows} и индекса столбца {colums} равно {numbers[rows ,colums]}");
}

PrintArray(numbers);

void GetMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {        
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array [i,j] = new Random().Next(1, 10);
            }   
        }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }   
        Console.Write("]");
        Console.WriteLine(""); 
    }
}