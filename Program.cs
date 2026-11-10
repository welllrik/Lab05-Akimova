int dayNumber = 3;
switch (dayNumber)
{
    case 5 or 6 or 7:
        Console.WriteLine("Выходной");
        break;
}

dayNumber = 6;
switch (dayNumber)
{
    case 5 or 6 or 7:
        Console.WriteLine("Выходной");
        break;
}

dayNumber = 7;
switch (dayNumber)
{
    case 5 or 6 or 7:
        Console.WriteLine("Выходной");
        break;
}
int score = 49;
switch (score)
{
    case >= 0 and <= 39: Console.WriteLine("Неудовлетворительно"); break;
    case <= 59: Console.WriteLine("Удовлетворительно"); break;
    case <= 79: Console.WriteLine("Хорошо"); break;
    case <= 100: Console.WriteLine("Отлично"); break;
}

score = 50;
switch (score)
{
    case >= 0 and <= 39: Console.WriteLine("Неудовлетворительно"); break;
    case <= 59: Console.WriteLine("Удовлетворительно"); break;
    case <= 79: Console.WriteLine("Хорошо"); break;
    case <= 100: Console.WriteLine("Отлично"); break;
}

score = 70;
switch (score)
{
    case >= 0 and <= 39: Console.WriteLine("Неудовлетворительно"); break;
    case <= 59: Console.WriteLine("Удовлетворительно"); break;
    case <= 79: Console.WriteLine("Хорошо"); break;
    case <= 100: Console.WriteLine("Отлично"); break;
}

score = 85;
switch (score)
{
    case >= 0 and <= 39: Console.WriteLine("Неудовлетворительно"); break;
    case <= 59: Console.WriteLine("Удовлетворительно"); break;
    case <= 79: Console.WriteLine("Хорошо"); break;
    case <= 100: Console.WriteLine("Отлично"); break;
}

score = 101;
switch (score)
{
    case >= 0 and <= 39: Console.WriteLine("Неудовлетворительно"); break;
    case <= 59: Console.WriteLine("Удовлетворительно"); break;
    case <= 79: Console.WriteLine("Хорошо"); break;
    case <= 100: Console.WriteLine("Отлично"); break;
}
int temperature = -5;
string category = temperature switch
{
    < 0 => "Мороз",
    <= 14 => "Прохладно",
    <= 24 => "Комфортно",
    <= 34 => "Жарко",
    _ => "Очень жарко"
};
Console.WriteLine($"Температура {temperature} — {category}");

temperature = 5;
category = temperature switch
{
    < 0 => "Мороз",
    <= 14 => "Прохладно",
    <= 24 => "Комфортно",
    <= 34 => "Жарко",
    _ => "Очень жарко"
};
Console.WriteLine($"Температура {temperature} — {category}");

temperature = 20;
category = temperature switch
{
    < 0 => "Мороз",
    <= 14 => "Прохладно",
    <= 24 => "Комфортно",
    <= 34 => "Жарко",
    _ => "Очень жарко"
};
Console.WriteLine($"Температура {temperature} — {category}");

temperature = 30;
category = temperature switch
{
    < 0 => "Мороз",
    <= 14 => "Прохладно",
    <= 24 => "Комфортно",
    <= 34 => "Жарко",
    _ => "Очень жарко"
};
Console.WriteLine($"Температура {temperature} — {category}");

temperature = 40;
category = temperature switch
{
    < 0 => "Мороз",
    <= 14 => "Прохладно",
    <= 24 => "Комфортно",
    <= 34 => "Жарко",
    _ => "Очень жарко"
};
Console.WriteLine($"Температура {temperature} — {category}");