// Задача 31: Задайте массив из N элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

void FillArray(int[] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(-9, 10);
    }
}

System.Console.Write("Введите кол-во элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[size];
int sumPositive = 0;
int sumNegative = 0;

FillArray(arr);
System.Console.WriteLine(string.Join(", ", arr));

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > 0)
    {
        sumPositive += arr[i];
    }
    else
    {
        sumNegative += arr[i];
    }
}
System.Console.WriteLine($"Сумма положительных = {sumPositive}, а сумма отрицательных = {sumNegative}");

//Вариант №2
// void FillArray(int[] arr)
// {
//     Random rnd = new Random();
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = rnd.Next(-9, 10);
//     }
// }

// void SumPositiveAndNegative(int[] arr, out int sumPositive, out int sumNegative)
// {
//     sumPositive = 0;
//     sumNegative = 0;
    
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] > 0)
//         {
//             sumPositive += arr[i];
//         }
//         else
//         {
//             sumNegative += arr[i];
//         }
//     }
// }

// System.Console.Write("Введите кол-во элементов массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] arr = new int[size];


// FillArray(arr);
// System.Console.WriteLine(string.Join(", ", arr));
// SumPositiveAndNegative(arr, out int sumP, out int sumN);
// System.Console.WriteLine($"Сумма положительных = {sumP}, а сумма отрицательных = {sumN}");