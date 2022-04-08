﻿namespace MyFirstApplication;
// This class covers the content for Exercise6

public class Exercise6
{
    /*
    1. Write a constructor for your exercise file that takes 2 parameters. The first 
    parameter should have an int type and a variable name of showSize. The 
    second parameter should have a string type and a variable name of 
    shoeType. Create private class variables for these types and use and 
    underscore when defining them. Inside the constructor associate the class 
    variables with the constructor parameters. 
     */
    private int _showSize;
    private string _shoeType;

    public Exercise6(int size, string type)
    {
        _showSize = size;
        _shoeType = type;
    }

    /*
    2. Write the properties for the class variables defined in exercise 1. Ensure 
    they are labeled as public and are spelled using a capital letter.
     */
    public int ShowSize
    {
        get { return _showSize; }
        set { _showSize = value; }
    }

    public string ShoeType
    {
        get { return _shoeType; }
        set { _shoeType = value; }
    }

    /*
    3. Write a delegate that takes a string parameter. This delegate should be 
    named TryOn. Write a method that takes a string argument and void 
    return type. In the method body include a Console WriteLine statement 
    that will print the message. Test your delegate in Program.cs to ensure 
    everything works properly. Using a mult-line comment on your 
    Exercise6.cs file, provide the information you used to test the delegate
    */
    public delegate void TryOn(string type);
    
    public void TryOnShoe(string message)
    {
        Console.WriteLine(message);
    }

    /*
    This is what I used to test the delegate in program.cs:  
     
    void Exercise6Example()
    {
    Exercise6 myShoes = new Exercise6(8, "Converse");
    Exercise6.TryOn theShoe = myShoes.TryOnShoe;
    theShoe($"I tried on a {myShoes.ShowSize} size shoe that was made by {myShoes.ShoeType}");
    }
     */

} // end class
