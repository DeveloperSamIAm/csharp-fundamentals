namespace MyFirstApplication;

/* This class contains part of the Exercise 10 Lab - Boat; and Exercise 12 Polymorphism
 Boat2 was used for the class name because Boat was used in Exercise 7*/
internal class Boat2
{
    /*
    2. Create a class based on your Boat object. You will follow the same
    instructions as exercise 1 except for the following.Include your attributes 
    as Expression Body Definition Properties
    */

    public string hullColor;
    public int helmSize;
    public string sailMaterial;

    public string HullColor
    {
        get => hullColor;
        set => hullColor = value;
    }
    public int HelmSize
    {
        get => helmSize;
        set => helmSize = value;
    }
    public string SailMaterial
    {
        get => sailMaterial;
        set => sailMaterial = value;
    }
    
    public Boat2(string hullColor, int helmSize, string sailMaterial)
    {
        this.hullColor = hullColor;
        this.helmSize = helmSize;
        this.sailMaterial = sailMaterial;
    }

    public Boat2(string hullColor, int helmSize)
        : this(hullColor, helmSize, "Linen") { }

    public Boat2()
        : this("Blue", 20) { }


    /*
    Lesson 12 Lab Exercise
    3. In your Boat class, add the virtual keyword to your method created in 
    Lesson 10. Create a second version of the same method and add a 
    parameter. Include a Console WriteLine method in the new method that 
    uses the parameter. This parameter needs to be based on one of your 
    properties.
     */
    public virtual void PropellerForwardBackward()
    {
        Console.WriteLine("The propeller moves forward.");
    }

    public void PropellerForwardBackward(int boatSpeed)
    {
        Console.WriteLine($"The propeller moves at {boatSpeed} miles per hour going foward.");
    }

} // end class
