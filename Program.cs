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
string role = "admin";
string result = role switch
{
    "admin" => "Полный доступ",
    "teacher" => "Доступ преподавателя",
    _ => "Ограниченный доступ"
};
Console.WriteLine($"{role} — {result}");

role = "user";
result = role switch
{
    "admin" => "Полный доступ",
    "teacher" => "Доступ преподавателя",
    _ => "Ограниченный доступ"
};
Console.WriteLine($"{role} — {result}");

role = "teacher";
result = role switch
{
    "admin" => "Полный доступ",
    "teacher" => "Доступ преподавателя",
    _ => "Ограниченный доступ"
};
Console.WriteLine($"{role} — {result}");

// ===== Шаг 4b. when (вход только при 18+ и наличии билета) =====
int age = 20;
bool hasTicket = true;
switch (age)
{
    case >= 18 when hasTicket:
        Console.WriteLine("Вход разрешён");
        break;
    case >= 18:
        Console.WriteLine("Нет билета");
        break;
}

age = 20;
hasTicket = false;
switch (age)
{
    case >= 18 when hasTicket:
        Console.WriteLine("Вход разрешён");
        break;
    case >= 18:
        Console.WriteLine("Нет билета");
        break;
}

age = 16;
hasTicket = true;
switch (age)
{
    case >= 18 when hasTicket:
        Console.WriteLine("Вход разрешён");
        break;
    case >= 18:
        Console.WriteLine("Нет билета");
        break;
}
int level = 2;
switch (level)
{
    case 1:
        Console.WriteLine("Начальный уровень");
        break;
    case 2:
        Console.WriteLine("Средний уровень");
        goto case 1;
    case 3:
        Console.WriteLine("Продвинутый уровень");
        break;
}

// ===== Самостоятельная задача А. Время года =====
int month = 12;
string season = month switch
{
    12 or 1 or 2 => "Зима",
    3 or 4 or 5 => "Весна",
    6 or 7 or 8 => "Лето",
    9 or 10 or 11 => "Осень",
    _ => "Неверный месяц"
};
Console.WriteLine($"Месяц {month} — {season}");
int number = 42;
string size = number switch
{
    < 0 => "Отрицательное",
    <= 9 => "Однозначное",
    <= 99 => "Двузначное",
    _ => "Трёхзначное или больше"
};
Console.WriteLine($"Число {number} — {size}");

number = 2;
size = number switch
{
    1 or 2 or 3 => "Маленькое число",
    <= 9 => "Однозначное",
    <= 99 => "Двузначное",
    _ => "Трёхзначное или больше"
};
Console.WriteLine($"Число {number} — {size}");
Console.Write("Введите свою фамилию: ");
string surname = Console.ReadLine()!.Trim();

if (string.IsNullOrEmpty(surname))
{
    Console.WriteLine("Фамилия не введена. Завершение работы.");
    return;
}

Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear);

var assigned = Enumerable.Range(1, 10)
    .OrderBy(_ => rnd.Next())
    .Take(2)
    .OrderBy(x => x)
    .ToList();

Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");
Console.Write("Количество очков: ");
if (int.TryParse(Console.ReadLine(), out int points))
{
    string rank = points switch
    {
        < 0 => "Ошибка",
        <= 999 => "Новичок",
        <= 4999 => "Опытный",
        <= 9999 => "Продвинутый",
        _ => "Мастер"
    };
    Console.WriteLine(rank);
}
else Console.WriteLine("Ошибка ввода");
Console.Write("Транспорт (автобус/метро/такси): ");
string transport = Console.ReadLine()!.Trim().ToLower();
string kind = transport switch
{
    "автобус" => "Наземный транспорт",
    "метро"   => "Подземный транспорт",
    "такси"   => "Индивидуальный транспорт",
    _         => "Неизвестный транспорт"
};
Console.WriteLine(kind);