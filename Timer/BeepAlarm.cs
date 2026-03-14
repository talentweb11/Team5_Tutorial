//
// ICT2106 Software Design - Timer exercise
//
// A class that beeps every time it receives a notification.
//

using System;

namespace Timer
{
    class BeepAlarm
    {

        // constructor
        public BeepAlarm()
        {
        }
		
		// to be invoked when the alarm is triggered
		public void Update()
		{
			Console.Beep();
		}
    }
}
