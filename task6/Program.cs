
List<bool> values = new List<bool>{ true, true, true };
var val = values.All(e => e==true);
System.Console.WriteLine($"Are all the values in the list true? {val}");
