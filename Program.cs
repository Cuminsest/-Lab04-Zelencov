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
*/


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
