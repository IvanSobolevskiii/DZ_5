Console.Write("Введите стартовое число : ");
int StartNum = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите конечное число : ");
int EndNum = Convert.ToInt32(Console.ReadLine());
PrintNatNumber(EndNum, StartNum);

void PrintNatNumber(int end, int start)
{
    Console.Write($"{start} ");
    if (start == end)
    {
        return;
    }
    PrintNatNumber(end, start + 1);
}