// Task: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

Console.Write("Чётные числа от 1 до " + N + ": ");

int currentNumber = 1;
while (currentNumber < N) {
    if (currentNumber % 2 == 0) {
        Console.Write(currentNumber + ", ");
    }
    currentNumber++;
}


