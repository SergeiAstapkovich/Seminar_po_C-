// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число");

int number = int.Parse(Console.ReadLine());
int count = 0;
int chislo = 0;

while(count < number)
{
    chislo = chislo + 1;

    if((chislo % 2) == 0)
    {
        Console.Write(chislo);
        Console.Write(", ");


    }
    
    count = count + 1;    
}


