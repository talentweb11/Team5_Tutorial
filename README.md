Question 3 (Behavioral Design Pattern - Observer)

Run the program with:
`dotnet run --project Timer\Timer.csproj`

This project was updated so the timer now uses the Observer pattern correctly. The
`Timer` class no longer calls a specific alarm directly. Instead, it notifies any attached
listener that implements the observer interface.

1. What changed in the `Run()` function?
The `Run(int numberOfTicks)` method still waits one second in each loop by using
`Thread.Sleep(1000)`. After each second, it now prints `Tick`, notifies all attached
observers, and then reduces the remaining tick count until the loop ends.

Explanation:
This keeps the original timing behavior, but turns each one-second delay into a proper
timer event that other classes can respond to.

2. What was added for the Observer pattern?
An `IObserver` interface was added with an `Update()` method. The `Timer` class was
updated with:
- a `List<IObserver>` to store listeners
- an `Attach(IObserver observer)` method to register listeners
- a `Notify()` method to call `Update()` on every attached observer

Explanation:
This makes the timer flexible and loosely coupled. `Timer` does not need to know whether
the observer prints text, makes a sound, or performs some other action.

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
