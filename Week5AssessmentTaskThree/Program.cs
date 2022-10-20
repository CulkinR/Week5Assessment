// See https://aka.ms/new-console-template for more information

using static System.Console;

// Vars
string filePath = @"/Users/ronanculkin/Documents/Software Development/Semester Three/Object Oriented Programming/Rider Projects/Week5Assessment/Week5AssessmentTaskThree/IBANs.txt";
string[] ibans = File.ReadAllLines(filePath);

char[] iban = new char[22];
string? bankCode = null;
string? sortCode = null;
string? accNumber = null;


// Example: IE25ULSB 996622 12345678
// Main
for (int i = 0; i < 2; i++)
{
    iban = ibans[i].ToCharArray();
// Bank Code
    for (int j = 0; i < 8; i++)
    {
        bankCode = bankCode + iban[j];
    }
// Sort Code
    for (int j = 8; i < 14; i++)
    {
        sortCode += iban[j];
    }

// Account Number
    for (int j = 14; i < 22; i++)
    {
        accNumber += iban[j];
    }
}

