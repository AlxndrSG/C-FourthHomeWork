//Напишите программу, котрая задает массив из 8 элементов
//и выводит их на экран.

Console.Clear();

int[] array = GenerateArray();
PrintArray(array);

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($" {array[i]} ");
    }
    Console.Write("]");
}

int[] GenerateArray()
{
    int[] array = new int[8];
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(1, 99);
    }
    return array;
}

