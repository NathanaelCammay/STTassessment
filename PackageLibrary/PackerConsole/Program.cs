// See https://aka.ms/new-console-template for more information
using System;
using System.IO;
using System.Text;
using PackageLibrary;


string inputFilePath = @"C:\Users\nathanaelc\Documents\Coding Assessment 06 July\stt_skeleton\resources\example_input.txt"; // add your unique path here

var result = Packer.Pack(inputFilePath);
String[] delimiters = { ")0", ")1", ")2", ")3", ")4", ")5", ")6", ")7", ")8", ")9" };  

string[] packages = result.Split(delimiters, StringSplitOptions.None); // group items with their weight limit

foreach (string package in packages)
{
    String[] packageDelimiters = { ":", ")1", ")2" };
}