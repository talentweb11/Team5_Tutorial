Question 3 (Behavioral Design Pattern – Observer)
Download the Timer project from xSITE. The Timer project contains a main program and
the skeletons of two classes, Timer and TextAlarm. Your task is to have the TextAlarm
class print a message every time the Timer ticks, using the Observer pattern. The Timer
class should not need to invoke the TextAlarm class explicitly – it should be designed such
that it could invoke any class that wants to listen.
1. The Run() function in the Timer class repeatedly waits for one second, and exit when the
number of ticks given as input to the function have elapsed. It uses the
System.Threading.Thread.Sleep() function to do the waiting.
2. Implement the Observer pattern (and associated classes) for your Timer project and have
the Timer notify all of the attached observers at the end of each second.
3. Third, complete the TextAlarm class so that it prints its message to the screen every time
it receives an update message. The main function supplied in the project creates two
instances of this class and attaches them to the Timer.
