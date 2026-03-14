//
// ICT2106 Software Design - Timer exercise
//
// A class representing a timer.
//

using System.Threading;

namespace Timer
{
    class Timer : AbstractSubject
    {
        // repeatedly wait one second, exiting after numberOfTicks iterations
        public void Run(int numberOfTicks)
        {
            while (numberOfTicks > 0)
            {
                Thread.Sleep(1000);
                System.Console.WriteLine("Tick");
                Notify();
                numberOfTicks--;
            }

            System.Console.ReadLine();
        }
    }
}
