//Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.




//ulong Promt(string message) ввод целого числа
ulong Promt(string message)
{
    System.Console.Write(message);
    return Convert.ToUInt64(Console.ReadLine());
}


ulong SumDigits(ulong number)
{
    ulong digit;
    ulong sum = 0;

    while (number > 0)
    {
        digit = number % 10;
        sum += digit;
        number /= 10;
    }
    return sum;
}





//Основная программа
ulong num = Promt("Введите число -> ");
System.Console.Write($"Сумма цифр в числе {num} - > {SumDigits(num)}");
