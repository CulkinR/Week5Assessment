// See https://aka.ms/new-console-template for more information

using Week5AssessmentTaskTwo;
using static System.Console;

// Task 2 - Switch Statement

//Vars
int menuSelect;

// Children 50%, Students 20%, OAPs 10%, Normal Members 0%. Only cater for these 4 options.
double[] discountRates = new double[] {0.50, 0.20, 0.10, 0};
string[] memberOptions = new string[] {"Children", "Students", "OAPS", "Normal" };

// Menu Init
Menu memberSelect = new Menu(memberOptions);

// Main
WriteLine("Our standard membership charge is €50 a month.");
WriteLine("However we do offer discounts for Children, Students and OAPs");
WriteLine("Select which type of member you are");

memberSelect.menu();

Write("> ");
