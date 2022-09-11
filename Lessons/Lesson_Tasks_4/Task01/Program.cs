//Задача 1: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
//7 -> 28
//4 -> 10
//8 -> 36



//int Promt(string message) ввод целого числа
ulong Promt(string message)
{
    System.Console.Write(message);
    return Convert.ToUInt64(Console.ReadLine());
}


ulong SumNumbers(ulong number)
{
    ulong sum = 0;
    for (ulong i = 1; i <= number; i++)
    {
        sum += i;
    }
    return sum;
}



//Основная программа
ulong num = Promt("Введите число -> ");
System.Console.Write($"Сумма числе от 1 до {num} - > {SumNumbers(num)}");

