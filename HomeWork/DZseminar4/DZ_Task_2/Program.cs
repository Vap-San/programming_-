//Задача 2: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
//456 -> 3
//78 -> 2
//89126 -> 5



//ulong Promt(string message) ввод целого числа
ulong Promt(string message)
{
    System.Console.Write(message);
    return Convert.ToUInt64(Console.ReadLine());
}


int CountDigits(ulong number)
{
    int count = 0;
    while (number > 0)
    {
        number /= 10;
        count++;
    }
    return count;
}



//Основная программа
ulong num = Promt("Введите число -> ");
System.Console.Write($"Количество цифр в числе {num} - > {CountDigits(num)}");

