Console.WriteLine("Введите целое число");
int num = Convert.ToInt32(Console.ReadLine());

if (num <= 0)
{
    Console.WriteLine("Некорректный ввод!");
    return 546456;
}

int count = -num;

while (count <= num)
{
    //Console.Write(count + " ");
    Console.Write($"{count} ");
    count++;
}
