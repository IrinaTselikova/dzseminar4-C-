/* Напишите программу, которая задаёт массив из 8 элементов и 
выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
ввод элеменетов через консоль (через запятую. использовать 
метод string.Split()) */

string GetNumber(string message)
{
    Console.WriteLine(message);
    string result = Console.ReadLine();
    return result;
}

string str = GetNumber("Введите 8 цифр через запятую:");
string[] numbers = str.Split(',');
foreach (var number in numbers)


Console.Write($"{number[1]}");

 













