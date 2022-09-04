//Задача 3: Напишите программу, которая принимает на вход координаты двух точек и 
//находит расстояние между ними в 2D пространстве.
//A (3,6); B (2,1) -> 5,09 
//A (7,-5); B (1,-1) -> 7,21

const int iX = 0; // индекс координаты х
const int iY = 1; // индекс координаты y

//int Promt(string message) ввод целого числа
int Promt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

//int[] InputCoords() - заполнение массива координатами точки
int[] InputCoords()
{
    int[] temp = new int[2]; // 0 - координата х, 1- координата y
    temp[iX] = Promt("Введите координату x -> ");
    temp[iY] = Promt("Введите координату y -> ");
    return temp;
}

//double Distance(int [] firstPoint, int [] secondPoint) - определяет расстояние между двумя точками
double Distance(int[] firstPoint, int[] secondPoint)
{
    return Math.Sqrt(Math.Pow(secondPoint[iX] - firstPoint[iX], 2) + Math.Pow(secondPoint[iY] - firstPoint[iY], 2));
}

//Основная программа
System.Console.WriteLine("Координаты точки А");
int[] pointA = InputCoords();
System.Console.WriteLine("Координаты точки B");
int[] pointB = InputCoords();
System.Console.Write($"A({pointA[iX]},{pointA[iY]}), B({pointB[iX]},{pointB[iY]}) -> {Distance(pointA, pointB):f2}");
