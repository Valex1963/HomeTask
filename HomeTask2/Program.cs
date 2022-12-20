Console.WriteLine("Ведите первое число:  ");
int A =  int.Parse(Console.ReadLine());
Console.WriteLine( "Введите второе число:  ");
int B =  int.Parse(Console.ReadLine());
Console.WriteLine("Ведите третье число:  ");
int D =  int.Parse(Console.ReadLine());

int max = A;

if (A > max) max = A;
if (B > max) max = B;
if (D > max) max = D;

Console.Write("max =  ");
Console.WriteLine(max);

