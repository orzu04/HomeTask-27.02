
List<int> numbers = new List<int>{};

Random numb = new Random();
for(int i =1; i<=10;i++)
{

    numbers.Add(numb.Next(2,8));
}
foreach (var item in numbers)
{
    System.Console.Write($"{item} ");
}