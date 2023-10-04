// Console.Write("Введите число: ");
// string? number = Console.ReadLine();

// void CheckingNumber(string number){
//   if (number[0]==number[4] || number[1]==number[3]){
//     Console.WriteLine($"Ваше число: {number} - {return true}");
//   }
//   else Console.WriteLine($"Ваше число: {number} - {return false}");
// }

// if (number!.Length == 5){
//   CheckingNumber(number);
// }
// else Console.WriteLine($"Введи правильное число");



using System;

public class Answer
{
    static bool IsPalindrome(int number){
      // Введите свое решение ниже

       if(number > 999 && number < 100000)
       {
        string numString = number.ToString();
        char[] charArray = numString.ToCharArray();
        Array.Reverse(charArray);
        string reversedString = new string(charArray);
       return numString == reversedString;
       }
      else
      {
        System.Console.WriteLine("Число не пятизначное");
       return false;
      }


    }
       




  // Не удаляйте и не меняйте метод Main! 
      static public void Main(string[] args) {
        int number;

        if (args.Length >= 1) {
            number = int.Parse(args[0]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            number = 1282123;
        }

        // Не удаляйте строки ниже
        bool result = IsPalindrome(number);
        System.Console.WriteLine($"{result}");
    }
}