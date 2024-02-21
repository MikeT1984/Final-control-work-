using System;

class Program
{
    static void Main()
    {
        // Задаем начальный массив строк
        string[] initialArray = { "Hello", "2", "world", ":-)" };
        // Формируем новый массив из строк, длина которых меньше или равна 3 символам
        string[] newArray = CreateNewArray(initialArray);
        // Выводим новый массив на экран
        Console.WriteLine("Новый массив:");
        foreach (string str in newArray)
        {
            Console.WriteLine(str);
        }
    }
      static string[] CreateNewArray(string[] array)
    {
        // Подсчитываем количество строк в новом массиве
        int count = 0;
        foreach (string str in array)
        {
            if (str.Length <= 3)
            {
                count++;
            }
        }

        // Создаем новый массив с известным размером
        string[] newArray = new string[count];

        // Заполняем новый массив строками, длина которых меньше или равна 3 символам
        int index = 0;
        foreach (string str in array)
        {
            if (str.Length <= 3)
            {
                newArray[index] = str;
                index++;
            }
        }

        return newArray;
    }
}