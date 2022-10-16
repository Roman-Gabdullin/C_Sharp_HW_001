Console.Write ("Введите целое число:");
int num1 = Convert.ToInt32 (Console.ReadLine());
int num2 = 0;
while (num2 <= num1 )
{
    num2 = num2 + 2;
    if (num2 <= num1)
    {
    Console.WriteLine ($"{num2} ");
    }
}