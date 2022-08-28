// Task: Напишите программу, которая выводит третью цифру случайно сгенерированного числа (от 1 до 65536) 
// или сообщает, что третьей цифры нет.

int begin = 1;
int end = 65536;

int num = new Random().Next(begin, end + 1);

Console.WriteLine("Сгенерированное число: " + num);

int counter = 10;

while (num / counter > 0 )
{
    counter *= 10;
}

if (counter >= 1000)
{
    int thirdDigit = (num % (counter / 100)) / (counter / 1000);
    Console.WriteLine("Третья цифра: " + thirdDigit);
}
else 
{
    Console.WriteLine("У числа нет третьей цифры");
}