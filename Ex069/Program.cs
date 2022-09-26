// Напишите программу, которая на вход принимает два числа А и В, и возводит число А в целую степень В с помощью рекурсии.
Console.Write("Введите число А: ");
bool isNumberA = int.TryParse(Console.ReadLine(), out int a);

Console.Write("Введите число B: ");
bool isNumberB = int.TryParse(Console.ReadLine(), out int b);
if (!isNumberA || !isNumberB)
{
    Console.WriteLine("Ошибка ввода");
    return;
}

int GetDegreeNumber(int a, int b, int sum = 1, int i = 1)
{
    if (i <= b)
    {
        i++;
        return sum = sum * a * GetDegreeNumber(a, b, sum, i);
    }
    return sum;
}
Console.WriteLine(GetDegreeNumber(a, b));