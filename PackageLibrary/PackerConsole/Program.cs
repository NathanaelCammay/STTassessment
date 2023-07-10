// See https://aka.ms/new-console-template for more information
using System;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using PackageLibrary;

string inputFilePath = @"C:\Users\nathanaelc\Documents\Coding Assessment 06 July\stt_skeleton\resources\example_input.txt"; // add your unique path here

var result = Packer.Pack(inputFilePath);
String[] delimiter = { ">>" };  

string[] testCases = result.Split(delimiter, StringSplitOptions.RemoveEmptyEntries); // group items with their weight limit

string elementToDelete = testCases[4];

List<string> tempList = new List<string>(testCases);
tempList.RemoveAt(tempList.IndexOf(elementToDelete));
var refinedTestCases = tempList.ToArray();  ////// remove unneeded element from array



foreach (string testCase in refinedTestCases)
{
    var standardMaxWeight = 100;
    var maxPackWeight = new Pack(); // create instance of an item
    String[] testCaseDelimiter = { ":", " "};

    var testCaseResult = testCase.Split(testCaseDelimiter, StringSplitOptions.RemoveEmptyEntries);

    maxPackWeight.MaxWeight = Int32.Parse(testCaseResult[0]); // convert string value to integer and set max weight

    for (int i = 1; i < testCaseResult.Length; i++)
    {
        var itemCount = 0;

        var pack = new Pack();
        var itemString = Helper.GetStringBetweenCharacters(testCaseResult[i], '(', ')'); // extract values from brackets
        var itemArray = itemString.Split(','); // add values to an array

        // set pack properties
        pack.Index = Int32.Parse(itemArray[0]);
        pack.Weight = decimal.Parse(itemArray[1]);
        pack.Cost = decimal.Parse(itemArray[2], NumberStyles.Currency);

        // set constraints based on weight and weight + cost
        if (pack.Weight < standardMaxWeight && pack.WeightPlusCost < standardMaxWeight)
        {
            Console.WriteLine("This is a avalid pack!");
        }
        else
        {
            throw new APIException("Constraints not met!");
        }
        itemCount++;
        if (itemCount > 15)
        {
            throw new APIException("Maximum item limit reached!");
        }
    }


}




/////////// 
/// next steps would be to split items into objects, then split those individual items into their weight, cost and index
/// Once complete, we can then do math and implement the constraints