//
// ICT2106 Software Design - Timer exercise
//
// Main program.
//

namespace Timer
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a clock
            Timer timer = new Timer();

            // create some alarms
            TextAlarm alarm1 = new TextAlarm("First Alarm!");
            TextAlarm alarm2 = new TextAlarm("Second Alarm!");

            System.Console.Write("Enter number of ticks: ");
            string input = System.Console.ReadLine();
            int numberOfTicks;

            if (!int.TryParse(input, out numberOfTicks) || numberOfTicks <= 0)
            {
                System.Console.WriteLine("Invalid input. Using 3 ticks.");
                numberOfTicks = 3;
            }

            // attach the alarms to the clock
            timer.Attach(alarm1);
            timer.Attach(alarm2);

            // run the clock for the requested number of ticks
            timer.Run(numberOfTicks);
        }
    }
}
