// Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.


void PowX3(double A, out double B)
{            
    B = Math.Pow(A,3);            
}
//double A = 10; 
double C= 0;
Console.WriteLine("введите число");
double i = double.Parse(Console.ReadLine()!);
int A = 0;
for (A=0;i>A;A++)
{
PowX3(A, out C);
 Console.WriteLine(C);
}