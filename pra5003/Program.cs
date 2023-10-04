// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да


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

FillArray(arr);
System.Console.WriteLine(string.Join(", ", arr));

System.Console.Write("Введите искомое число: ");
int number = Convert.ToInt32(Console.ReadLine());

bool FinD = false;

for (int i=0; i<arr.Length;i++)
{
   if (arr[i]==number) 
   {
    FinD = true;
    break;
   }
}
System.Console.WriteLine(FinD);