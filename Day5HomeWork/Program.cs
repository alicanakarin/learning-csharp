// See https://aka.ms/new-console-template for more information


Random numberGen = new Random();

int roll01 = 0;
int roll02 = 1;
int attempts = 0;

Console.WriteLine("Press any key to roll the dices");

while (roll01 != roll02) {
    Console.ReadKey();
    roll01 = numberGen.Next(1, 7);
    roll02 = numberGen.Next(1, 7);

    Console.WriteLine("Roll 1: " + roll01);
    Console.WriteLine("Roll 2: " + roll02 + "\n");
    attempts++;
    }

    Console.WriteLine("It took " + attempts + " attempts to roll the same number");

    Console.ReadKey();