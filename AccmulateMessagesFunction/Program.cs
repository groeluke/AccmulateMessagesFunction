/*Luke Groesbeck
Spring 2026
RCET 2265
Project MultiplicationTable
Computer Fundamentals and Introduction to Programming

*/

using System.Text;

namespace AccmulateMessagesFunction
{
    internal class Program
    {
        // We use StringBuilder for better performance when accumulating strings
        static StringBuilder transcript = new StringBuilder();
        static void Main(string[] args)
        {
            string userInput;
            bool keepGoing = true;

            Console.WriteLine(" Welcome to the Message Accumulator ");
            Console.WriteLine("Instructions: Enter a message to save it. Type 'exit' to finish.\n");

            while (keepGoing)
            {
                Console.Write
                    ("Enter message: ");
                userInput = Console.ReadLine();

                // Check if the user wants to quit
                if (userInput?.ToLower() == "exit")
                {
                    keepGoing = false;
                }
                else
                {
                    // Call the accumulation function
                    AccumulateMessage(userInput);
                    Console.WriteLine("Added!");
                }
            }

            // Display the final results
            DisplayTranscript();

            // Wait for user before closing
            Console.WriteLine("\nPress Enter to close the application...");
            Console.ReadLine();
        }

        /// <summary>
        /// Appends a new message to the existing transcript with a timestamp.
        /// </summary>
        /// <param name="message">The string to add</param>
        static void AccumulateMessage(string message)
        {
            if (!string.IsNullOrWhiteSpace(message))
            {
                string timestamp = DateTime.Now.ToString("HH:mm:ss");
                transcript.AppendLine($"[{timestamp}] {message}");
            }
        }

        /// <summary>
        /// Outputs the final accumulated string to the console.
        /// </summary>
        static void DisplayTranscript()
        {
            Console.WriteLine("\n Final Accumulated Transcript ");

            string finalResult = transcript.ToString();

            if (string.IsNullOrEmpty(finalResult))
            {
                Console.WriteLine("No messages were recorded.");
            }
            else
            {
                Console.WriteLine(finalResult);
            }
        }
    }
}

