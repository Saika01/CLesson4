// Sum of num from 1 to A

int SumNum(int num)
{
    int result =0;
    for(int i=1; i<=num; i++)
    {
        result = i+i-1;
    }
    return result;
}

Console.WriteLine("Input number");
int A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(SumNum(A));
