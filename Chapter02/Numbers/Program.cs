using System.Xml;

// good use of var because it avoids the repeated type
// as shown in the more verbose second statement
var xml1 = new XmlDocument();
XmlDocument xml2 = new XmlDocument();

// bad use of var because we cannot tell the type, so we
// should use a specific type declaration as shown in
// the second statement
var file1 = File.CreateText("something1.txt");
StreamWriter file2 = File.CreateText("something2.txt");

XmlDocument xml3 = new();

Console.WriteLine($"$default(int) = {default(int)}");
Console.WriteLine($"$default(bool) = {default(bool)}");
Console.WriteLine($"$default(DateTime) = {default(DateTime)}");
Console.WriteLine($"$default(string) = {default(string)}");

int number = 13;
Console.WriteLine($"number has been set to: {number}");
number = default;
Console.WriteLine($"number has been set to: {number}");


