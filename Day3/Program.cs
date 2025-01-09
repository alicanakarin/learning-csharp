// See https://aka.ms/new-console-template for more information

//variables = int (tam sayı), float (virgüllü), double (çok virgüllü), 
//            string (line, yazı), bool (true,false)

double numb01;
double numb02;
double numb03;

Console.Write("Input a number: ");
numb01 = Convert.ToDouble(Console.ReadLine());

Console.Write("Input a second number: ");
numb02 = Convert.ToDouble(Console.ReadLine());

Console.Write("Input a third number: ");
numb03 = Convert.ToDouble(Console.ReadLine());

double result = (numb01 + numb02 + numb03) / 3;
Console.WriteLine("The average of the your three number is: " + result);

Console.ReadKey();
