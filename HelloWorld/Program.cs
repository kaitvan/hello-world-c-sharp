using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {

            // Validator

            Console.WriteLine("Enter a pin:");
            var pinInput = Console.ReadLine();

            string result = "";

            char[] pinChars = pinInput.ToCharArray();

            if (pinChars.Length > 4 || pinChars.Length < 8)
            {
                foreach (var char in pinChars)
                result = "true";
            } else
            {
                result = "false";
            }
            
            // Mask Sensitive Information

            Console.WriteLine("Tell me a secret:");
            var secretInput = Console.ReadLine();

            char[] secretChars = secretInput.ToCharArray();

            var secretOutput = "";

            for (var i = 0; i < secretChars.Length; i++)
            {
                if (i < secretChars.Length - 4)
                {
                    secretOutput += secretChars[i];
                } else
                {
                    secretOutput += "*";
                }
            }

            Console.WriteLine(secretOutput);

            // Calculator Exercise

            // Multiplication or Squares

            Console.WriteLine("Enter a list of numbers, with each number separated by a comma.");
            var numbersInput = Console.ReadLine();

            Console.WriteLine("Would you like to square these numbers or multiply them? Type 'square' or 'multiply'.");
            var operationInput = Console.ReadLine();

            string[] splitArray = numbersInput.Split(",");
            int[] intArray = Array.ConvertAll(splitArray, int.Parse);

            int product = 1;

            string squaredResult = "";

            if (operationInput == "square")
            {
                for (var i = 0; i < intArray.Length; i++)
                {
                    if (i == intArray.Length - 1)
                    {
                        var result = intArray[i] * intArray[i];
                        squaredResult += result;
                    } else
                    {
                        var result = intArray[i] * intArray[i];
                        squaredResult += $"{result},";
                    }
                }
                Console.WriteLine($"{squaredResult}");
            }
            else if (operationInput == "multiply")
            {
                foreach (var number in intArray)
                {
                    product *= number;
                }

                Console.WriteLine($"{product}");
            }

            // Letter Loops

            Console.WriteLine("Enter a string of characters:");
            var input = Console.ReadLine();

            char[] characters = input.ToCharArray();

            string output = "";

            for (var index = 0; index < characters.Length; index++)
            {
                if (index == characters.Length - 1)
                {
                    output += $"{Char.ToUpper(characters[index])}";
                    for (var i = 0; i < index; i++)
                    {
                        output += $"{Char.ToLower(characters[index])}";
                    }
                } else if (index == 0)
                {
                    output += $"{Char.ToUpper(characters[index])}-";
                } else
                {
                    output += $"{Char.ToUpper(characters[index])}";
                    for (var i = 0; i < index; i++)
                    {
                        output += $"{Char.ToLower(characters[index])}";
                    }
                    output += "-";
                }
            }

            Console.WriteLine($"{output}");

            // Console Input Exercise

            /*
            ConsoleKeyInfo enteredKey;

            do
            {
                enteredKey = Console.ReadKey();
                Console.WriteLine($"You pressed the {enteredKey.Key.ToString()} key");

            } while (enteredKey.Key != ConsoleKey.Escape);

            string sentence;

            do
            {
                Console.WriteLine("Type in a sentence. Press enter when done.");
                sentence = Console.ReadLine();
                Console.WriteLine($"You entered the sentence: {sentence}");

            } while (sentence != "quit");
            */

            // Hello, World Exercise

            /*
            Console.WriteLine("Howdy Y'all!!");

            var animals = new string[] { "Triceratops", "Gorilla", "Corgi", "Toucan" };

            foreach (var animal in animals)
            {
                int syllableCounter = 0;

                char[] characters = animal.ToCharArray();

                //char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
                
                foreach (var character in characters)
                {
                    if (character == 'a' || character == 'e' || character == 'i' || character == 'o' || character == 'u')
                    {
                        syllableCounter++;
                    }
                }
                

                if (syllableCounter >= 3)
                {
                    Console.WriteLine(animal);
                }
            }

            var greetings = new string[] { "Howdy", "Aloha", "What's up" };

            Console.WriteLine("What is your name?");
            var nameInput = Console.ReadLine();

            Console.WriteLine("Please choose a greeting style: Southern, Hawaiian, or Casual.");
            var greetingInput = Console.ReadLine();

            if (greetingInput == "Southern" || greetingInput == "southern")
            {
                Console.WriteLine($"{greetings[0]}, {nameInput}!");
            } else if (greetingInput == "Hawaiian" || greetingInput == "hawaiian")
            {
                Console.WriteLine($"{greetings[1]}, {nameInput}!");
            } else if (greetingInput == "Casual" || greetingInput == "casual")
            {
                Console.WriteLine($"{greetings[2]}, {nameInput}?");
            } else
            {
                Console.WriteLine($"{greetings[0]}, {nameInput}!");
            }

            Random random = new Random();

            var randomAnimal = animals[random.Next(0, animals.Length)];

            Console.WriteLine("What is your favorite color?");
            var colorInput = Console.ReadLine();

            Console.WriteLine($"Would you like a {colorInput} {randomAnimal}?");
            */
        }
    }
}
