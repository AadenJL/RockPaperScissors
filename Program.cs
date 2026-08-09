Random random = new Random();
bool play_again = true;
string player = "";
string computer = "";
int player_score = 0;
int computer_score = 0;

while (play_again == true)
{
    switch (random.Next(1, 4))
    {
        case 1:
            computer = "ROCK";
            break;
        case 2:
            computer = "PAPER";
            break;
        case 3:
            computer = "SCISSORS";
            break;
    }
    Console.WriteLine("Please enter: ROCK / PAPER / SCISSORS");
    player = (Console.ReadLine()).ToUpper();
    if (player == computer)
    {
        Console.WriteLine("The computer chose: " + computer);
        Console.WriteLine("You chose: " + player);
        Console.WriteLine("It's a TIE!");
    }
    else if (player == "ROCK" && computer == "SCISSORS")
    {
        Console.WriteLine("The computer chose: " + computer);
        Console.WriteLine("You chose: " + player);
        Console.WriteLine("You WIN!");
        player_score++;
    }
    else if (player == "ROCK" && computer == "PAPER")
    {
        Console.WriteLine("The computer chose: " + computer);
        Console.WriteLine("You chose: " + player);
        Console.WriteLine("You LOSE!");
        computer_score++;
    }
    else if (player == "PAPER" && computer == "ROCK")
    {
        Console.WriteLine("The computer chose: " + computer);
        Console.WriteLine("You chose: " + player);
        Console.WriteLine("You WIN!");
        player_score++;
    }
    else if (player == "PAPER" && computer == "SCISSORS")
    {
        Console.WriteLine("The computer chose: " + computer);
        Console.WriteLine("You chose: " + player);
        Console.WriteLine("You LOSE!");
        computer_score++;
    }
    else if (player == "SCISSORS" && computer == "PAPER")
    {
        Console.WriteLine("The computer chose: " + computer);
        Console.WriteLine("You chose: " + player);
        Console.WriteLine("You WIN!");
        player_score++;
    }
    else if (player == "SCISSORS" && computer == "ROCK")
    {
        Console.WriteLine("The computer chose: " + computer);
        Console.WriteLine("You chose: " + player);
        Console.WriteLine("You LOSE!");
        computer_score++;
    }
    Console.WriteLine("The score is: Player - " + player_score + " / " + computer_score + " - Computer");
    Console.WriteLine("Would you like to play again? Enter 'YES' if so: ");
    string yesorno = (Console.ReadLine()).ToUpper();
    if (yesorno != "YES")
    {
        play_again = false;
    }
}
