using System;

namespace Nov18Live
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The human!");
            Console.Write("torch!");
            Console.WriteLine("was denied!");
            Console.Write("a!");
            Console.Write("bankloan!");

            Console.WriteLine(value: "Please enter a number: ");
            int userNumber = int.Parse(s: Console.ReadLine());
            Console.WriteLine(value: $"You entered the number: {userNumber}");

            //reading it 
            //have to wrap it in an int.Parse.  it's a string by default, so readline retuns a string every time
            //so you have to parse everytime to get and integer
            //the int on line whatever is what you are parsing.  int32 or integer class.  lives as double
            // and some types have it and some don't maybe not that double
            //ch. 7

        }
    }
}

//dealing with control flow, we have conditionals, which they will ask a question, then do different
//things depending on response.  if statement creates branches in our control flow
//loops and iteration, do the same thing over and over again
//different loops, for loops, iteration over something a certain number of times
//for each is good for lists
//while loop will continue until condition is false

//FIZZ BUZZ PROBLEM -- USED TO be a popular entry level question for algorithms
//prints a number of integres from 100 but print fiz if it's divisible by three, buzz if by five, fizzbuzz if by both
//use the remainder operator

//it divides two numbers and give the remainder after that






// private static int Remainder(int first, int second)
// {
//     return first
// }



static void Example(string[] args)
{
    for (int 1 - 0; int < 100; int++)
        if (int % 3 == 0 && int % == 0)
        {
            Console.WriteLine(value: "FizzBuzz");

        }

        else if (int % 5 == 0)
        {
            Console.WriteLine(value: "Fizz");

        }

        else if (int % 3 == 0)
        {
            Console.WriteLine("Buzz");

        }
        else
            Console.WriteLine(value: i)
}







//while loop

int myVal - 0;

while (myVal < 100)
{
    myVal++l =;

    if (myVal % 3 == 0 && myVal % == 0)
    {
        Console.WriteLine(value: "FizzBuzz");

    }

    else if (myVal % 5 == 0)
    {
        Console.WriteLine(value: "Fizz");

    }

    else if (myVal % 3 == 0)
    {
        Console.WriteLine("Buzz");

    }
    else
        Console.WriteLine(value: myVal)
}



//list of strings maybe

List<string> names = new List<string>()
{
    "first",
    "second",
    "third",
    "fourth"
};

foreach (var string item in name)
Console.WriteLine(value ??????? fuck man)

//access modifies -- public access modifier lets you access that from anywhere in the program.  private -- only lets you access that from your class
//static is it makes it so you don't have to declare an instance of that class but stay on that class. static just meants that you cants declare a new instance of it
//static is different from public and private, which are their own thing.

//strongly typed variables.  javascript is loosely typed.  variables can change type.  can assign a variable an integer.
//in C# it can only be passed data of that type or data that can directly convert to that type
// we can create custom types.  we create a class first to do this.  
// prop and then hit tab, then hit tab, then hit tab

public class Dog
{
    public string Breed { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public bool HasShots { get; set; }
}

// in languages like csharp and java, we call methods instead of functions.  classes serve a number of different functions really but one of them is that 
//it is a place to organize your code and every program you run needs and entry point yeah
//so with any of your frontend shit you build how did you browser know 
//the script that kicked off all of your code was that html shit 
//so every program needs an entry point and the way you indicate that is to create a method called main in a class called program.
//starting with .net five, a new feature was added that allowed you to have one file and the runtime would know it is the entry point which is why if you have two files named top level statements you'll get a compiler error saying only one entrypoint allowed
//allows developers to write script like programs where they didn't have to have boilder plate and could jsut write code that would be executed from top to bottom
//likely hood you'll be using the syntax without class, won't see that in the wild, our programs will be organized
//the program class in this instance has a special funciton ast the entry point ot our programe
//in a standard csharp program you won't have shit outside of classes.  any function yo're gonna run be a class
//classes also -- a way for us to define custom types
//it's a blueprint to create an object with specific properties
//there's lots of type safety.  so if you have an array of dog objects in javascript, there's no way to ensure you have all the right properties
//you can always bank on these properties being there.  and thats what the type system is doing it 
//type system here dog, it ensures that every new dog will have these properties EVEN if you don't provide a value
//default for string, bool, int is filled\
//we're gonna make classes called managers and their job is to manage the UI 
//classes do alot of different things
//it's alot but for now just try to work with classes like this
//think about it as a place to store data, but they are strongly typed, so you are limited to what properties you can add to that object
//if you want to make a new object, you need to make a new thing i think i dont know

//default for string is empty string, int is 0, bool is false

// so an object right if you think about a Ford, a toyota sienna.  i can create a toyota sienna class, but it would't represent HIS toyota sienna
//so he uses a keyword to give him his specfiic instance of toyota sienna, so you say newToyo


//so to create a new instance of dog 

Dog rusty = new Dog() //use parenthesis to initialize it
// --object initiatization syntax
{
    Breed = "Mutt",
    Name = "Rusty"
}

Console.WriteLine(value: rusty.Name)

//now we have a new instance of a dog
//getting it via input from the user, you can create a new instance and then define it as you get the info
//otherwise object initiance syntax 

// 

Dog rusty - new Dog();
rusty.Name = "Rusty";

Console.WriteLine(value: rusty.Name);

// reason for get and set -- get lets us get the breed property, it gives us the ability to set it
//so if you remove the set, we can't set the breed property

//convention is that each class has it's own file, typically.  so like here we have the program class
//so the convention is that we would have a Dog.cs file, and we would define it in there
// program can see into dog because it is intthe same namespace 

//different sizes of floating point nubmers in csharp.  there's a trade off with the size of range
//you can store or how precise.  tradeoff between precision and level to store -- what you need to kow
//if you can work with whole numbers, it's always better
//computers do math weird.  use decimal type for money.  use double wider range of values, less precision
//decimal is the type, it's called decimal
//along with is an integral type that has a much wider value range that regular integer will store
//short as well yea which is smaller
//three interval type at least
//float is um uh is um uh is the same is as uh a the word is escaping me right now -- a single, float is a friendly name as the asingle class
//capstones -- using money, use the decimal type