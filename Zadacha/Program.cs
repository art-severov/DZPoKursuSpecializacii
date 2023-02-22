// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться
// коллекциями, лучше обойтись исключительно массивами.
// Примеры: ["hello", "2", "world", ":-)"] -> ["2", "-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"] 
// ["Russia", "Denmark", "Kazan"] -> D


string[] arrayStart = new string[4] { "Hello", "2", "world", ":)" };
string[] arrayFinish = new string[arrayStart.Length];


void RedusedArray(string[] arrayStart, string[] arrayFinish)
{
    int count = 0;
    for (int i = 0; i < arrayStart.Length; i++)
    {
        if (arrayStart[i].Length <= 2)
        {
            arrayFinish[count] = arrayStart[i];
            count++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
RedusedArray(arrayStart, arrayFinish);
PrintArray(arrayStart);
Console.WriteLine("=>");
PrintArray(arrayFinish);