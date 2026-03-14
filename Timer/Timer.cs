//
// ICT2106 Software Design - Timer exercise
//
// A class representing a timer.
//

using System.Collections.Generic;
using System.Threading;

namespace Timer
{
    interface IObserver
    {
        void Update();
    }

    class Timer
    {
        private readonly List<IObserver> observers = new List<IObserver>();

        public void Attach(IObserver observer)
        {
            observers.Add(observer);
        }

        private void Notify()
        {
            foreach (IObserver observer in observers)
            {
                observer.Update();
            }
        }

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
