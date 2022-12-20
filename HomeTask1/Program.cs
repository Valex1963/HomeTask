Console.WriteLine("Ведите первое число:  ");
Console.WriteLine( "Введите второе число:  ");

int numberA = int.Parse(Console.ReadLine());
int numberB = int.Parse(Console.ReadLine());

if (numberA > numberB)
{
    Console.WriteLine("Первое число = max");
}

if (numberB > numberA)
{
    Console.WriteLine("Второе число = max");
}



