
string[] InputUser(int size)
{
    string[] array = new string[size];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите {i + 1}е значение: ");
        array[i] = Console.ReadLine();
    }
    return array;
}


void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}]");
    }
}


string[] EditInputUser(string[] array)
{
    int length = array.Length;
    string[] result = new string[length];
    int count = 0;

    for (int i = 0; i < length; i++)
    {
        if (array[i].Length <= 3)
        {
            result[count] = array[i];
            count++;
        }
    }
    Array.Resize(ref result, count);

    return result;
}

Console.Clear();
int arraySize = default;
Console.Write("Сколько значений будем вводить? ");
while (!int.TryParse(Console.ReadLine(), out arraySize) || arraySize < 0)
{
    Console.Write("Ошибка ввода. \nСколько значений будем вводить? ");
}
string[] matrix = InputUser(arraySize);
PrintArray(matrix);
Console.WriteLine();
Console.WriteLine("ниже значения длиной меньше 3 символов");
string[] shortArray = EditInputUser(matrix);
PrintArray(shortArray);
