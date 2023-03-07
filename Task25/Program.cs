int TimesTimes(int number1, int number2)
{
    if (number2 == 0) return 1;
    int output = 1;
    for (int i = 0; i < number2; i++)
    {
        output = number1 * output;
    }
    if (output == 1) return number1;
    return output;
}

Console.WriteLine("Input first number");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input second number");
int num2 = Convert.ToInt32(Console.ReadLine());

int result = TimesTimes(num1,num2);

Console.WriteLine(result);
