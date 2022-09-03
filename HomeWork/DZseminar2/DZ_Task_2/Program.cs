//Задача 2: Напишите программу, которая выводит случайное трёхзначное число и
// удаляет вторую цифру этого числа.


int Number = new Random().Next(100, 1000);

System.Console.WriteLine($"{Number} -> {Number / 100 * 10 + Number % 10}");
