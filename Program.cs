void Main()
{
    while (true)
    {
        Console.Write("Введите целое число или 'q' для выхода: ");
        string input = Console.ReadLine();

        if (input.ToLower() == "q")
        {
            Console.WriteLine("Программа завершена.");
            break;
        }

        if (IsSumOfDigitsEven(Convert.ToInt32(input)))
        {
            Console.WriteLine($"Сумма цифр числа {input} чётная. Программа завершена.");
            break;
        }
    }
}

static bool IsSumOfDigitsEven(int number)
{
    int sum = 0;
    foreach (char digitChar in number.ToString())
    {
        int digit = int.Parse(digitChar.ToString());
        sum += digit;
    }
    return sum % 2 == 0;
}
Main();