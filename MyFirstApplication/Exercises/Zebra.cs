namespace MyFirstApplication;

/*
 This class includes Zebra inheriting from Horse for Lab Exercise 11
 */
internal class Zebra : Horse
{
    /*
     Create a child class based on your Horse object. Include one child attribute
    as an auto property. Create 3 constructors. The first constructor should 
    have 5 parameters with 4 of them from Horse and your child property. 
    Using the keyword :base() ,you will put the four horse parameters in the
    parenthesis. In the body of the constructor you will assign your child
    parameter to your property. 
    The second constructor should have 3 parameters, 2 based on the horse 
    and 1 from your child. Using the :this() keyword , you will pass 2 of the 
    parent attributes and your child attribute information to the first 
    constructor. Include default values to represent the 2 remaining horse 
    parameters.
    For the last constructor, you will create the default constructor. Using the 
    :this() keyword, you will pass 3 default values in that will pass to the 2nd
    constructor. Also include in the class, your method for your child class
     */
    public int Stripes { get; set; }

    public Zebra(string coatColor, int shoeSize, string saddleMaterial, int stripes)
        : base(coatColor, shoeSize, saddleMaterial)
    {
        Stripes = stripes;
    }

    public Zebra(string coatColor, int shoeSize, int stripes)
        :this(coatColor, shoeSize, "none", stripes) { }

    public Zebra()
        : this("Black & White", 6, 43) { }

    public void Bray()
    {
        Console.WriteLine("The zebra makes a bray sound.");
    }


} // end class
