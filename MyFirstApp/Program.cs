//  This is a comment to my code

// rakendus küsib kasutajal sisestada oma nime
// rakendus tervitab kasutajat nimepidi


using System;

Console.WriteLine("Enter your name:"); //Output
//string - sõne
string userName = Console.ReadLine(); //Input

Console.WriteLine("Hello" + ", " + userName + "!"); //Output

//string interpolation
Console.WriteLine($"Hello, {userName} !"); //Output