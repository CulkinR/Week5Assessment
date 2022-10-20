// See https://aka.ms/new-console-template for more information

using static System.Console;
using Week5AssessmentTaskSix;

ElectricBike bikeOne = new ElectricBike("EB1", "Ash Lane", 50);
ElectricBike bikeTwo = new ElectricBike("EB2", "Strandhill", 10);


WriteLine("Bike One Details");
bikeOne.PrintDetails();
WriteLine("Bike Two Details");
bikeTwo.PrintDetails();