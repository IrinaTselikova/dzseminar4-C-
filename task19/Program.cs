/* Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

Console.WriteLine("Введите число:");
string str = Console.ReadLine();
int[] array = new int[str.Length];
for (int i = 0; i < str.Length; i++)
{
    array[i] = int.Parse(str[i]+ "");
}


void GetAnswer(int[] array)
{
    int len = array.Length;
    for (int i = 0; i < array.Length/2; i++)
    
    {
        if(array[i] == array[len-i-1])
            Console.WriteLine("Это палиндромом");
        else
            Console.WriteLine("Это не палиндромом");
            break;
    }
}

GetAnswer(array);





