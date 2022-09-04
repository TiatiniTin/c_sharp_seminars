// Task: (Дополнительная, необязательная задача): Назовём число «интересным» если его произведение цифр делится на их сумму. 
// Напишите программу, которая заполняет массив на N «интересных» случайных целых чисел. 
// (Каждый эл-т массива должен быть сгенерирован случайно)

Console.Write("Введите необходимое количество 'интересных' чисел: ");
int N = Convert.ToInt32(Console.ReadLine());

int[] array = new int[N];
Random rnd = new Random();

int start = 1;
int end = 1000000000;


int curNumber;
int prodDigits = 1;
int sumDigits = 0;
int digit;
int tmp;
bool hasZeroDigit = false;
int i = 0;

while (i < N)
{
    curNumber = rnd.Next(start, end);

    prodDigits = 1;
    sumDigits = 0;
    hasZeroDigit = false;

    tmp = curNumber;

    while (tmp > 0) {
        digit = tmp % 10;

        if (digit != 0)
        {
            sumDigits += digit;
            prodDigits *= digit;

            tmp /= 10;
        } 
        else 
        {
            hasZeroDigit = true;
            break;
        }
    }

    if (!hasZeroDigit)
    {
        if (prodDigits % sumDigits == 0)
        {
            array[i] = curNumber;
            Console.WriteLine($"{curNumber}: произведение = {prodDigits}, сумма = {sumDigits}, ");
            i++;
        }
    }
}