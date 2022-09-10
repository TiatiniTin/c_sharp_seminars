// Task: Задайте одномерный массив, заполненный случайными числами. Найдите сумму четных элементов, стоящих на нечётных позициях
// (позиция - индекс элемента в массиве).

// [3, 7, 23, 12] -> 12
// [4, 6, 8, 1, 4] -> 6

int[] fillArray (int[] array, int start, int stop) 
{
    Random rnd = new Random();
    
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(start, stop + 1);
    }
    return array;
}

int getSum (int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2 )
    {
        if (array[i] % 2 == 0 )
        {
            sum += array[i];
        }
    }
    return sum;
}

void printArray (int[] array)
{
    int N = array.Length;
    Console.Write("[ ");
    for (int i = 0; i < N - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine($"{array[N-1]} ]");
}


Console.Write("Введите N: ");
int N = Convert.ToInt32(Console.ReadLine());

int[] array = new int[N];


int start = 1;
int stop = 999;

array = fillArray(array, start, stop);
printArray(array);
int sum = getSum(array);

Console.WriteLine($"Сумма четных элементов, стоящих на нечетных позициях: {sum}");