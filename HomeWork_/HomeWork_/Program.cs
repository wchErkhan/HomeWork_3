using System;

namespace HomeWork_
{
    class Program
    {
        //1

        /*static void Main(string[] args)
        {
            int quantitySpace = 0;
            char temp = ' ';

            while (temp != '.')
            {
                temp = (char)Console.Read();
                if (temp == ' ')
                    quantitySpace++;
            }

            Console.WriteLine(quantitySpace);
            Console.ReadLine();
        }*/

        //2

        /*
        int length = 6;
        int number;

        Console.Write("Введите номер билета: ");
        string temp = Console.ReadLine();

        bool isInt = int.TryParse(temp, out number);

        if(isInt && temp.Length == length)
        {
        int half1 = number / 1000;
        int half2 = number % 1000;

        int digit1 = half1 / 100;
        int digit2 = (half1 / 10) % 10;
        int digit3 = half1 % 10;

        int summHalf1 = digit1 + digit2 + digit3;

        int digit4 = half2 / 100;
        int digit5 = (half2 / 10) % 10;
        int digit6 = half2 % 10;

        int summHalf2 = digit4 + digit5 + digit6;

        if(summHalf1 == summHalf2)
            Console.WriteLine("СЧАСТЛИВЫЙ БИЛЕТ!!!");
        else
            Console.WriteLine("Обычный билет");
        }
        else
        {
        Console.WriteLine("Введите номер трамвайного билета");
        }
        */

        //3

        /*
        char[] array;
        string input;
        string output;

        Console.Write("Строка: ");
        input = Console.ReadLine();

        array = input.ToCharArray(0, input.Length);
        for (int i = 0; i < array.Length; i++)
        {
        	int symbolCode = (int)array[i];
        	if (symbolCode >= 65 && symbolCode <= 90)
        	symbolCode += 32;
        	else if (symbolCode >= 97 && symbolCode <= 122)
        	symbolCode -= 32;

        	array[i] = (char)symbolCode;
        }

        output = String.Join("", array);
        Console.Write("Результат: " + output);
        */

        //4

        /*
        bool isInt;
        int a, b;
        Console.WriteLine("Введите числа А и В. (A < B)");
        do
        {
        	Console.Write("A: ");
        	isInt = int.TryParse(Console.ReadLine(), out a);
        	if (!isInt) Console.WriteLine("Не корректное число");

        } while (!isInt);

        do
        {
        	Console.Write("B: ");
        	isInt = int.TryParse(Console.ReadLine(), out b);
        	if (!isInt || b < a) Console.WriteLine("Не корректное число");

        } while (!isInt || b < a);

        Console.Clear();
        Console.WriteLine("A: {0};\tB: {1}\n", a, b);

        for(;a <= b; a++)
        {
        	for(int i = 0; i < a; i++)
        	{
        		Console.Write(a + " ");
        	}
        	Console.WriteLine();
        }
        */

    }

    //5
    /*
    static string Reverse(string input)
    {
    	char[] str = new char[input.Length];

    	for (int i = input.Length -1, j = 0; i >= 0; i--, j++)
    	{
    		str[j] = input[i];
    	}

    	string output = string.Join("", str);

    	return output;
    }
    static void Main(string[] args)
    {
    	int number;
    	string strNumber;

    	Console.Write("Введите положительное число: ");
    	strNumber = Console.ReadLine();

    	bool isInt = int.TryParse(strNumber, out number);

    	if (isInt && number > 0)
    	{
    		Console.WriteLine("Обратное число:\t" + Reverse(strNumber));
    	}
    	else
    	{
    		Console.WriteLine("Не соответствует условию");
    	}
    }
    */
}
