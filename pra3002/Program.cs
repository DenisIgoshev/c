// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

// void DetectedQuaters (int quater)
// {
// if (quater == 1)
//     {
//         System.Console.WriteLine("x > 0 , y > 0");
//     }
//         else if (quater == 2)
//     {
//         System.Console.WriteLine("x < 0 , y > 0");
//     }  
//         else if (quater == 3)
//     {
//         System.Console.WriteLine("x < 0 , y < 0");
//     }
//     else if (quater == 4)
//     {
//         System.Console.WriteLine("x > 0 , y < 0");
//     }
//     else
//     System.Console.WriteLine("такой четверти нету");
// }

// Console.Write("Введите номер четверти: ");
// int quater = Convert.ToInt32(Console.ReadLine());

// DetectedQuaters (quater);



string[] quaters = {"x > 0, y > 0", // индекс 0 хранится ответ для первой четверти
                    "x < 0, y > 0", // индекс 1 хранится ответ для второй четверти
                    "x < 0, y < 0", // индекс 2 хранится ответ для третьей четверти
                    "x > 0, y < 0" // индекс 3 хранится ответ для четвертой четверти
};

System.Console.Write("Введите номер четверти: ");
int quater = Convert.ToInt32(Console.ReadLine());
if (quater >= 1 && quater <= 4)
{
    System.Console.WriteLine(quaters[quater - 1]);
}
else
{
    System.Console.WriteLine("Такой четверти не существует");
}