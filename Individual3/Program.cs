using System.Runtime.ExceptionServices;

string vvod = "222222*11111";

char [] input = vvod.ToCharArray();
int separator = 0;
for (int i = 0; i < input.Length; i++)
{
    if (input[i]=='*')
	{
		separator = i;
	}
}

int[] firstNumber = new int[separator];

for (int i = 0; i < separator; i++)
{
	firstNumber[i] = (int)Char.GetNumericValue(input[i]);
}

int[] secondNumber = new int[input.Length-separator-1];

for (int i = separator+1;i < input.Length; i++)
{
	secondNumber[i-separator-1] = (int)Char.GetNumericValue(input[i]);
}


    string numberStringFirst = string.Join("", firstNumber);
    string numberStringSecond = string.Join("", secondNumber);

    int numberIntFirst = int.Parse(numberStringFirst);
    int numberIntSecond = int.Parse(numberStringSecond);

 
   int result = numberIntFirst-numberIntSecond;

Console.WriteLine(result);




