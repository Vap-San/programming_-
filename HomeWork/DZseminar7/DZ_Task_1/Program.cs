//Задача 1.Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

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

//Генерация матрицы случайными вещественными числами в диапазоне [minRange, maxRange]
double[,] GenerateArray(int rowLength, int colLength, int minRange, int maxRange)
{
    double[,] array = new double[rowLength, colLength];

    //Random rand = new Random(DateTime.Now.Millisecond); //Можно и так
    Random rand = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rand.NextDouble() * (maxRange - minRange) + minRange;
        }
    }
    return array;
}

//Вывод матрицы (числа выравниваются по запятой, два знака после запятой)
void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write("{0,8:0.00} \t", array[i, j]);
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}


//основная программа

int rowCount = Prompt("Введите количество строк матрицы -> ");
int colCount = Prompt("Введите количество столбцов матрицы -> ");
double[,] array = GenerateArray(rowCount, colCount, -10, 10);
PrintArray(array);

