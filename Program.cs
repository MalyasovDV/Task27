int SumOfDigits(int number)
{
    int sum = 0;
    while (number > 0)
    {
        sum += number % 10;
        number/=10;
    }
    return sum;
}

int number = 452;
Console.WriteLine(SumOfDigits(number));

number = 82;
Console.WriteLine(SumOfDigits(number));

number = 9012;
Console.WriteLine(SumOfDigits(number));