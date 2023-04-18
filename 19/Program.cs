// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да



// Вариант 1

Console.Write("Введите пятизначное число: ");
string num = Console.ReadLine();

void CheckingNumber(string num)
{
  if (num[0]==num[4] || num[1]==num[3])
  {
    Console.WriteLine($"Да, это число: {num} - палиндром.");
  }
  else Console.WriteLine($"Нет, это число: {num} - не палиндром.");
}

if (num!.Length == 5)
{
  CheckingNumber(num);
}
else Console.WriteLine($"Введите корректное число");


// вариант 2

// int Number() 
//     Console.WriteLine("Введите пятизначное число: ");
//     int num = Convert.ToInt32(Console.ReadLine());
//     return num;
// }

// bool range(int num) 
// {
//     if (num > 9999 && num < 100000) return true;
//     else return false;
// }

// void Palindrom(int num) 
// {
//     if (range(num))
// {
//     if(num/10000 == num % 10 && (num/1000)%10 == (num%100)/10)
//     {
//         Console.WriteLine("Да, это палиндром");
//     }
//     else Console.WriteLine("Нет, это не палиндром");
// } 
// else Console.WriteLine("Введите корректное число");
// }

// int num = Number();
// Palindrom(num);

