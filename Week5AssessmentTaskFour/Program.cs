// See https://aka.ms/new-console-template for more information

using static System.Console;

// Vars
// Town Names
string[] townNames = new[] {"Sligo", "Dublin", "Cork"};

// For Averages
double[] averages = new double[3];
double totalRainfall = 0;

// 2D Arary
double[,] rainfall = new double[,] { {6.9, 7.1, 7.2}, {6.1, 6.4, 6.3}, {6.5, 6.7, 6.9} };



for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        totalRainfall += rainfall[i, j];
    }

    averages[i] = Math.Round((totalRainfall / 3), 2);
    totalRainfall = 0;
}

for (int i = 0; i < 3; i++)
{
    WriteLine($"Average rainfall for {townNames[i]} is {averages[i]}");
}



/*
for (int i = 0; i < 3; i++)
{
    WriteLine(rainfall[2, i]);
}
*/