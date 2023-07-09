// See https://aka.ms/new-console-template for more information
using System;
using System.IO;
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

Console.WriteLine(refinedTestCases);

//foreach (string testCase in refinedTestCases)
//{
//    String[] packageDelimiters = { ":", ")1", ")2" };
//}




/////////// 
/// next steps would be to split items into objects, then split those individual items into their weight, cost and index
/// Once complete, we can then do math and implement the constraints