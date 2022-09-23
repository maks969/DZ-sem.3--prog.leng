/*Напишите программу, которая принимает на вход координаты двух точек
 и находит расстояние между ними в 3D пространстве.*/
 

Console.WriteLine("введите координаты первой точки");
Console.WriteLine("введите X");
double x=double.Parse(Console.ReadLine());
Console.WriteLine("введите Y");
double y=double.Parse(Console.ReadLine());
Console.WriteLine("введите Z");
double z=double.Parse(Console.ReadLine());

Console.WriteLine("введите координаты второй точки");
Console.WriteLine("введите X1");
double x1=double.Parse(Console.ReadLine());
Console.WriteLine("введите Y1");
double y1=double.Parse(Console.ReadLine());
Console.WriteLine("введите Z1");
double z1=double.Parse(Console.ReadLine());

double h = Math.Sqrt(Math.Pow(x1-x,2)+Math.Pow(y1-y,2)+Math.Pow(z1-z,2));


Console.WriteLine($"расстоянте = {h}");

