//Задача 3.Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

//Вывод массива вещественных чисел
void PrintDoubleArray(double[] array)
{
    System.Console.Write("Средние значения по столбцам: ");
    foreach (var item in array)
    {
        System.Console.Write($"{item}  ");
    }
    System.Console.WriteLine();
}

//вычисление среднего значения в столбце
double CalculateAverageElementsCol(int[,] array, int col)
{
    int sum = array[0, col];
    for (int i = 1; i < array.GetLength(0); i++)
    {
        sum += array[i, col];
    }
    return (double)sum / array.GetLength(0);
}

//Заполнение массива средними значениями по столбцам матрицы
double[] FillArrayAverageElements(int[,] array)
{
    double[] AverageInCol = new double[array.GetLength(1)];
    for (int col = 0; col < array.GetLength(1); col++)
    {
        AverageInCol[col] = CalculateAverageElementsCol(array, col);
    }
    return AverageInCol;
}


//основная программа

int rowCount = Prompt("Введите количество строк матрицы -> ");
int colCount = Prompt("Введите количество столбцов матрицы -> ");
int[,] array = GenerateArray(rowCount, colCount, 0, 10);
PrintArray(array);
PrintDoubleArray(FillArrayAverageElements(array));

