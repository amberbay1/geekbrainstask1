string[] usersArray;
Console.WriteLine("Введите массив строк через пробел:");
string input = Console.ReadLine();
usersArray = input.Split(' ');
var arrayLength = new string[usersArray.Length];
var counter = 0;
foreach (var value in usersArray)
{
    if (value.Length <= 3)
    {
        arrayLength[counter] = value;
        counter++;
        Console.Write(value + " ");
    }
}