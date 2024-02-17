using System.IO.Compression;

Console.WriteLine("Введите целое число a");
string str = Console.ReadLine();
int num1 = Convert.ToInt32(str);

Console.WriteLine("Введите целое число b");
int num2 = Convert.ToInt32(Console.ReadLine());

bool result = num1 == num2 * num2;

string resultStr = result ? "да" : "нет";

Console.WriteLine($"a = {num1}, b = {num2} => {resultStr}");