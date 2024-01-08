// // Задача 1: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

// Console.Write("Введите число:" );
// int number = Convert.ToInt32(Console.ReadLine());

// if (number %7 == 0 && number %23 ==0)
// {
//     Console.WriteLine($"число {number} кратно одновременно 7 и 23");
// }
// else
// {
//     Console.WriteLine($"число {number} не кратно одновременно 7 и 23");
// }

// // Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y), 
// // причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.

// Console.Write("Введите координату Х:" );
// int X = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите координату Y:" );
// int Y = Convert.ToInt32(Console.ReadLine());

// if (X > 0 && Y > 0)
// {
//     Console.WriteLine("Точка находится в I четверти");
// }
// if (X < 0 && Y > 0)
// {
//     Console.WriteLine("Точка находится в II четверти");
// }
// if (X < 0 && Y < 0)
// {
//     Console.WriteLine("Точка находится в III четверти");
// }
// if (X > 0 && Y < 0)
// {
//     Console.WriteLine("Точка находится в IV четверти");
// }

// // Задача 3: Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа

// Console.Write("Введите число:" );
// int number = Convert.ToInt32(Console.ReadLine());

// if (number >= 10 && number <= 99)
// {
//     int firstDigit = number / 10; 
//     int secondDigit = number % 10;
//     if (firstDigit > secondDigit)
//     {
//         Console.WriteLine(firstDigit);
//     }
//     else
//     {
//         Console.WriteLine(secondDigit);
//     }
// }
// else
// {       
//     Console.WriteLine("Число не входит в диапазон от 10 до 99"); 
// }

// Задача 4: Напишите программу, которая на вход принимает натуральное число N, 
// а на выходе показывает его цифры через запятую.

Console.Write("Введите число:" );
int N = Convert.ToInt32(Console.ReadLine());

if (N >= 0)
{
    Console.Write(N / 1000 %10); 
    Console.Write(",\t"); 
    Console.Write(N / 100 %10); 
    Console.Write(",\t"); 
    Console.Write(N / 10 %10); 
    Console.Write(",\t"); 
    Console.Write(N %10);   
}
else
{
    Console.WriteLine("Число не является натуральным");
}
