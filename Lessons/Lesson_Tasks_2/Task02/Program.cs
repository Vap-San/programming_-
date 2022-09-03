//2. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
//78 -> 8 
//12-> 2 
//85 -> 8


int Number = new Random().Next(10, 100);
int DigitOne = Number % 10;
int DigitTwo = Number / 10;
int max;

if (DigitOne > DigitTwo) max = DigitOne; else max = DigitTwo;

System.Console.WriteLine($"Наибольшая цифра числа {Number} -> {max}");