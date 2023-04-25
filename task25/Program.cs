//Напишите цикл, который на вход принимает числа (А и В) и
//возводит число А в натуральную степень.

Console.Clear();

int numA = GetFirstNumberFromUser("Введите число A: ", "Ошибка ввода!");
int numB = GetSecondNumberFromUser("Введите число B: ", "Ошибка ввода!");

double calculateResult = CalculateNumber(numA, numB);

PrintResult(numA,numB,calculateResult);

void PrintResult(int numA, int numB, double calculateResult)
{
    Console.WriteLine($"{numA},{numB} -> {calculateResult}");
}


int GetFirstNumberFromUser(string message, string errorMessage)
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

int GetSecondNumberFromUser(string message, string errorMessage)
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

double CalculateNumber(int numberA, int numberB)
{
    double result = Math.Pow(numberA, numberB);
    return result;
}


