//Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
//3 -> Среда 
//5 -> Пятница

 Console.WriteLine("введите номер дня недели");
int nomer = Convert.ToInt32(Console.ReadLine());
// if (nomer < 1 || nomer > 7)
// {
//     Console.WriteLine("нет такого дня недели");
// }
// else
// {
//     if (nomer == 1)
//     {
//         Console.WriteLine("понедельник");
//     }
//     if (nomer == 2)
//     {
//         Console.WriteLine("вторник");
//     }
//     if (nomer == 3)
//     {
//         Console.WriteLine("среда");
//     }
//     if (nomer == 4)
//     {
//         Console.WriteLine("четверг");
//     }
//     if (nomer == 5)
//     {
//         Console.WriteLine("пятница");
//     }
//     if (nomer == 6)
//     {
//         Console.WriteLine("суббота");
//     }
//     if (nomer == 7)
//     {
//         Console.WriteLine("воскресенье");
//     }
// }

//второй способ

// Вариант 2

// if (nomer == 1)
// {
//     Console.WriteLine("понедельник");
// }
// else if (nomer == 2)
// {
//     Console.WriteLine("вторник");
// }
// else if (nomer == 3)
// {
//     Console.WriteLine("среда");
// }
// else if (nomer == 4)
// {
//     Console.WriteLine("четверг");
// }
// else if (nomer == 5)
// {
//     Console.WriteLine("пятница");
// }
// else if (nomer == 6)
// {
//     Console.WriteLine("суббота");
// }
// else if (nomer == 7)
// {
//     Console.WriteLine("воскресенье");
// }
// else
// {
//     Console.WriteLine("нет такого дня недели");
// }

// Вариант 3

switch (nomer)
{
    case 1:
        {
            Console.WriteLine("понедельник");
            break;
        }
    case 2:
        {
            Console.WriteLine("вторник");
            break;
        }
    case 3:
        {
            Console.WriteLine("среда");
            break;
        }
    case 4:
        {
            Console.WriteLine("четверг");
            break;
        }
    case 5:
        {
            Console.WriteLine("пятница");
            break;
        }
    case 6:
        {
            Console.WriteLine("суббота");
            break;
        }
    case 7:
        {
            Console.WriteLine("воскресенье");
            break;
        }
    default:
        {
            Console.WriteLine("нет такого дня недели");
            break;
        }
}