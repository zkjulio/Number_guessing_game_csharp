Random random = new Random();
bool playAgain = true;
int min = 1;
int max = 100;
int guess;
int number;
int guesses;
String response;

while (playAgain)
{
    guess = 0; guesses = 0;
    number = random.Next(min, max + 1);
    response = "";
    while (guess != number)
    {
        Console.WriteLine("Guess a number between " + min + " - " + max + " : ");
        guess = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Guess: " + guess);
        guesses++;

        if (guess > number)
        {
            Console.WriteLine("Too high bro/sis! Try Again!");
        }
        else if (guess < number)
        {
            Console.WriteLine("Too low buddy, try again!");
        }
        
    }   
    Console.WriteLine("Number: " + number);
    Console.WriteLine("YOU WIN!");
    Console.WriteLine("Guesses: " + guesses);

    Console.WriteLine("Would you like to play again (Y/N)?");
    response = Console.ReadLine();
    response = response.ToUpper();

    if (response == "Y")
    {
        playAgain = true;
    }
    else
    {
        playAgain = false;
    }
}
Console.WriteLine("Thanks for playing! ... i guess");

Console.ReadKey();