// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

/*Random dice = new Random();
int roll = dice.Next(1, 7);
Console.WriteLine(roll);


Random dice = new Random();
int roll = dice.Next();
Console.WriteLine(roll);


//return value 
Random dice = new Random();
Console.WriteLine(dice.Next(1, 7));


//Method parameters and arguments in the calling statement
Random dice = new Random();
int roll = dice.Next(1, 7);
Console.WriteLine(roll);


//method over loading
int number = 7;
string text = "seven";

Console.WriteLine(number);
Console.WriteLine();
Console.WriteLine(text);
*/

//method overloading
Random dice = new Random();
int roll1 = dice.Next();
int roll2 = dice.Next(101);
int roll3 = dice.Next(50, 101);

Console.WriteLine($"First roll: {roll1}");
Console.WriteLine($"Second roll: {roll2}");
Console.WriteLine($"Third roll: {roll3}");