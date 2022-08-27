// Task: Напишите программу, которая принимает на вход случайно сгенерированное трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

int begin = 100;
int end = 999;
int num = new Random().Next(begin, end + 1);

Console.WriteLine("Сгенерированное число: " + num);

int secondDigit = (num % 100) / 10;

Console.WriteLine("Вторая цифра: " + secondDigit);
