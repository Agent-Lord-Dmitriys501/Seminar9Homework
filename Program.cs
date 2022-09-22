// Задача 64: Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""
/*
Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
if (M > N) NaturalToLow(M, N);
else NaturalToLow(N, M);
// Рекурентные натурал. числа от M до N
void NaturalToLow(int M, int N)
{
    // Точка остановки
    if (N > M) return;
    else
    {
        //Рекурентный вызов
        NaturalToLow(M, N + 1);
        Console.Write(N + " ");
    }
    Console.WriteLine();
}

// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
//  M = 1; N = 15-> 120
//  M = 4; N = 8. -> 30

Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
if (M < N) SumHatyrMToN(M, N);
else SumHatyrMToN(N, M);

// вызов функции "SumHatyrMToN"
void SumHatyrMToN(int M, int N)
{
    Console.WriteLine(SummaMN(M - 1, N));
}

// функция суммы от M до N
int SummaMN(int M, int N)
{
    int result = M;
    // Точка остановки
    if (M == N)
        return 0;
    else
    {
        M++;
        //Рекурентный вызов
        result = M + SummaMN(M, N);
        return result;
    }
}
*/

// Задача 68: Напишите программу вычисления функции Аккермана с 
// помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
if (M > 0 && N > 0) AkkermanFun(M, N);
else if (M < N) AkkermanFun(N, M);
else Console.WriteLine("Вы ввели неположительный числа!");
// вызов функции AkkermanFun
void AkkermanFun(int M, int n)
{
    Console.WriteLine(Akkerman(M, N));
}

// функция Akkerman
int Akkerman(int M, int N)
{
    // Точка остановки
    if (M == 0)
    {
        return N + 1;
    }
    else if (N == 0 && M > 0)
    {
        //Рекурентный вызов
        return Akkerman(M - 1, 1);
    }
    else
    {
        //Рекурентный вызов
        return (Akkerman(M - 1, Akkerman(M, N - 1)));
    }
}