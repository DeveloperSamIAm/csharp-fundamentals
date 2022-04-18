namespace MyFirstApplication;

/*
 This class includes Raft inheriting from Boat2 for Lab Exercise 11 and Exercise 12 Polymorphism
 */
internal class Raft : Boat2
{
    /*
    2. Create a child class based on your Boat object. You will follow the same 
    instructions as exercise 1 except for the following. Include 1 child attribute
    as Expression Body Definition Properties
     */

    public int seatNumber;

    public int SeatNumber
    { 
        get => seatNumber; 
        set => seatNumber = value; 
    }

    public Raft(string hullColor, int helmSize, string sailMaterial, int seatNumber)
        : base(hullColor, helmSize, sailMaterial)
    { 
        this.seatNumber = seatNumber;
    }

    public Raft(string hullColor, int helmSize, int seatNumber)
        :this(hullColor, helmSize, "Leaves" , seatNumber) { }

    public Raft()
        :this("Brown", 2, 2) { }

    public void InflateDeflate()
    {
        Console.WriteLine("The raft inflates or deflates.");
    }

    /*
    Lesson 12 Lab Exercise
    4. In your child class of Boat, using the override keyword create a method 
    that has the same name as the virtual method from Boat. Add a Console 
    WriteLine that provides a different message from the Boat
     */

    public override void PropellerForwardBackward()
    {
        Console.WriteLine("The raft\'s propeller moves backward.");
    }

} // end class
