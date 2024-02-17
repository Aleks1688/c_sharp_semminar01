Console.WriteLine("Введите трехзначное целое число");
int num = Convert.ToInt32(Console.ReadLine());

int numCheck = num;
if (num <0 ) numCheck = -num;

if(numCheck >= 100 && numCheck <= 999)
{
    int digitFirst = numCheck / 100;
    int digitLast = numCheck % 10;

    int sumDigits = digitFirst + digitLast;
    Console.WriteLine($"сумма первой и последней цифры = {sumDigits}");
}
else
{
    Console.WriteLine("некорректный ввод");
}