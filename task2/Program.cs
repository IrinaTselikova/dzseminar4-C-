/* Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

int GetNumber(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine());
    return result;
}

int GetSum(int n)
{
    int[] array=new int[n];
    int sum = 0;
    int i=0;
    if (i<array.Length)
    {
        sum = sum + array[i];
        i++;
    }
    else
    Console.WriteLine(sum);
    return sum;
}


int n = GetNumber("Введите число:");
int sum = GetSum(n);
Console.WriteLine($"{n} -> {sum}");





