//Задача 3: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
//4 -> 24 
//5 -> 120


//ulong Promt(string message) ввод целого числа
ulong Promt(string message)
{
    System.Console.Write(message);
    return Convert.ToUInt64(Console.ReadLine());
}


ulong MultiplicationNumbers(ulong number)
{
    ulong sum = 1;
    for (ulong i = 2; i <= number; i++)
    {
        sum *= i;
    }
    return sum;
}



//Основная программа
ulong num = Promt("Введите число -> ");
System.Console.Write($"Произведение числе от 1 до {num} - > {MultiplicationNumbers(num)}");

