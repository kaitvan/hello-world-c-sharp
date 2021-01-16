using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {

            // ***** Validator *****

            // *** Validate a pin number ***

            /*
            Console.WriteLine("Enter a pin:");
            var pinInput = Console.ReadLine();

            string pinResult = "";

            char[] pinChars = pinInput.ToCharArray();

            if (pinChars.Length >= 4 && pinChars.Length <= 8)
            {
                foreach (var character in pinChars)
                {
                    if (Char.IsNumber(character))
                    {
                        pinResult = "true";
                    }
                    else
                    {
                        pinResult = "false";
                        break;
                    }
                }
            }
            else
            {
                pinResult = "false";
            }

            Console.WriteLine(pinResult);
            */

            // *** Validate a phone number ***

            /*
            Console.WriteLine("Enter a phone number:");
            var phoneInput = Console.ReadLine();

            var charsToRemove = new string[] { " ", "-", "(", ")" };

            var phoneResult = "";

            foreach (var c in charsToRemove)
            {
                phoneInput = phoneInput.Replace(c, string.Empty);
            }

            char[] phoneChars = phoneInput.ToCharArray();

            if (phoneChars[0] == '5' && phoneChars[1] == '5' && phoneChars[2] == '5')
            {
                phoneResult = "Please enter a valid phone number.";
            }
            else if (phoneChars.Length == 10)
            {
                foreach (var c in phoneChars)
                {
                    if (Char.IsNumber(c))
                    {
                        phoneResult = "true";
                    }
                    else
                    {
                        phoneResult = "Please enter a valid phone number.";
                        break;
                    }
                }
            }
            else
            {
                phoneResult = "Please enter a valid phone number.";
            }

            Console.WriteLine(phoneResult);
            */

            // *** Validate an email address ***

            /*
            Console.WriteLine("Please enter your email address:");
            var emailInput = Console.ReadLine();

            var emailResponse = "Please enter a valid email address.";

            char[] emailChars = emailInput.ToCharArray();

            var atCounter = 0;
            var dotCounter = 0;
            var indexOfAt = Array.IndexOf(emailChars, '@');
            var indexOfDot = 0;

            var currentIndex = 0;

            foreach (var character in emailChars)
            {
                if (character == '@')
                {
                    atCounter++;
                }
                else if (character == '.' && currentIndex > indexOfAt)
                {
                    dotCounter++;
                    indexOfDot = currentIndex;
                }
                currentIndex++;
            }

            var domain = emailInput.Substring(indexOfDot);
            bool tldPresent = false;
            string[] tlds = { ".com", ".org", ".net", ".us", ".co", ".uk", ".de", ".tk", ".cn" };

            foreach (var tld in tlds)
            {
                if (tld == domain)
                {
                    tldPresent = true;
                    break;
                }
            }

            if (atCounter == 1 && dotCounter == 1 && emailChars[0] != '@' && emailChars[indexOfAt + 1] != '.' && tldPresent)
            {
                if (indexOfAt < indexOfDot)
                {
                    emailResponse = "true";
                }
            }

            Console.WriteLine(emailResponse);
            */


            // ***** Mask Sensitive Information *****

            //Console.WriteLine("Tell me a secret:");
            //var secretInput = Console.ReadLine();

            //var maskedSecret = secretInput.Substring(secretInput.Length - 4).PadLeft(secretInput.Length, '*');

            /*
            char[] secretChars = secretInput.ToCharArray();

            var secretOutput = "";

            for (var i = 0; i < secretChars.Length; i++)
            {
                if (i > secretChars.Length - 4)
                {
                    secretOutput += secretChars[i];
                }
                else
                {
                    secretOutput += "*";
                }
            }
            */

            //Console.WriteLine(maskedSecret);


            // ***** Calculator Exercise *****

            // *** Multiplication or Squares ***

            
            Console.WriteLine("Enter an operation and a space, followed by a list of numbers, with each number separated by a comma.");
            var calculationInput = Console.ReadLine();

            var indexOfSpace = calculationInput.IndexOf(' ');

            string numbersString = calculationInput.Substring(indexOfSpace + 1);
            string operationString = calculationInput.Substring(0, indexOfSpace);

            string[] splitArray = numbersString.Split(",");
            int[] intArray = Array.ConvertAll(splitArray, int.Parse);

            if (operationString == "^2")
            {
                string squaredResult = "";
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
                Console.WriteLine(squaredResult);
            }
            else if (operationString == "*")
            {
                int product = 1;
                foreach (var number in intArray)
                {
                    product *= number;
                }

                Console.WriteLine(product);
            }
            else if (operationString == "+")
            {
                int sum = 0;
                foreach (var number in intArray)
                {
                    sum += number;
                }
                Console.WriteLine(sum);
            }
            else if (operationString == "/")
            {
                var quotient = intArray[0];
                for (var i = 1; i < intArray.Length; i++)
                {
                    quotient /= intArray[i];
                }
                Console.WriteLine(quotient);
            } else if (operationString == "avg")
            {
                int sum = 0;
                foreach (var number in intArray)
                {
                    sum += number;
                }
                int average = sum / intArray.Length;
                Console.WriteLine(average);
            }



            // ***** Letter Loops *****

            /*
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
            */



            // ***** Console Input Exercise *****

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



            // ***** Hello, World Exercise *****

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
