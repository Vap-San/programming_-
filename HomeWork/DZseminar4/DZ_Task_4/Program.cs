//Задачи 4: (*) Напишите программу, которая задаёт массив из 8 элементов случайными числами и выводит их на экран.
// Также ищет второй максимум (число меньше максимального элемента, но больше всех остальных)
//8 1 2 4 4 5 3 1 -> 5
//1 2 6 9 8 1 1 1 -> 8
//2 1 2 1 1 1 1 1 -> 1
//1 2 1 2 1 1 1 1 -> 1
//1 2 3 4 5 6 7 8 -> 7
//1 2 3 4 5 6 8 7 -> 7

const int N = 8;
const int No = -200;

void FillArray(int[] inArray)
{
    int length = inArray.Length;
    for (int i = 0; i < length; i++)
    {
        inArray[i] = new Random().Next(1, 101) - new Random().Next(1, 101); //случайное число от - 100 до 100
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

int FindTwoMax(int[] array)
{
    int max = array[0];
    int maxTwo = No; //если массив состоит и одинаковых чисел

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            maxTwo = max;
            max = array[i];
        }
        else
        {
            if (maxTwo < array[i] && max != array[i]) maxTwo = array[i];
        }
    }
    //System.Console.WriteLine($"max={max}, max2={maxTwo}");
    return maxTwo;
}



int[] array = new int[N];
FillArray(array);

if (FindTwoMax(array) == No)
{
    System.Console.WriteLine("Массив состоит из одинаковых чисел, второго максимума нет");
}
else
{
    System.Console.WriteLine("Массив:");
    PrintArray(array);
    System.Console.WriteLine($" -> {FindTwoMax(array)}");
}


