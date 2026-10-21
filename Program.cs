/*int age = 20;
if (age >= 21) {
    Console.WriteLine("Доступ разрешён");
}

Console.WriteLine("Программа продолжает работу");

int age = 15;
if (age >= 18) {
    Console.WriteLine("Доступ разрешён");
} else {
    Console.WriteLine("Доступ запрещён");
    Console.WriteLine(\$"До совершеннолетия осталось {18 - age} лет");
}


int age = 14;
if (age < 13) {
    Console.WriteLine("Ребёнок");
} else if (age < 18) {
    Console.WriteLine("Подросток");
} else if (age < 60) {
    Console.WriteLine("Взрослый");
} else {
    Console.WriteLine("Пенсионер");
}



int age = 16;
double height = 1.55;
bool hasAdultSupervision = true;

if (age >= 14 && height >= 1.5) {
    Console.WriteLine("Можно кататься");
} else if (height < 1.5 && hasAdultSupervision) {
    Console.WriteLine("Можно кататься");
} else {
    Console.WriteLine("Пока нельзя");
}


Console.Write("Введите число: ");
string input = Console.ReadLine();

if (int.TryParse(input, out int number))
{
    if (number % 2 == 0)
    {
        Console.WriteLine("Число чётное.");
    }
    else
    {
        Console.WriteLine("Число нечётное.");
    }
}
else
{
     Console.WriteLine("Это не корректное целое число.");
}






Console.Write("Введите первое число: ");
string input1 = Console.ReadLine();

Console.Write("Введите второе число: ");
 string input2 = Console.ReadLine();

 Console.Write("Введите третье число: ");
string input3 = Console.ReadLine();

if (int.TryParse(input1, out int num1) &&
    int.TryParse(input2, out int num2) &&
    int.TryParse(input3, out int num3))
{
    int max = Math.Max(num1, Math.Max(num2, num3));

    Console.WriteLine($"Наибольшее число: {max}");
}
else
    Console.WriteLine("Ошибка: пожалуйста, вводите только целые числа.");


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




Console.Write("Введите сумму покупки: ");
if (double.TryParse(Console.ReadLine(), out double amount))
{
    double discount = 0;

    if (amount > 1000)
        discount = 0.10;
    else if (amount > 500)
        discount = 0.05;

    double finalAmount = amount * (1 - discount);
    Console.WriteLine($"Итоговая сумма к оплате: {finalAmount:F2}");
}
else
{
    Console.WriteLine("Некорректный ввод.");
}*/



Console.Write("Введите год: ");
if (int.TryParse(Console.ReadLine(), out int year))
{
    bool isLeap = (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);

    if (isLeap)
        Console.WriteLine("Год високосный, в феврале 29 дней");
    else
        Console.WriteLine("Год не високосный, в феврале 28 дней");
}
else
{
    Console.WriteLine("Некорректный ввод.");
}
    


