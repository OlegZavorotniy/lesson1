Console.WriteLine("Введите трехзначное число");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 0)
{
    num = -num;
}
if (num >= 100 && num <= 999)
{
    int numFirst = num / 100;
    int numSecond = num % 10;
    int result = numFirst + numSecond;
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("Неверное число");
}