// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да



// int InputNum(string message)
// {
// 	Console.Write(message);
// 	int num = int.Parse(Console.ReadLine()!);
// 	return num;
// }
// int num, temp, ost;
// num = InputNum("Введиде число ");
// int obr = 0;
// for(temp = num; num != 0; num /= 10)
// {
//     ost = num % 10;
//     obr = obr*10 + ost;
// }
// if (temp == obr)
//     Console.Write($"{temp} является палиндромом");
// else
//     Console.Write($"{temp} не является палиндромом");













// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// int InputNum (string message)
// {
//     Console.Write(message);
//     return int.Parse(Console.ReadLine()!);
// }

// double Distanse (int xa, int ya, int za, int xb, int yb, int zb)
// {   int delayx = xb-xa;
//     int delayy = yb-ya;
//     int delayz = zb-za;
//     return Math.Sqrt(Math.Pow((delayx), 2) + Math.Pow((delayy), 2)+Math.Pow((delayz), 2));  
// }

// int xa = InputNum("Введите координату хa: ");
// int ya = InputNum("Введите координату ya: ");
// int za = InputNum("Введите координату za: ");
// int xb = InputNum("Введите координату хb: ");
// int yb = InputNum("Введите координату yb: ");
// int zb = InputNum("Введите координату zb: ");

// Console.WriteLine($"Расстояние равно {Distanse(xa, ya, za, xb, yb, zb)}");






// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int InputNum(string message)
{
	Console.Write(message);
	int num = int.Parse(Console.ReadLine()!);
	return num;
}
int num = InputNum("enter number N: ");
for(int i = 1; i <= num; i++)
{
	Console.Write($"{Math.Pow(i, 3)}");
	if(i < num)
	{
		Console.Write(", ");
	}
	else
	{
		Console.Write(".");
	}
}