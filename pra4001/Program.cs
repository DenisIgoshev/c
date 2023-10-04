// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

int SumNumbersToN(int num)
{
    int sum = 0;
    for (int i = 1; i <= num; i++)
    {
        sum += i; // == sum = sum + 1
    }
    return sum;
}

System.Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int result = SumNumbersToN(N);
System.Console.WriteLine($"Результат сложения от 1 до {N} = {result}");