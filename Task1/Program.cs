// Задайте значения M и N. Напишите программу, которая выведет все чётные 
// натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"


int ReadInt(string mes)
{
    Console.WriteLine(mes);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

void PrintNaturalNum(int M, int N)
{
    if (M > N)
    {
        return;
    }
   if (M%2 == 0)
   {
    System.Console.Write($"{M}\t");
    PrintNaturalNum(M + 2, N);
   }
   else 
   {
    PrintNaturalNum(M + 1, N);
   }    
}

int Start = ReadInt("Введите число - начало диапазона: ");
int End = ReadInt("Введите число - конец диапазона: ");
PrintNaturalNum(Start, End);