// Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int ReadInt(string mes)
{
    Console.WriteLine(mes);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int SumNaturalNum(int M, int N)
{
    if (M<0 || N<0)
    {
        return 0;
    }
    else if (M == 0) 
    {
    return (N * (N + 1)) / 2;
    }                
    else if (N == 0) 
    {
        return (M * (M + 1)) / 2;
    }
    else if (M == N)
    {
    return M;
    }     
    else if (M < N )
    {
        return N + SumNaturalNum(M, N - 1);
    }     
    else 
    {
        return N + SumNaturalNum(M, N + 1);
    }     
}


int Start = ReadInt("Введите число - начало диапазона: ");
int End = ReadInt("Введите число - конец диапазона: ");
SumNaturalNum(Start, End);
Console.WriteLine(SumNaturalNum(Start, End));