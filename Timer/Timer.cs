//
// ICT2106 Software Design - Timer exercise
//
// A class representing a timer.
//
namespace Timer
{
    class Timer
    {
        // repeatedly wait one second, exiting after numberOfTicks iterations
        public void Run(int numberOfTicks)
        {
            while (numberOfTicks > 0)
            {
                System.Threading.Thread.Sleep(1000);
                System.Console.WriteLine("Sleeping...");
                numberOfTicks--;
            }
            System.Console.ReadLine();
        }
    }
}
