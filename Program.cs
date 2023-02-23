using System;
using System.Collections.Generic;

namespace Magic8Ball
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list of possible responses
            List<string> responses = new List<string>
            {
                "As I see it, yes.",
                "Ask again later.",
                "Better not tell you now.",
                "Cannot predict now.",
                "Concentrate and ask again.",
                "Don’t count on it.",
                "It is certain.",
                "It is decidedly so.",
                "Most likely.",
                "My reply is no.",
                "My sources say no.",
                "Outlook not so good.",
                "Outlook good.",
                "Reply hazy, try again.",
                "Signs point to yes.",
                "Very doubtful.",
                "Without a doubt.",
                "Yes.",
                "Yes – definitely.",
                "You may rely on it."
            };

            // Create a random number generator
            Random rand = new Random();

            while (true)
            {
                // Ask the user for a question
                MooseSays("What wisdom do you seek? (Press ENTER to exit)");

                // Read the user's input
                string question = Console.ReadLine();

                // If the user hit ENTER without asking a question, exit the program
                if (string.IsNullOrWhiteSpace(question))
                {
                    return;
                }

                // Generate a random integer from 0-19
                int index = rand.Next(0, 20);

                // Output the response based on the random integer
                MooseSays(responses[index]);
            }
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
        }

    }
}

