//Задача 5*: Напишите программу, которая генерирует последовательность случайных чисел
// из 10 элементов в диапазоне от 1 до 10, и подсчитывает, сколько сгенерировалось чисел больше 5.

const int n = 5;

//int Promt(string message) ввод целого числа
int Promt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArray(int[] inArray)
{
    int length = inArray.Length;
    int index = 0;
    while (index < length)
    {
        inArray[index] = new Random().Next(1, 11); //случайное число от 1 до 10
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

// Возвращает количество элементов больше константы 
int MoreN(int[] array)
{
    int length = array.Length;
    int index = 0;
    int count = 0;
    while (index < length)
    {
        if (array[index] > n) count++;
        index++;
    }
    return count;
}

int count = Promt("Введите количество чисел -> ");
int[] array = new int[count];
FillArray(array);

System.Console.WriteLine("Последовательность случайных чисел:");
PrintArray(array);
System.Console.WriteLine();

System.Console.WriteLine($"Сгенерировалось больше {n} -> {MoreN(array)}");