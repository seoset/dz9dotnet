using System;
using static System.Console;

Console.Clear();

int M = AskNumber("M");
int N = AskNumber("N");
Console.WriteLine($"Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N");
Console.WriteLine($"M = {M}; N = {N}. -> \"{PrintRange(M, N)}\"");

static string PrintRange(int M, int N) {
    if(N < M) {
        return "";
    }
    string part = N == M ? $"{N}" : $"{N}, ";
    return part + PrintRange(M, N - 1);
}

static int AskNumber(string name) {
    Write($"Введите число {name}: ");
    return int.Parse(ReadLine());
}
