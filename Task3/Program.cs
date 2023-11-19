//Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int ReadInt(string mes)
{
    Console.WriteLine(mes);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int FuncAkkerman(int Number1, int Number2)
{
    if (Number1<0 && Number2<0)
    {
        return 0;
    }
    else if (Number1 == 0)
    {
        return Number2 + 1;
    }
    else if (Number2 == 0 )
    {
        return FuncAkkerman(Number1 - 1, 1);
    }
    else
    {
        return (FuncAkkerman(Number1 - 1, FuncAkkerman(Number1, Number2 - 1)));
    }
}


int m = ReadInt("Введите 1 неотрицательное число: ");
int n = ReadInt("Введите 2 неотрицательное число: ");
FuncAkkerman(m,n);
Console.WriteLine(FuncAkkerman(m, n));