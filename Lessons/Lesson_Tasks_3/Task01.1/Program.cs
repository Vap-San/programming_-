//Задача 1. Напишите программу, которая принимает на вход координаты точки (X и Y), 
//причём X ≠ 0 или Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

//double Promt(string message) ввод координаты точки
double Promt(string message)
{
    System.Console.Write(message);
    return Convert.ToDouble(Console.ReadLine());
}

//Проверка вводимых значений
bool ValidateXY (double x, double y)
{
  if (x != 0 && y != 0) return true;
  System.Console.WriteLine("Точка находится на осях, вводимые координаты должны быть > 0");
  return false;
}


//void Quarter(double cX, double cY) - определяет номер чертверти
void Quarter(double cX, double cY)
{
    if (cX > 0 && cY > 0) System.Console.WriteLine($"Точка ({cX};{cY}) лежит  в 1-ой четверти");;
    if (cX < 0 && cY > 0) System.Console.WriteLine($"Точка ({cX};{cY}) лежит  во 2-ой четверти");;
    if (cX < 0 && cY < 0) System.Console.WriteLine($"Точка ({cX};{cY}) лежит  в 3-ей четверти");;
    if (cX > 0 && cY < 0) System.Console.WriteLine($"Точка ({cX};{cY}) лежит  в 4-ой четверти");;
}

//Основная программа

double x = Promt("Введите координату Х -> ");
double y = Promt("Введите координату Y -> ");

if (ValidateXY(x,y)) Quarter(x, y);
