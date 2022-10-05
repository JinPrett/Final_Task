// -- Задание
// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.
// -- Условия
// При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. (задали на старте)

// Программа

string[] Massiv01 = new string[8] { "12345", "45", "hello", "Moscow", "QA", "print", "world", "res" };
string[] Massiv02 = new string[Massiv01.Length];
SelectionArray(Massiv01, Massiv02);
Massiv02 = Massiv02.Where(x => x != null).ToArray();
PrintArray(Massiv01);
Console.Write(" -> ");
PrintArray(Massiv02);

//Блок Функций

void SelectionArray(string[] array1, string[] array2) // Выборка массива - проверяем на условие и наполняем второй массив
{
    int index = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[index] = array1[i];
            index++;
        }
    }    
}

void PrintArray(string[] array) // вывод итогов на печать
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.Write("]");
}
