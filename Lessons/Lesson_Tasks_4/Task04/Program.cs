//Задача 4: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
//[1,0,1,1,0,1,0,0]

const int N = 8;

void FillArray(int[] inArray)
{
    int length = inArray.Length;
    for (int i = 0; i < length; i++)
    {
        inArray[i] = new Random().Next(1, 3) - 1; //случайное число от 1 до 10
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


int[] array = new int[N];
FillArray(array);

System.Console.WriteLine("Последовательность случайных чисел:");
PrintArray(array);
System.Console.WriteLine();

