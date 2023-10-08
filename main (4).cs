using System;

class HelloWorld {
  static void Main() {
    Console.WriteLine("Выберите шкалу вводимой температуры");
    Console.WriteLine("1. Цельсий. 2. Кельвин. 3. Фаренгейт");
    int schala = Convert.ToInt32(Console.ReadLine()); //ВВОД ДАННЫХ INT - ЧИСЛА
    Console.WriteLine("Введите показатель температуры (градусы)");
    int graduz = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Выберите тип шкалы для конвертации: 1. Цельсий. 2. Кельвин. 3. Фаренгейт");
    int schala1 = Convert.ToInt32(Console.ReadLine());

    string perv = ""; // СТРОКА 
    if (schala == 1)
    {
        perv = "Цельсий";
    }
    else if (schala == 2)
    {
        perv = "Кельвин";
    }
    else if (schala == 3)
    {
        perv = "Фаренгейт";
    }

    string vtor = ""; //СТРОКА
    if (schala1 == 1)
    {
        vtor = "Цельсий";
    }
    else if (schala1 == 2)
    {
        vtor = "Кельвин";
    }
    else if (schala1 == 3)
    {
        vtor = "Фаренгейт";
    }

    Console.WriteLine("Вы выбрали: " + perv + " -> " + vtor); // НЕ ЗАБЫВАЕМ КАВЫЧКИ

    double temp = graduz; // DOUBLE - чтобы было значение после запятой , для питонистов это float
    if (schala == 1) // если введена температура в градусах Цельсия
    {
        if (schala1 == 2) //  в Кельвины
        {
            temp += 273.15;
        }
        else if (schala1 == 3) //  в Фаренгейты
        {
            temp = temp * 9 / 5 + 32;
        }
    }
    else if (schala == 2) // если введена  в Кельвинах
    {
        if (schala1 == 1) //  в градусы Цельсия
        {
            temp -= 273.15;
        }
        else if (schala1 == 3) // конвертируем в Фаренгейты
        {
            temp = (temp - 273.15) * 9 / 5 + 32;
        }
    }
    else if (schala == 3) // в Фаренгейтах
    {
        if (schala1 == 1) //  в градусы Цельсия
        {
            temp = (temp - 32) * 5 / 9;
        }
        else if (schala1 == 2) //  в Кельвины
        {
            temp = (temp - 32) * 5 / 9 + 273.15;
        }
    }

    Console.WriteLine("Результат: " + temp + " " + vtor);
  }
}