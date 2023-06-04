/* Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
 длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
 либо задать на старте выполнения алгоритма.
 При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами. */

int longArray = Vvod("Введите из какого количества элементов будет массив => ", "Error!!!");
string[] array =  NewArrayString(longArray);



Console.WriteLine("Hello, World!");


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
        Console.Write($"Введи {i+1} элемент массива => ");
        Console.ReadLine();
        Console.WriteLine();
    }
    return arr;
}

static void FinalControl()
{

}



#endregion