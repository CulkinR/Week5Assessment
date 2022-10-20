// See https://aka.ms/new-console-template for more information

using static System.Console;

// Task 1 - Temperature Reading

// Vars
int temperature;

// Main
WriteLine("Enter the temperature to test normal range (18-25)");
Write("> ");
temperature = Int32.Parse(ReadLine());

if (temperature >= 18 && temperature <= 22)
{
    WriteLine("Temperature is inside the normal range of 18-25 Degrees");
}
else
{
    WriteLine("Temperature is outside the normal range of 18-25 Degrees");
}