//3.1. Напишите программу, которая будет принимать на вход пять чисел и выводить сумму и среднее арифметическое этих чисел.
//2, 5, 6, 8, 1 -> сумма 22, среднее 4,4 

int Promt(string message)
{
    System.Console.Write(message);
    string strValue = Console.ReadLine() ?? "0"; //?? "0" - если ничего не ввел, то ставим 0. Вводим числа как строки т.к. это консоль
    bool isNumber = int.TryParse(strValue, out int value);
    if (isNumber)
    {
        return value;
    }
    throw new Exception("Данное число невозможно перевести в целое число");
}

void FillArray(int[] inArray)
{
    int length = inArray.Length;
    int index = 0;
    while (index < length)
    {
        inArray[index] = Promt($"Введите {index + 1} число -> ");
        // inArray[index] = new Random().Next(1,11);
        index++;
    }
}

void PrintArray(int[] outArray)
{
    int length = outArray.Length;
    for (int i = 0; i < length; i++)
    {
        System.Console.Write($"{outArray[i]} ");
    }
}

int SumArray(int[] massiv)
{
    int length = massiv.Length;
    int sum = 0;
    int index = 0;
    while (index < length)
    {
        sum += massiv[index];
        index++;
    }
    return sum;
}

int count = Promt("Введите количество элементов массива -> ");
int[] array = new int[count];

FillArray(array);
PrintArray(array);
double average = (double)SumArray(array) / count;

System.Console.WriteLine($" -> сумма {SumArray(array)}, среднее {average} ");
