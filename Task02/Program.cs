Console.WriteLine("Введите целое число");
int num = Convert.ToInt32(Console.ReadLine());

int count = -num;

while (count <= num)
{
    //Console.Write(count + " ");
    Console.Write($"{count} ");
    count++;
}
