Console.Clear();


// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Console.WriteLine("Enter a five-digit number:");

// int firstNum;
// int secondNum;
// int thirdNum;
// int fourthNum;

// int num = Convert.ToInt32(Console.ReadLine());

// firstNum = num / 10000;
// secondNum = num % 10;
// thirdNum = num / 1000;
// fourthNum = num % 100;

// if ((firstNum==secondNum)&&(thirdNum==fourthNum))    
// Я не понимаю почему у меня "&&" и "||" всегда работают по-разному. Запускал с "||" и все вычислялось правильно. Иногда все работает правильно при написании кода.

// {
//     Console.WriteLine("It is palindromm");
// }
// else
// {
//     Console.WriteLine("It is not palindromm");
// }

// Версия с использованием "||"
// Enter a five-digit number:
// 15451
// It is palindromm
// PS C:\Users\nikit\OneDrive\Рабочий стол\Repo of Learning\ThirdHomeWork> 

// Версия с использованием "&&"
// Enter a five-digit number:
// 15451
// It is not palindromm
// PS C:\Users\nikit\OneDrive\Рабочий стол\Repo of Learning\ThirdHomeWork> 


// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


// Console.WriteLine("Imput number X1");
// double firstX = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Imput number Y1");
// double firstY = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Imput number Z1");
// double firstZ = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Imput number X2");
// double secondX = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Imput number Y2");
// double secondY = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Imput number Z2");
// double secondZ = Convert.ToInt32(Console.ReadLine());

// double number = Math.Sqrt(Math.Pow(secondX-firstX, 2) + Math.Pow(secondY-firstY,2) + Math.Pow(secondZ-firstZ,2));
// Console.WriteLine(number);


// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("get number for me");
double number = Convert.ToDouble(Console.ReadLine());
for (int i = 1; i <= number; i++)
{
    Console.WriteLine("Number " + i );
    Console.WriteLine(Math.Pow ( i, 3));
}
Console.WriteLine("Thanks for you time!");