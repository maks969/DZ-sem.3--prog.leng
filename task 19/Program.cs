// Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.

Console.WriteLine("введите пятизначное число");
int x = int.Parse(Console.ReadLine()!);

int[] array = new int[x.ToString().Length];
for (int i = 0; i < array.Length; i++)
{
    array[i] = x % 10;
    x /= 10;
}

if (array[0]==array[4] & array[1]==array[3]) 

     Console.WriteLine("данное число палиндром!");

else  Console.WriteLine("данное число не палиндром");
