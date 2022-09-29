// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

string NumbersRec(int a, int b) 
{
    if (a <= b) return $"{a} " + NumbersRec(a + 1, b);
    else return string.Empty;
}

Console.WriteLine(NumbersRec(4, 8));
