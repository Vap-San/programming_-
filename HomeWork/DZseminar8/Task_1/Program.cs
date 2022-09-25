//Задача 1: Задайте двумерный массив. Напишите программу, которая упорядочит 
//по убыванию элементы каждой строки двумерного массива.


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

//Вывод матрицы целых чисел
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



//Поиск максимального элемента в строке row массива
int[,] SortingRow(int[,] array, int row)
{

    for (int i = 0; i < array.GetLength(1) - 1; i++)
    {
        int jMax = i + 1;
        for (int j = i + 2; j < array.GetLength(1); j++)
        {
            if (array[row, jMax] < array[row, j]) jMax = j;
        }
        if (array[row, i] < array[row, jMax])
        {
            int temp = array[row, i];
            array[row, i] = array[row, jMax];
            array[row, jMax] = temp;
        }
    }
    return array;
}




//Сортировка каждой строки матрицы по убыванию
int[,] OrderingMatrices(int[,] array)
{
    for (int row = 0; row < array.GetLength(0); row++)
    {
        array = SortingRow(array, row);
    }
    return array;
}


//основная программа

int rowCount = Prompt("Введите количество строк матрицы -> ");
int colCount = Prompt("Введите количество столбцов матрицы -> ");
int[,] array = GenerateArray(rowCount, colCount, 0, 10);
PrintArray(array);
PrintArray(OrderingMatrices(array));

