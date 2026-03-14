//
// ICT2106 Software Design - Timer exercise
//
// A class that prints a message to the screen every time it receives a notification.
//

using System;

namespace Timer
{
    class TextAlarm
    {
        // the message to be printed
        private string message;

        // constructor
        public TextAlarm(string messageIn)
        {
            // save the message for later
            message = messageIn;
        }
		
		// to be invoked when the alarm is triggered
		public void Update()
		{
			Console.WriteLine(message);
		}
    }
}
