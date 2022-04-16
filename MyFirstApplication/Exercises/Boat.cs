namespace MyFirstApplication;

/* This class contains part of the Exercise 10 Lab - Boat
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


} // end class
