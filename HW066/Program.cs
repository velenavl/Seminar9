// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N


int SumRec(int n)
{
    if (n == 4) return 4;
    else return n + SumRec(n - 1);
}

// Console.WriteLine(SumRec(15)); 
Console.WriteLine(SumRec(8)); 