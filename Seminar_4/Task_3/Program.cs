// Task: (Дополнительная, необязательная задача): Назовём число «интересным» если его произведение цифр делится на их сумму. 
// Напишите программу, которая заполняет массив на N «интересных» случайных целых чисел. 
// (Каждый эл-т массива должен быть сгенерирован случайно)

int[] getSumProdZero (int number) 
{
    int prodDigits = 1;
    int sumDigits = 0;
    int digit;

    int hasZeroDigit = 0;

    while (number > 0) {
        digit = number % 10;

        if (digit != 0)
        {
            sumDigits += digit;
            prodDigits *= digit;

            number /= 10;
        } 
        else 
        {
            hasZeroDigit = 1;
            break;
        }
    }

    return new int[3] { sumDigits, prodDigits, hasZeroDigit }; 
}

Console.Write("Введите необходимое количество 'интересных' чисел: ");
int N = Convert.ToInt32(Console.ReadLine());

int[] array = new int[N];
Random rnd = new Random();

int start = 1;
int end = 1000000000;

int curNumber;
int i = 0;

while (i < N)
{
    curNumber = rnd.Next(start, end);

    int[] sumProdZeroArr = getSumProdZero(curNumber);

    int sumDigits = sumProdZeroArr[0];
    int prodDigits = sumProdZeroArr[1];
    int hasZeroDigit = sumProdZeroArr[2];

    if (hasZeroDigit == 0)
    {
        if (prodDigits % sumDigits == 0)
        {
            array[i] = curNumber;
            Console.WriteLine($"{curNumber}: произведение = {prodDigits}, сумма = {sumDigits}, ");
            i++;
        }
    }
}