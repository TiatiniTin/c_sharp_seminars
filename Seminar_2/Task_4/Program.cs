// Task: Напишите программу, которая принимает на вход случайно сгенерированное число (от 1 до 1 000 000) 
// и проверяет, кратно ли оно одновременно 7 и 23.

int begin = 1;
int end = 1000000;

int randomNum = new Random().Next(begin, end + 1);

Console.WriteLine("Сгенерированное число: " + randomNum);

int num1 = 7;
int num2 = 23;

if (randomNum % num1 == 0 && randomNum % num2 == 0)
{
    Console.WriteLine("Число кратно одновременно " + num1 + " и " + num2);
}
else {
    Console.WriteLine("Число не кратно одновременно " + num1 + " и " + num2);
}