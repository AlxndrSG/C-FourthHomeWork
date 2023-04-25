//Напишите программу, которая принимает на вход число и
//выдает сумму всех цифр в числе.

Console.Clear();

int number = GetNumberFromUser("Введите число: ", "Ошибка ввода!");

int calculateResult = CalculateNumber(number);

PrintResult(number, calculateResult);

void PrintResult(int num, int report)
{
    Console.WriteLine($"{num} -> {report}");
}

int CalculateNumber(int number)
{

    int sum = 0;
    while (number > 0)
    {
        int digit = number % 10;
        sum = sum + digit;
        number = number / 10;
    }
    return sum;
}

int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}