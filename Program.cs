using System;

Main();

void Main()
{
    Console.WriteLine("Welcome to the Enthusiastic Moose Simulator!");
    Console.WriteLine("--------------------------------------------");
    Console.WriteLine();

    // Let the moose speak!
    MooseSays("H I, I'M  E N T H U S I A S T I C !");
    MooseSays("I really am enthusiastic");

    // Ask a question
    MooseAnswer("Is Canada real?", "Really? It seems very unlikely.", "I  K N E W  I T !!!");
    MooseAnswer("What is the airspeed velocity of an unladen swallow?", "African or European?", "I don't know that. AUUUUUUUGGGGGGGGGGGHHH!");
    MooseAnswer("Are you the Grand Magus?", "I AM THE GRAND MAGUSSSSSSS", "I only play pos1");
    MooseAnswer("Will Liquid win TI?", "WE'RE GONNA WIN TI BABY WOOOOOO", "sadge");

    void MooseSays(string message)
    {
        Console.WriteLine($@"
                                      _.--^^^--,
                                    .'          `\
  .-^^^^^^-.                      .'              |
 /          '.                   /            .-._/
|             `.                |             |
 \              \          .-._ |          _   \
  `^^'-.         \_.-.     \   `          ( \__/
        |             )     '=.       .,   \
       /             (         \     /  \  /
     /`               `\        |   /    `'
     '..-`\        _.-. `\ _.__/   .=.
          |  _    / \  '.-`    `-.'  /
          \_/ |  |   './ _     _  \.'
               '-'    | /       \ |
                      |  .-. .-.  |
                      \ / o| |o \ /
                       |   / \   |    {message}
                      / `^`   `^` \
                     /             \
                    | '._.'         \
                    |  /             |
                     \ |             |
                      ||    _    _   /
                      /|\  (_\  /_) /
                      \ \'._  ` '_.'
                       `^^` `^^^`
    ");
    }


    bool MooseAsks(string question)
    {
        Console.Write($"{question} (Y/N): ");
        string answer = Console.ReadLine().ToLower();

        while (answer != "y" && answer != "n")
        {
            Console.Write($"{question} (Y/N): ");
            answer = Console.ReadLine().ToLower();
        }

        if (answer == "y")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    void MooseAnswer(string question, string yesResponse, string noResponse)
    {
        bool isCorrect = MooseAsks(question);
        if (isCorrect)
        {
            MooseSays(yesResponse);
        }
        else
        {
            MooseSays(noResponse);
        }
    }

}