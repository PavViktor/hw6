/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

Console.WriteLine("Enter the coordinates of point b1: "); 
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the coordinates of point k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the coordinates of point b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the coordinates of point k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());
CrossPoint(k1,b1,k2,b2);

void CrossPoint(double k1, double b1, double k2, double b2)
{
    double x = (b1 - b2) / (k2 - k1);
    double y = (k2 * b1 - k1 * b2) / (k2 - k1);
    if (k1 == k2)
        Console.Write("lines do not intersect");
    if (k1 == k2 && b1 == b2)
        Console.Write(". lines coincide.");
    else Console.Write($"Crosspoint : ({x}; {y})");
}