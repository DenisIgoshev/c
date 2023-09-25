// Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

void DetectedQuaters(int x, int y)
{
    if (x > 0 && y > 0)
    {
        System.Console.WriteLine("Точка находится в первой четверти");
    }
    else if (x < 0 && y > 0)
    {
        System.Console.WriteLine("Точка находится во второй четверти");
    }

    else if (x < 0 && y < 0)
    {
        System.Console.WriteLine("Точка находится в третьей четверти");
    }

    else if (x > 0 && y < 0)
    {
        System.Console.WriteLine("Точка находится в четвертой четверти");
    }

    else
    {
        System.Console.WriteLine("Точка не может содержать координату 0");
    }

}

Console.Write("Введите координату x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y: ");
int y = Convert.ToInt32(Console.ReadLine());

DetectedQuaters(x, y);