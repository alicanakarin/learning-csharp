// See https://aka.ms/new-console-template for more information


   Console.Write("How many cool numbers do you want: ");
   int count = Convert.ToInt32(Console.ReadLine());

   for (int i = 1; i <= count; i++)
{
    double result = Math.Pow(2, i);
  Console.WriteLine(result);

}






// wait before closing
 Console.ReadKey();