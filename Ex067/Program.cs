// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
Console.Write("Введите число N: ");
bool nIsNumber = int.TryParse(Console.ReadLine(), out int n);

if (nIsNumber)
{
    System.Console.WriteLine(GetSumDigitsOfNumber(n));
}
else
{
    PrintWrongMessage();
}

int GetSumDigitsOfNumber(int number, int delimiter = 1, int sum = 0)
{
    if (number / delimiter == 0)
    {
        return 0;
    }
        return number / delimiter % 10 + GetSumDigitsOfNumber(number, delimiter * 10);
}

// // void PrintMatrix(int[] array)
// // {
// //     foreach (var item in array)
// //     {
// //         System.Console.Write(item + " ");
// //     }
// // }

void PrintWrongMessage()
{
    System.Console.WriteLine("Некорректный ввод");
}

