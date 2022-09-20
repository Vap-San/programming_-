//Задача 3: (*)
//Найдите максимальное значение в матрице по каждой строке, получите сумму этих максимумов. 
//Затем найдите минимальное значение по каждой колонке,получите сумму этих минимумов. 
//Затем из первой суммы (с максимумами) вычтите вторую сумму(с минимумами)
//1 2 3
//3 4 5
//3+5=8, 1+2+3=6, 8-6=2

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

//Поиск максимального элемента в строке row массива
int SeachMaximumElementRow(int[,] array, int row)
{
    int max = array[row, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        if (max < array[row, j]) max = array[row, j];
    }
    System.Console.WriteLine($"max array[{row}] = {max} ");
    return max;
}

//Поиск минимального элемента в столбце col массива
int SeachMinimumElementCol(int[,] array, int col)
{
    int min = array[0, col];
    for (int i = 1; i < array.GetLength(0); i++)
    {
        if (min > array[i, col]) min = array[i, col];
    }

    System.Console.WriteLine($"min array[{col}] = {min} ");
    return min;
}

//Посчет суммы максимумов в строках
int СountingSumMaxRows(int[,] array)
{
    int sum = 0;
    for (int iRow = 0; iRow < array.GetLength(0); iRow++)
    {
        sum += SeachMaximumElementRow(array, iRow);
    }
    System.Console.WriteLine($"SumMax = {sum}");
    return sum;
}

//Посчет суммы минисмумов в столбцах
int СountingSumMinCols(int[,] array)
{
    int sum = 0;
    for (int iCol = 0; iCol < array.GetLength(1); iCol++)
    {
        sum += SeachMinimumElementCol(array, iCol);
    }
    System.Console.WriteLine($"SumMin = {sum}");
    return sum;
}


//основная программа

int rowCount = Prompt("Введите количество строк матрицы -> ");
int colCount = Prompt("Введите количество столбцов матрицы -> ");
int[,] array = GenerateArray(rowCount, colCount, 0, 10);
PrintArray(array);
System.Console.WriteLine($"max - min = {СountingSumMaxRows(array) - СountingSumMinCols(array)}");

