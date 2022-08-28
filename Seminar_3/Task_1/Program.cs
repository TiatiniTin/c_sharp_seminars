// Task: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Число хранить в типе данных int, решать с помощью арифметических операций (не рассматривая число как тип данных string)


Console.Write("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

// Если изменить N, start и end соотвественно, то можно проверять числа любой длины 

int N = 5;

int start = 10000;
int end = 99999;

if (num < start || num > end) {
    Console.WriteLine("Введено не пятизначное число!");
}
else {
    int[] array = new int[N];

    int numForFindingReminder = 10;
    int numForFindingintegerPart = 1;

    for (int i = 0; i < N; i++)
    {
        array[i] = (num % numForFindingReminder) / numForFindingintegerPart;
        numForFindingReminder *=10;
        numForFindingintegerPart *= 10;
    }

    bool isPalindrome = true;

    for (int i = 0; i < N/2; i++) 
    { 
        if (array[i] != array[N - 1 - i])
        {
            isPalindrome = false;
            break;
        }
    }

    if (isPalindrome == true)
    {
        Console.WriteLine("Введенное число является палиндромом");
    } else 
    {
        Console.WriteLine("Введенное число не является палиндромом");
    }
}