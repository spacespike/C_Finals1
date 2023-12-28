// Написать программу, которая из имеющегося массива строк
// формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] UsersArray(int arraySize)
{
    string[] array = new string[arraySize];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Console.ReadLine();
    }

    return array;
}

string[] LengthMoreThanThree (string[] array)
{
    string[] resultArr = new string[array.Length];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <=3) {
        resultArr[j] = array[i];
        j++;
        }
    }
    return resultArr;
}

void PrintArray(string[] arr)
{
    foreach (string element in arr)
    {
        Console.Write($"{element} ");
    }

    Console.WriteLine();
}

Console.Write("Enter size of the array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter array's values: ");

string[] array = UsersArray(size);

Console.Write("Initial array: ");
PrintArray(array);

string[] result = LengthMoreThanThree(array);
Console.Write("Result array: ");
PrintArray(result);
