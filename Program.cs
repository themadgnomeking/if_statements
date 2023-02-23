// first test - checking one variable
/*
string name = "Timss";

if (name == "Tims")
{
    Console.WriteLine("Hello Tims");
}
else
{
    Console.WriteLine("Hello Other Person");
}
*/

// second test - checking 2 variables
/*
//string firstName = "Tims";
//string lastName = "Guynes";

//string firstName = "Tims";
//string lastName = "Hughes";

//string firstName = "Rachel";
//string lastName = "Guynes";

string firstName = "Billy";
string lastName = "Bob";

if (firstName == "Tims" && lastName == "Guynes")
{
    Console.WriteLine("Hello Learner");
}
else if (firstName == "Tims")
{
    Console.WriteLine("How did you get the name Tims? Nice to meet another unique individual!");
}
else if (lastName == "Guynes")
{
    Console.WriteLine("OOh, what mispronounciations have you heard that are your favorite?");
}
else
{
    Console.WriteLine("Hello you other person you");
}
*/
// Third test - variable display
string firstName = "Jim";
string lastName = "Guynes";

if (firstName == "Tims" && lastName == "Guynes")
{
    Console.WriteLine("Hello " + firstName + " " + lastName);
}
else
{
    Console.WriteLine("It's nice to meet you " + firstName);
}