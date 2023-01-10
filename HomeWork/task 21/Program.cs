// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
Console.WriteLine("Введите координату х первой точки"); 
int x1 = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите координату у первой точки"); 
int y1 = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите координату z первой точки"); 
int z1 = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите координату х второй точки"); 
int x2 = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите координату у второй точки"); 
int y2 = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите координату z второй точки"); 
int z2 = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine(Dist(x1, y1, z1, x2, y2, z2));  
// double Dist = Math.Sqrt(Math.Pow(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2)+ Math.Pow((z2 - z1), 2)); 
// Console.WriteLine($"Расстояние равно {Dist}"); 
double Dist(int x1, int y1, int z1, int x2, int y2, int z2) 
{ 
    double D = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2)+ Math.Pow((z2 - z1), 2)); 
    return D; 
}