// Задача 64: Задайте значения N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// N = 5. -> "5, 4, 3, 2, 1"
// N = 8. -> "8, 7, 6, 5, 4, 3, 2, 1"
void NatralToLow(int num, int count)
{
    if (count>num)
    {
        return;
    }
    else
    {
        NatralToLow(num, count+1);
        Console.Write(count + " ");
    }
}

System.Console.WriteLine("Введите число: ");
int num  = Convert.ToInt32(Console.ReadLine());
int count = 1;
NatralToLow(num,  count);