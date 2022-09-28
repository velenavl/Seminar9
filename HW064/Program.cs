// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

string NaturalNumber(int M, int N)
{
    if (M < N)
        return $"{M} " + NaturalNumber(M + 1, N);
    else
        return $"{M}";
}

Console.WriteLine(NaturalNumber(1, 5));
