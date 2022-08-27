// Task: Напишите программу, которая выводит третью цифру случайно сгенерированного числа (от 1 до 65536) 
// или сообщает, что третьей цифры нет.

int begin = 1;
int end = 65536;

int num = new Random().Next(begin, end + 1);

Console.WriteLine("Сгенерированное число: " + num);

if (num / 100 == 0) 
{
    Console.WriteLine("Третьей цифры нет");
}
else 
{
    int thirdDigit = (num % 1000) / 100;
    Console.WriteLine("Третья цифра: " + thirdDigit);
}