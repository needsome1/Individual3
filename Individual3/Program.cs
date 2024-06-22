Console.WriteLine("Введите два двоичных числа разделенных '*'");
string input  = Console.ReadLine();

string[] numbers = input.Split('*');

if  (numbers.Length != 2)
{
    Console.WriteLine("Некорректный ввод");
    
}

string binary1 = numbers[0];
string binary2 = numbers[1];

int num1 = Convert.ToInt32(binary1);
int num2 = Convert.ToInt32(binary2);

int result = num1 - num2;

if (result < 0)
{
    Console.WriteLine("Ошибка. Вычитание отрицательное");
}
else
{
    string binaryDifference = Convert.ToString(result, 2);

    Console.WriteLine("Разность: " + binaryDifference);
}
