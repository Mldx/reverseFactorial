using System;

namespace reverseFactorial_dailyProgrammer_Easy286
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number to reverse factorial: ");
            int number;
            while (true) // If the user doesn't type a whole number, we just clear the console and ask the user again
            {
                try // If the user wrote letters or something like that in the input, the Convert.ToInt32(); would return an error since it can't convert a string to an int
                {
                    number = Convert.ToInt32(Console.ReadLine()); // Read the users number.
                    break; // Stop the while loop.
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("You have to write a whole number, no decimals, no letters, only numbers! :)");
                    Console.Write("Enter a number to reverse factorial: ");
                } // Try statement end
            } // While loop end
            reverse(number); // Run the function the number to reverse factorial as the arguement (int)
            Console.ReadKey(); // Prevent the window from closing instantly
        } // Main function end

        static void reverse(int revint) // Too lazy to use ulong instead of int
        {
            for (int i = 1; i <= 12; i++) // No need to go higher than 12. The factorial of 12 is the highest before integar overflow
            {
                if (revint == i) // If they are the same, then we found the factorial!
                {
                    Console.WriteLine("The factorial is: " + i.ToString() + "!");
                }
                else
                {
                    if (revint%(i+1) == 0) // I use this method: 120/1 -> 120/2 -> 60/3 -> 20/4 -> 5/5 -> 1 => 5!
                    { // If this does not equal zero, it means that the value doesn't have a whole number as a reverse factorial
                        if (revint / (i+1) == 1) // When dividing a number with itself you get one. So if this equals one, we know we found the factorial
                        {
                            Console.WriteLine("The factorial is: " + revint.ToString() + "!");
                            break;
                        }
                        else
                        {
                            revint /= i+1; // We go a step further in the method shown before
                        }
                    }
                    else
                    {
                        Console.WriteLine("The factorial is: None"); // The users number does not have a whole number as reverse factorial
                        break; // Stop the while loop since we alredy know it doesn't have a reverse factorial value
                    } // If statement end
                } // If statement end
            } // For loop end
        } // reverse function end
    } // Program class end
} // Namespace end
// Hopefully enough comments xD