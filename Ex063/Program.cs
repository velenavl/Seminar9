// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N. 

// 1 способ
// string NaturalNumber(int m, int n)
// {
//     if (m < n)
//         return $"{m} " + NaturalNumber(m + 1, n);
//     else
//         return $"{m}";
// }

// Console.WriteLine(NaturalNumber(1, 10));

// 2 способ
Console.Write("Введите размерность N: ");
bool isNumber1 = int.TryParse(Console.ReadLine(), out int N);

void PrintNum(int N, int i = 1)
{
    if (i > N)
    {
        return;
    }
    Console.WriteLine(i);
    PrintNum(N, i + 1);
}
PrintNum(N, 1);