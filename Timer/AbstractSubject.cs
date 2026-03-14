//
// ICT2106 Software Design - Timer exercise
//
// Base class for subjects that notify observers.
//

using System.Collections.Generic;

namespace Timer
{
    abstract class AbstractSubject
    {
        private readonly List<IObserver> observers = new List<IObserver>();

        public void Attach(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            observers.Remove(observer);
        }

        protected void Notify()
        {
            foreach (IObserver observer in observers)
            {
                observer.Update();
            }
        }
    }
}
