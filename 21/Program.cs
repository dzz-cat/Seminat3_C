// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Вариант 1


Console.WriteLine("Поочередно введите координаты:");
int x1 = Coordinate("x", "A");
int y1 = Coordinate("y", "A");
int z1 = Coordinate("z", "A");
int x2 = Coordinate("x", "B");
int y2 = Coordinate("y", "B");
int z2 = Coordinate("z", "B");

int Coordinate(string coorName, string pointName)
{
    Console.Write($"Введите координату {coorName} точки {pointName}: ");
    return Convert.ToInt16(Console.ReadLine());
}

double Decision(double x1, double x2, 
                double y1, double y2, 
                double z1, double z2){
  return Math.Sqrt(Math.Pow((x2-x1), 2) + 
                   Math.Pow((y2-y1), 2) + 
                   Math.Pow((z2-z1), 2));
}

double segmentLength =  Math.Round (Decision(x1, x2, y1, y2, z1, z2), 2 );

Console.WriteLine($"Длина отрезка  {segmentLength}");


// // Вариант 2

// void Dots (int[] X) 
// {
//     Console.WriteLine("Поочередно введите координаты: ");
//     Console.Write("x =" + " ");
//     X[0] = Convert.ToInt32(Console.ReadLine());
//     Console.Write("y =" + " ");
//     X[1] = Convert.ToInt32(Console.ReadLine());
//     Console.Write("z =" + " ");
//     X[2] = Convert.ToInt32(Console.ReadLine());
// }

// double Lon(int[] A, int[] B) 
// {
// double lon = Math.Sqrt(Math.Pow((B[0] - A[0]), 2) + Math.Pow((B[1] - A[1]), 2) + Math.Pow((B[2] - A[2]), 2));
// return lon;
// }

// int[] A = new int[3];
// int[] B = new int[3];

// Console.WriteLine("Введите координаты первой точки.");
// Dots(A);
// Console.WriteLine("Введите координаты второй точки.");
// Dots(B);

// Console.WriteLine($"Расстояние между точками: {Lon(A, B)}");