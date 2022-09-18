Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int it = 1;

if (num < 1)
{
    Console.Write("Неверное число");
}
if (num == 1)
{
    Console.Write("Нет четных");
}
else while (it <= num)
{
    if ((it % 2) == 0)
    {
        Console.WriteLine(it);
          it = it + 1;
    }
       else if ((it % 2) == 1)
       {
        it = it + 1;
       }
}
