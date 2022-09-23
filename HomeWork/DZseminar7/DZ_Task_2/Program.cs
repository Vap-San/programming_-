//Задача 2.Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//1, 7->такого числа в массиве нет


int Prompt(string message)
{
    Console.Write(message);
    bool isDigit = int.TryParse(Console.ReadLine(), out int number);
    if (isDigit)
    {
        return number;
    }
    throw new Exception("Вы ввели не число");
}

//Генерация матрицы
int[,] GenerateArray(int rowLength, int colLength, int minRange, int maxRange)
{
    var array = new int[rowLength, colLength];
    var random = new Random();
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(minRange, maxRange + 1);
        }
    }
    return array;
}

//Вывод матрицы
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}\t");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

//проверка существования элемента в матрице с заданными индексами/ 
void SeachElement(int[,] array, int row, int col)
{
    if ((row > 0 && row <= array.GetLength(0)) && (col > 0 && col <= array.GetLength(1)))
    {
        System.Console.WriteLine($"array[{row},{col}] = {array[row - 1, col - 1]}");
    }
    else
    {
        System.Console.WriteLine($"Элемента с индексами [{row},{col}] в массиве нет");
    }
}



//основная программа

int rowCount = Prompt("Введите количество строк матрицы -> ");
int colCount = Prompt("Введите количество столбцов матрицы -> ");
int[,] array = GenerateArray(rowCount, colCount, 0, 10);
PrintArray(array);
int rowNumber = Prompt("Введите номер строки элемента матрицы -> ");
int colNumber = Prompt("Введите номер столбца элемента матрицы -> ");
SeachElement(array, rowNumber, colNumber);

