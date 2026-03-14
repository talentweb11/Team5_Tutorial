Question 3 (Behavioral Design Pattern - Observer)

Run the program with:
`dotnet run --project Timer\Timer.csproj`

This project was updated so the timer now uses the Observer pattern correctly. The
`Timer` class no longer calls a specific alarm directly. Instead, it notifies any attached
listener that implements the observer interface.

Files overview:
- `Program.cs` contains the main program. It creates the timer, creates two `TextAlarm`
  observers, asks the user for the number of ticks, attaches the observers, and starts
  the timer.
- `Timer.cs` contains the `Timer` class. It waits one second for each tick, prints `Tick`,
  and calls `Notify()` so all attached observers are updated.
- `AbstractSubject.cs` contains the base subject class for the Observer pattern. It stores
  observers and provides `Attach()`, `Detach()`, and `Notify()` methods.
- `IObserver.cs` contains the observer interface. Any class that wants to listen to the
  timer must implement `Update()`.
- `TextAlarm.cs` contains a concrete observer. It stores a message and prints that message
  every time the timer notifies it.
- `Timer.csproj` is the project file used by the .NET CLI to build and run the program.
- `Timer.sln` is the Visual Studio solution file for opening the project in the IDE.

How the program works:
1. `Program.cs` creates one `Timer` object and two `TextAlarm` objects.
2. The user enters the number of ticks to run.
3. `Program.cs` attaches both alarms to the timer using `Attach()`.
4. `Timer.Run(numberOfTicks)` starts a loop and waits one second on each iteration.
5. After each second, `Timer` prints `Tick` and calls `Notify()`.
6. `Notify()` in `AbstractSubject` loops through all attached observers and calls
   `Update()` on each one.
7. Each `TextAlarm` receives `Update()` and prints its own message.

1. What changed in the `Run()` function?
The `Run(int numberOfTicks)` method still waits one second in each loop by using
`Thread.Sleep(1000)`. After each second, it now prints `Tick`, notifies all attached
observers, and then reduces the remaining tick count until the loop ends.

Explanation:
This keeps the original timing behavior, but turns each one-second delay into a proper
timer event that other classes can respond to.

2. What was added for the Observer pattern?
An `IObserver` interface was added with an `Update()` method. The observer management
was moved into `AbstractSubject`, which provides:
- an internal `List<IObserver>` to store listeners
- an `Attach(IObserver observer)` method to register listeners
- a `Detach(IObserver observer)` method to remove listeners
- a `Notify()` method to call `Update()` on every attached observer

Explanation:
This makes the timer flexible and loosely coupled. `Timer` inherits the observer
management behavior from `AbstractSubject`, so it does not need to know whether the
observer prints text, makes a sound, or performs some other action.

3. What changed in `TextAlarm` and the main program?
`TextAlarm` was updated to implement `IObserver`, and its `Update()` method now prints
the stored message each time the timer sends a notification. In `Program.cs`, two
`TextAlarm` objects are created with different messages, both are attached by calling
`timer.Attach(alarm1)` and `timer.Attach(alarm2)`, and the program asks the user to enter
the number of ticks before calling `timer.Run(numberOfTicks)`.

Explanation:
This matches the assignment more closely because the number of ticks is now provided as
input, and both observers are `TextAlarm` instances. It also shows that multiple
observers of the same type can listen to the same timer and react on every tick.
