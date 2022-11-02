// Задача. Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] specifiedArray = new string[] { "1234", "C#", "76543", "teftel", "cat", "git", "gb" };
Console.WriteLine("Заданный массив: ");
PrintArray(specifiedArray);
int lengthCharacters = 3;
int lengthSecondaryArr = DetermineLengthSecondaryArr(specifiedArray, lengthCharacters);

// Найдем длину будущего массива.
int DetermineLengthSecondaryArr(string[] arr, int lengthChar)
{
    int counter = 0;
    for (int i = 0; i <= arr.Length - 1; i++)
    {
        if (arr[i].Length <= lengthChar) counter++;
    }
    return counter;
}

// Метод печати массива.
void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}