System.Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine());
int count = 1;

while (count <= N)
{
    int X = count % 2;
    
    if (X == 0)
    {
        Console.Write($"{count}, ");
    } 
    
    count = count + 1;
        
}