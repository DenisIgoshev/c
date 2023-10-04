
Console.Write("Введите число: ");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
string num = Convert.ToString(number);

void IsPalindrome (string num)
{
  if (num[0]==num[4] || num[1]==num[3]){
    Console.WriteLine($"Ваше число: {num} - True.");
  }
  else Console.WriteLine($"Ваше число: {num} - False.");
}

if (num!.Length == 5)
{
  IsPalindrome(num);
}
else Console.WriteLine($"Число не пятизначное");