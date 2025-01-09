// See https://aka.ms/new-console-template for more information

using System.Formats.Asn1;

int age;
int cash;

Console.WriteLine("Welcome to the game! \nPlease enter your age.");
age = Convert.ToInt32(Console.ReadLine());

if (age >= 18){
    Console.WriteLine("Okay you can buy a ticket.");

            Console.WriteLine("Tickets are 5$. Please insert cash.");
        cash = Convert.ToInt32(Console.ReadLine());

        while (cash < 5)
        {
        Console.WriteLine("That's not enough. Please insert more cash.");
        int additionalCash = Convert.ToInt32(Console.ReadLine());
        cash += additionalCash; // Kullanıcıdan ek para al ve toplam paraya ekle
    }

        
        if (cash == 5) {
            Console.WriteLine("Thank you! Here is your ticket.");
        }
        else {
         
          int change = cash - 5;
            Console.WriteLine("Thank You! Here is your ticket and  " + change + " dollars in change.");
        }
}
else {
    Console.WriteLine("Sorry you are too young to buy a ticket.");
}

Console.WriteLine("Press any key to exit.");
Console.ReadKey();