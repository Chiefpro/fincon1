/* Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
 длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
 либо задать на старте выполнения алгоритма.
 При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами. */

int longArray = Vvod("Введите из какого количества элементов будет массив => ", "Error!!!");



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

static void FinalControl()
{

}



#endregion