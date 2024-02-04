// variables here
string intro = "This is a game of the game rock paper scissors \nYou will have 2 modes:\n1.:Best of 3\n2.:Endurance run\nThere isnt much from here\n\nEnter option: ";
string menu = "Type [ 1 ] to play the Best of 3 mode\nType [ 2 ] to play Endurance run\nType [ 3 ] to read the intro again\nType [ 4 ] to exit the program\n";
string EnduranceRun_menu = "Type [ 1 ] to play the mode\nType [ 2 ] to back to the previous menu\n";
bool canExit = false;
//methods here


string enemyThrow()
{
    Random r = new Random();
    int n = r.Next(1, 4);
    switch (n)
    {
        case 1:
            return "rock";
        case 2:
            return "scissor";
        case 3:
            return "paper";
        default:
            return "beans";
    }

}


void exitProgram()
{
    Console.WriteLine("The program will end in");
    Thread.Sleep(1000);
    Console.WriteLine("3");
    Thread.Sleep(1000);
    Console.WriteLine("2");
    Thread.Sleep(1000);
    Console.WriteLine("1");
    Thread.Sleep(1000);
    Environment.Exit(-1);
}



void playerWin(string playerHand, string enemyHand)
{
    Console.WriteLine($"You threw a {playerHand}");
    Thread.Sleep(1000);
    Console.WriteLine($"The enemy threw a {enemyHand}");
    Thread.Sleep(1000);
    Console.WriteLine("You win now");
}

void playerLose(string playerHand,string enemyHand)
{
    Console.WriteLine($"You threw a {playerHand}");
    Thread.Sleep(1000);
    Console.WriteLine($"The enemy threw a {enemyHand}");
    Thread.Sleep(1000);
    Console.WriteLine("You lose now");
}

void playerDraw(string playerHand)
{
    Console.WriteLine($"You threw a {playerHand}");
    Thread.Sleep(1000);
    Console.WriteLine("So did the enemy");
}

void enduGame()
{
    Console.WriteLine(EnduranceRun_menu);
    int EndMenuOption = Convert.ToInt32(Console.ReadLine());
    switch (EndMenuOption)
    {
        case 1:
            enduRun();
            break;
        case 2:
            break;
        default:
            Console.WriteLine("Incorrect input, lean to read");
            break;

    }
}

void enduRun()
{
    int score = 0;
    int e_score = 0;
    Console.WriteLine("Lose 3 times and it ends\nmake sure you say the hand symbol needed");
    while (e_score < 3)
    {
        Console.WriteLine("Enter your hand:\n");
        string hand = Console.ReadLine();
        string enemyHand = enemyThrow();
        string playerHand = hand.ToLower().Trim();
        if (playerHand == enemyHand)
        {
            playerDraw(playerHand);

        }
        else if (playerHand == "rock" && enemyHand == "paper")
        {
            playerLose(playerHand, enemyHand);
            e_score++;
        }
        else if (playerHand == "rock" && enemyHand == "scissor")
        {
            playerWin(playerHand, enemyHand);
            score++;
        }
        else if (playerHand == "paper" && enemyHand == "rock")
        {
            playerWin(playerHand, enemyHand);
            score++;
        }
        else if (playerHand == "paper" && enemyHand == "scissor")
        {
            playerLose(playerHand, enemyHand); ;
            e_score++;
        }
        else if (playerHand == "scissor" && enemyHand == "rock")
        {
            playerLose(playerHand, enemyHand);
            e_score++;
        }
        else if (playerHand == "scissor" && enemyHand == "paper")
        {
            playerWin(playerHand, enemyHand);
            score++;
        }
        else
        {
            Console.WriteLine("nuh uh");
        }
    }
    if (score >= 0 && score < 5)
    {
        Console.WriteLine($"Not bad you got a score of {score}");
    }
    else
    {
        Console.WriteLine($"Guess youre pretty lucky, you got a score of {score}");
    }
    
}
void bestOf3()
    {
        bool stop = false;
        int score = 0;
        int e_score = 0;
        Console.WriteLine("This is the best of 3 mode\nmake sure you say the hand symbol needed");
        for (int i = 0; (i < 3) && !stop; i = i)
        {
            Console.WriteLine("Enter your hand:\n");
            string hand = Console.ReadLine();
            string enemyHand = enemyThrow();
            string playerHand = hand.ToLower().Trim();
            if ((playerHand == enemyHand)&&!stop)
            {
                playerDraw(playerHand);

            }
            else if ((playerHand == "rock" && enemyHand == "paper")&& !stop)
            {
                playerLose(playerHand, enemyHand);
                e_score++;
                i++;
            }
            else if ((playerHand == "rock" && enemyHand == "scissor")&& !stop)
            {
                playerWin(playerHand, enemyHand);
                score++;
                i++;
            }
            else if ((playerHand == "paper" && enemyHand == "rock") && !stop)
        {
                playerWin(playerHand, enemyHand);
                score++;
                i++;
            }
            else if ((playerHand == "paper" && enemyHand == "scissor")&& !stop)
            {
                playerLose(playerHand, enemyHand);
                i++;
                e_score++;
            }
            else if ((playerHand == "scissor" && enemyHand == "rock") && !stop)
        {
                playerLose(playerHand, enemyHand);
                i++;
                e_score++;
            }
            else if ((playerHand == "scissor" && enemyHand == "paper")&& !stop)
            {
                playerWin(playerHand, enemyHand);
                score++;
                i++;
            }
            else if ((score > 1 || e_score > 1)&& !stop)
            {
                stop = true;
               
            }
            else
            {
                Console.WriteLine("nuh uh");
            }
        }
        if (score > 1)
        {
            Console.WriteLine("yippie you win");
        }
        else
        {
            Console.WriteLine("you do not win");
        }

    }





    Console.WriteLine(intro);
    do
    {
        Console.WriteLine(menu);
        int menuOption = Convert.ToInt32(Console.ReadLine());
        switch (menuOption)
        {
            case 1:
                bestOf3();//done
                break;
            case 2:
                enduGame();
                break;
            case 3:
                Console.WriteLine(intro);
                break;
            case 4:
                exitProgram();
                break;
            default:
                Console.WriteLine("Incorrect input, lean to read");
                break;

        }
    }
    while (!canExit);
    exitProgram();

