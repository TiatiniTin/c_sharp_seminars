// Task: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("max = ");
if (num1 > num2) {
    Console.WriteLine(num1);
} else {
    Console.WriteLine(num2);
}
