void Main()
{
    // Запрашиваем массив строк
    Console.WriteLine("Вводите элементов массива через запятую например: Hello, 2, world,:-) :");
    string? input = Console.ReadLine();

    // Разбиваем введенную строку на массив строк
    string[] array = input!.Split(',');

    // Формируем новый массив из строк, длина которых меньше чем 4 символа
    string[] newArray = FilterArray(array);

    // Выводим новый массив на экран
    Console.WriteLine("Новый массив:");
    PrintArray(newArray);
}

string[] FilterArray(string[] array)
{
    // Подсчитываем количество строк, в которых менее чем 4 символа
    int count = 0;
    foreach (string item in array)
    {
        if (item.Trim().Length < 4)
        {
            count++;
        }
    }

    // Создаем новый массив с подходящими строками
    string[] newArray = new string[count];
    int index = 0;
    foreach (string item in array)
    {
        if (item.Trim().Length <= 3)
        {
            newArray[index] = item.Trim();
            index++;
        }
    }

    return newArray;
}


Main();
