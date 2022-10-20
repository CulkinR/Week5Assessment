// See https://aka.ms/new-console-template for more information

using Week5AssessmentTaskTwo;
using static System.Console;

// Task 2 - Switch Statement

//Vars
int menuSelect;
int standardPrice = 50;
int finalPrice;

// Children 50%, Students 20%, OAPs 10%, Normal Members 0%. Only cater for these 4 options.
double[] discountRates = new double[] {0.50, 0.20, 0.10};
string[] memberOptions = new string[] {"Children", "Students", "OAPs", "Normal" };

// Menu Init
Menu memberSelect = new Menu(memberOptions);

// Main
WriteLine("Our standard membership charge is €50 a month.");
WriteLine("However we do offer discounts for Children, Students and OAPs");
WriteLine("Select which type of member you are");

memberSelect.menu();

Write("> ");
menuSelect = Int32.Parse(ReadLine());

switch (menuSelect)
{
    case 1:
        finalPrice = (int) (standardPrice - (standardPrice * discountRates[menuSelect - 1]));
        WriteLine($"The price for a {memberOptions[menuSelect - 1]} membership is {finalPrice}");
        break;
    case 2:
        finalPrice = (int) (standardPrice - (standardPrice * discountRates[menuSelect - 1]));
        WriteLine($"The price for a {memberOptions[menuSelect - 1]} membership is {finalPrice}");
        break;
    case 3:
        finalPrice = (int) (standardPrice - (standardPrice * discountRates[menuSelect - 1]));
        WriteLine($"The price for a {memberOptions[menuSelect - 1]} membership is {finalPrice}");
        break;
    case 4:
        WriteLine($"The price for a {memberOptions[menuSelect - 1]} membership is {standardPrice}");
        break;
    default:
        WriteLine("Invalid Entry - Exiting");
        break;
}