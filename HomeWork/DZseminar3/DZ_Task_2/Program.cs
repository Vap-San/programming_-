//Задача 2: Напишите программу, которая принимает на вход координаты двух точек и 
//находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

const int iX = 0; // индекс координаты х
const int iY = 1; // индекс координаты y
const int iZ = 2; // индекс координаты z

//int Promt(string message) ввод целого числа
int Promt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

//int[] InputCoords() - заполнение массива координатами точки
int[] InputCoords()
{
    int[] temp = new int[3]; // 0 - координата х, 1- координата y, 2- координата z
    temp[iX] = Promt("Введите координату x -> ");
    temp[iY] = Promt("Введите координату y -> ");
    temp[iZ] = Promt("Введите координату z -> ");
    return temp;
}

//double Distance(int [] firstPoint, int [] secondPoint) - определяет расстояние между двумя точками
double Distance(int[] firstPoint, int[] secondPoint)
{
    return Math.Sqrt(Math.Pow(secondPoint[iX] - firstPoint[iX], 2) + Math.Pow(secondPoint[iY] - firstPoint[iY], 2)+Math.Pow(secondPoint[iZ] - firstPoint[iZ], 2));
}

//Основная программа
System.Console.WriteLine("Координаты точки А");
int[] pointA = InputCoords();

System.Console.WriteLine("Координаты точки B");
int[] pointB = InputCoords();

System.Console.Write($"A({pointA[iX]},{pointA[iY]},{pointA[iZ]}), B({pointB[iX]},{pointB[iY]},{pointB[iZ]}) -> {Distance(pointA, pointB):f2}");
