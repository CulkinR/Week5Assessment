// See https://aka.ms/new-console-template for more information

using static System.Console;

// Vars
string filePath = @"/Users/ronanculkin/Documents/Software Development/Semester Three/Object Oriented Programming/Rider Projects/Week5Assessment/Week5AssessmentTaskThree/IBANs.txt";
string[] ibans = File.ReadAllLines(filePath);

char[] iban = new char[22];
string? bankCode;
string? sortCode;
string? accNumber;


// Example: IE25ULSB 996622 12345678
// Main
for (int i = 0; i < 3; i++)
{
    // Set vars to null for each run
    bankCode = null;
    sortCode = null;
    accNumber = null;
    
    
    iban = ibans[i].ToCharArray();
// Bank Code
    for (int j = 0; j < 8; j++)
    {
        bankCode = bankCode + iban[j];
    }
// Sort Code
    for (int j = 8; j < 14; j++)
    {
        sortCode += iban[j];
    }

// Account Number
    for (int j = 14; j < 22; j++)
    {
        accNumber += iban[j];
    }

    WriteLine($"Account: {i + 1}");
    WriteLine($"Bank Code: {bankCode}");
    WriteLine($"Sort Code: {sortCode}");
    WriteLine($"Account Number: {accNumber}");
    WriteLine("============================");
}

