using RotationExcers;
try
{

Console.WriteLine("Write a list of numbers");
var strNumbers = Console.ReadLine();

Console.WriteLine("Write how many times you want it to turn left:");
var strTimes = Console.ReadLine();
var intTimes = int.Parse(strTimes);

var rotative = new Rotative();

strNumbers.ToList().ForEach(i => {  
    rotative.Add(int.Parse(i.ToString())); 
});

rotative.RotLeft(intTimes);

Console.WriteLine(rotative.PrintElements());

Console.WriteLine();

}
catch
{
    Console.WriteLine("Something went wrong.");
}