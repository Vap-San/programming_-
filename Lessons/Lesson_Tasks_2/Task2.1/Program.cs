//2.1. Напишите программу, которая выводит случайное число из отрезка [10, 9999] и показывает наибольшую цифру числа.
//7812 -> 8 
//1213-> 3 
//845 -> 8


int MaxDigit(int inNumber)
{
    int LastDigit;
    int max = inNumber % 10;
    while (inNumber != 0)
    {
        LastDigit = inNumber % 10;
        if (LastDigit > max) max = LastDigit;
        inNumber = inNumber / 10;
    }
    return max;
}

int Number = new Random().Next(10, 10000);

System.Console.WriteLine($"{Number} -> {MaxDigit(Number)}");
