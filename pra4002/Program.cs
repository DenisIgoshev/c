// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int count = 0;
// if (number == 0)
// {
//     Console.WriteLine(1);
// } else
// {
//     while (number > 0)
//     {
//         count++;
//         number /= 10;
//     }

//     Console.WriteLine(count.ToString());
// }

// 1 Вариант решения
// Console.WriteLine("Введите число: ");
// int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
// int count = 0;
// if (number == 0)
// {
//     Console.WriteLine(1);
// }
// else
// {
//     while (number > 0)
//     {
//         count++;
//         number /= 10;
//     }

//     Console.WriteLine(count);
// }

//2 Вариант 

Console.WriteLine("Введите число: ");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
string num = Convert.ToString(number); // 123 = "123"
System.Console.WriteLine(num.Length); // ""