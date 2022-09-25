//Задача 2: Задайте прямоугольный двумерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов.

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


//вычисление суммы в строке row матрицы
int CalculatingSumRow(int[,] array, int row)
{
    int sum = array[row, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sum += array[row, j];
    }
    return sum;
}

//Заполнение массива суммами по строкам матрицы
int[] FillArraySumRows(int[,] array)
{
    int[] SumInRow = new int[array.GetLength(0)];
    for (int row = 0; row < array.GetLength(0); row++)
    {
        SumInRow[row] = CalculatingSumRow(array, row);
        System.Console.WriteLine($" Сумма в строке {row+1} -> {SumInRow[row]}");
    }
    return SumInRow;
}

//Поиск номера строки с наименьшей суммой
int SeachRowMinSumInArray(int[] array)
{
    int iMax = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[iMax] > array[i]) iMax = i;
    }
    return iMax+1;
}


//основная программа

int rowCount = Prompt("Введите количество строк матрицы -> ");
int colCount = Prompt("Введите количество столбцов матрицы -> ");
int[,] array = GenerateArray(rowCount, colCount, 0, 10);
PrintArray(array);

System.Console.Write($"Строка с наименьшей суммой элементов -> {SeachRowMinSumInArray(FillArraySumRows(array))}");

