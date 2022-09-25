//Задача 3: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

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


//Произведение столбца первой матрицы и строки второй матрицы
int MultiplyRowCol(int[,] firstArray, int[,] secondArray, int row, int col)
{
    int multiply = 0;
    for (int i = 0; i < firstArray.GetLength(1); i++)
    {
        multiply += firstArray[row, i] * secondArray[i, col];
    }
    return multiply;
}

//Произведение матриц
int[,] MultiplyMartix(int[,] firstArray, int[,] secondArray)
{
    int[,] thirdArray = new int[firstArray.GetLength(0), secondArray.GetLength(1)];
    {
        for (int row = 0; row < firstArray.GetLength(0); row++)
        {
            for (int col = 0; col < secondArray.GetLength(1); col++)
            {
                thirdArray[row, col] = MultiplyRowCol(firstArray, secondArray, row, col);
            }
        }
        return thirdArray;
    }
}

//основная программа

int aRowCount = Prompt("Введите количество строк 1 матрицы -> ");
int aColCount = Prompt("Введите количество столбцов 1 матрицы -> ");
int[,] aArray = GenerateArray(aRowCount, aColCount, 0, 10);
PrintArray(aArray);
int bRowCount = Prompt("Введите количество строк 2 матрицы -> ");
int bColCount = Prompt("Введите количество столбцов 2 матрицы -> ");
int[,] bArray = GenerateArray(bRowCount, bColCount, 0, 10);
PrintArray(bArray);
if (aArray.GetLength(1) == bArray.GetLength(0))
{
    System.Console.WriteLine("Итоговая матрица:");
    PrintArray(MultiplyMartix(aArray, bArray));
}
else
{
    System.Console.Write("Количество стобцов первой мартицы не равен количеству строк второй матрицы, умножение невозможно");
}



