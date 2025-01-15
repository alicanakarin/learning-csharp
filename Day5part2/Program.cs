// See https://aka.ms/new-console-template for more information

Random numberGen = new Random();

    int roll = 0;
    int attempts = 0;

    Console.WriteLine("Press enter to roll the dice");

    while(roll != 6){
        Console.ReadKey();
        roll = numberGen.Next (1, 7);
        Console.WriteLine("You rolled: " + roll);
        attempts++;
    }

    Console.WriteLine("It took you " + attempts + " attempts to roll six.");

    Console.ReadKey();