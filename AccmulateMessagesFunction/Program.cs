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
        //StringBuilder is for better performance when accumulating strings
        static StringBuilder transcript = new StringBuilder();
        static void Main(string[] args)
        {
            string userInput; // varable to hold user input
            bool keepGoing = true; // control variable for the loop

            Console.WriteLine("Welcome to the Message Accumulator");
            Console.WriteLine(value: "Enter a message to save it. Type 'exit' to finish.");

            while (keepGoing) // loop to continuously get user input until they choose to exit
            {
                Console.Write
                    ("Enter message: ");
                userInput = Console.ReadLine();

                // check if the user wants to quit
                if (userInput?.ToLower() == "exit")
                {
                    keepGoing = false;
                }
                else
                {
                    // call the accumulation function
                    AccumulateMessage(userInput);
                    Console.WriteLine("Added to final message.");
                }
            }

            // display the final results
            DisplayTranscript();

            // wait for user before closing
            Console.WriteLine("Press Enter to close the application.");
            Console.ReadLine();
        }

        static void AccumulateMessage(string message)
        {
            if (string.IsNullOrWhiteSpace(message))
            {
                return;
            }

            string timestamp = DateTime.Now.ToString("HH:mm:ss");
            transcript.AppendLine($"[{timestamp}] {message}");
        }


        static void DisplayTranscript() // function to display the final accumulated transcript
        {
            Console.WriteLine("Final Accumulated Transcript");

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

