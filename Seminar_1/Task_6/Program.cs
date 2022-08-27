// Task: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.Write("Число ");
Console.Write(num);

if (num % 2 == 0) {
    Console.WriteLine(" - чётное");
} else {
     Console.WriteLine(" - нечётное");
}