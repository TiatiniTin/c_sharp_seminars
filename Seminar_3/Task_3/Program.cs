// Task: Напишите программу, которая принимает на вход число (N) и помещает в массив таблицу кубов чисел от 1 до N. 
// Полученный массив вывести на экран.

Console.Write("Введите размер массива N: ");
int N = Convert.ToInt32(Console.ReadLine());

int[] array = new int[N];

for (int i = 1; i <= N; i++)
{
    array[i-1] = i * i * i;
}

Console.Write("[");
for (int i = 0; i < N-1; i++)
{
    Console.Write(array[i] + ", ");
}
Console.Write(array[N-1] + "]");