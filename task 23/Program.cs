// Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.


void PowX3(double A, out double B)
{            
    B = Math.Pow(A,3);            
}
Console.WriteLine("введите число");
double i = double.Parse(Console.ReadLine()!);
for (double A=1;i>=A;A++)
{
PowX3(A, out double C);
 Console.WriteLine(C);
}