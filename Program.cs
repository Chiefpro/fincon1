/* Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
 длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
 либо задать на старте выполнения алгоритма.
 При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами. */

int longArray = Vvod("Введите из какого количества элементов будет массив => ", "Error!!!");
string[] array = NewArrayString(longArray);
string[] newarray = FinalControl(array);
PrintArrayString(newarray);





#region 
static int Vvod(string text, string error)
{
    while (true)
    {
        Console.Write(text);
        if (int.TryParse(Console.ReadLine(), out int var) && var > 0)
            return var;
        else Console.WriteLine(error);
    }
}
static string[] NewArrayString(int longar)
{
    string[] arr = new string[longar];
    for (int i = 0; i < longar; i++)
    {
        Console.Write($"Введи {i + 1} элемент массива => ");
        arr[i] = Console.ReadLine();
        Console.WriteLine();
    }
    return arr;
}

static string[] FinalControl(string[] arr)
{
    int newLong = 0;
    foreach (string el in arr)
    {
        if (el.Length <= 3) newLong++;
    }
    string[] newarr = new string[newLong];
    int j = 0;
    foreach (string el in arr)
    {
        if (el.Length <= 3)
        {
            newarr[j] = el;
            j++;
        }
    }
    return newarr;
}

static void PrintArrayString(string[] arr)
{
    for (int i=0; i<arr.Length;i++)
    {
        Console.Write($"{arr[i]}\t");
    }
    Console.WriteLine();
}


#endregion