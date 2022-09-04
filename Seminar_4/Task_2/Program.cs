// Task: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе, которые являются делителями этого числа. 
// (для получения цифр числа операцию приведения числа к строке не использовать)
// 452 -> 6
// 82 -> 2
// 9012 -> 3
// 23 -> 0

int getDigitsNumber(int num) {
    int digitsNumber = 1;

    while (num > 9) {
        num /= 10;
        digitsNumber++;
    }

    return digitsNumber;
}

int[] createDigitsArray (int num, int len) {
    int[] digits = new int[len];

    for (int i = 0; i < len; i++) {
        digits[i] = num % 10;
        num /= 10;
    }

    return digits;
}

int getDigitsSumOfInputNumberDivisors (int num, int[] digits) {
    int sum = 0;
    int len = digits.Length;
    
    for (int i = 0; i < len; i++) {
        int curDigit = digits[i];

        if (curDigit != 0) {
            if (num % curDigit == 0) {
                sum += curDigit;
            }
        }
    }
   
    return sum;
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int length = getDigitsNumber(number);
int[] digits = createDigitsArray(number, length);
int sum = getDigitsSumOfInputNumberDivisors(number, digits);

Console.WriteLine($"Сумма цифр в числе, которые являются делителями числа равна {sum}");