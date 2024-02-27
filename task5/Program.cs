

List<int> numbers = new List<int>{ 1, 2, 3, 4, 5 };

Console.WriteLine("The filtered numbers are:");
var number = numbers.FindAll(n => n%2 ==0);

foreach (var item in number)
{
    System.Console.WriteLine(item);
}