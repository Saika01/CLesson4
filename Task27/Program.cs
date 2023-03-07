int Summary(int num)
{
    int sum = 0;
    while (num / 10 != 0)
    {
        sum = num % 10 + sum;
        num = num / 10;
    }
    sum = sum + num;
    return sum;
}

Console.WriteLine("Input number");
int number = Convert.ToInt32(Console.ReadLine());

int summary = 0;

if (number / 10 != 0)
{
    summary = Summary(number);
} else summary = number;


Console.WriteLine(summary);
