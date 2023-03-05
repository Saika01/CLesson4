Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

int digitNumbers = DigitNumbers(number);
Console.WriteLine($"Количество цифр в числе: {digitNumbers}");

int DigitNumbers(int num)
{
    int count = 0;
    while (num>0)
    {
        num = num / 10;
        count++;
    }
    return count;
}
