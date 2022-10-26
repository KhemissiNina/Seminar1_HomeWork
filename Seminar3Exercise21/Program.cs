// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53
Console.Clear();
double Distance (int X1, int Y1, int Z1, int X2, int Y2, int Z2)
{
    double distance = Math.Sqrt(Math.Pow(X2-X1,2)+Math.Pow(Y2-Y1,2)+Math.Pow(Z2-Z1,2));
    return distance;
}
Console.WriteLine("Введите значение координаты Х для первой точки:");
int x1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значениеткоординаты Y для первой точки:");
int y1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значениеткоординаты Z для первой точки:");
int z1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение координаты Х для второй точки:");
int x2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значениеткоординаты Y для второй точки:");
int y2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значениеткоординаты Z для второй точки:");
int z2 = int.Parse(Console.ReadLine());
Console.WriteLine();
Console.WriteLine($"Координаты первой точки ({x1};{y1};{z1})");
Console.WriteLine($"Координаты второй точки ({x2};{y2};{z2})");

double result = Distance(x1,y1,z1,x2,y2,z2);
Console.WriteLine(result);