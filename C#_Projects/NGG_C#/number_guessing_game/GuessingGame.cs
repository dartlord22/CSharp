class Program
{
    static void Main(string[] args)
    {
        // Create a Random object for generating random numbers.
        Random random = new Random();
        //'Random' is a class in C# that is part of the .NET Framework's System namespace. It is used for generating random numbers. You need to create an instance of the Random class to use its methods for generating random values.
        //'new Random()' is the constructor call that creates a new instance of the Random class. In C#, when you create an object, you typically use the new keyword followed by the class name and parentheses to call the constructor, which initializes the object.

        // Initialize some variables
        bool playAgain = true;  // A flag to control whether to play the game again
        int min = 1;           // The minimum value for the random number
        int max = 100;         // The maximum value for the random number
        int guess;             // Store the user's guess
        int number;            // Store the randomly generated number
        int guesses;           // Store the number of guesses made by the user
        String response;       // Store the user's response (Y/N)

        // Start a loop for playing the game
        while (playAgain == true)
        {
            guess = 0;        // Initialize guess to 0
            guesses = 0;      // Initialize the guess count to 0
            response = "";    // Initialize the user's response to an empty string

            // Generate a random number between 'min' and 'max'
            number = random.Next(min, max + 1); // for random.Next(min, max) the range would only be from 1 to 99, so we have to add 1 here to include 100 as an option

            // Start a loop for guessing the number
            while (guess != number)
            {
                // Prompt the user to guess a number within the specified range
                Console.WriteLine("Guess a number between " + min + " - " + max + " : ");
                guess = Convert.ToInt32(Console.ReadLine());

                // Check if the guess is too high or too low and provide feedback
                if (guess > number)
                {
                    Console.WriteLine(guess + " is too high!");
                }
                else if (guess < number)
                {
                    Console.WriteLine(guess + " is too low!");
                }

                guesses++;  // Increment the guess count
            }

            // The user guessed the correct number, so they win
            Console.WriteLine("Number: " + number);
            Console.WriteLine("YOU WIN!");
            Console.WriteLine("Guesses: " + guesses);

            // Ask if the user wants to play again
            Console.WriteLine("Would you like to play again? (Y/N): ");
            response = Console.ReadLine();
            response = response.ToUpper();

            // Check the user's response to determine if they want to play again
            if (response == "Y")
            {
                playAgain = true;  // Set playAgain to true to continue the game
            }
            else
            {
                playAgain = false; // Set playAgain to false to exit the game
            }
        }

        // The game loop has ended, wait for a key press to exit the program
        Console.ReadKey();
    }
}
