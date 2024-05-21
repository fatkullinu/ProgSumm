void Main()
{
// Запрашиваем массив строк
Console.WriteLine("Вводите элементов массива через запятую например: Hello, 2, world,:-) :");
string? input = Console.ReadLine();

// Разбиваем введенную строку на массив строк
string[] array = input!.Split(',');

// Формируем новый массив из строк, длина которых меньше или равна 3 символам
string[] newArray = FilterArray(array);

// Выводим новый массив на экран
Console.WriteLine("Новый массив:");
PrintArray(newArray);
}

Main();
