// Задача 1: Напишите программу, которая принимает на вход пятизначное число и проверяет, 
//является ли оно палиндромом.

//int Promt(string message) ввод числа
int Promt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int Revers(int inNumber)
{
    int digit;
    int outNumber=0;
    while (inNumber != 0)
    {
        digit = inNumber % 10;
        outNumber = 10*outNumber + digit;
        inNumber = inNumber / 10;
    }
    return outNumber;
}

int number = Promt("Введите число -> ");
if (number == Revers(number))
{
System.Console.WriteLine($"{number} -> да");
}
else
{
System.Console.WriteLine($"{number} -> нет"); 
}