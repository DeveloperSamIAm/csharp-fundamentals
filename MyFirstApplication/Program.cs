using MyFirstApplication;

// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// The below statement calls a local function
// single line comment
// HouseExample();

// MyLocalFunction();
// Lesson Examples
// Lesson1Example();
// Exercise1Example();
// Lesson2Example();
// Exercise2Example();
// Lesson3Example();
// Exercise3Example();
// Lesson4Example();
// Exercise4Example();
// Lesson5Example();
// Exercise5Example();
// Lesson6Examples();
// Exercise6Example();
// Lesson7Example();
// Exercise7Example();
// Lesson8Example();
// Exercise8Example();
// BadgerBadger();
// Lesson9Example();
// Lesson10Example();
// HouseUpdated();
// Exercise10Example();
// Lesson11Example();
// Exercise11Example();
// Lesson12Example();
// CondoExample();
// Exercise12Example();
// Lesson13Example();
// Exercise13Example();
// Lesson14Example();
// Exercise14Example();
// Lesson15Example();
// Exercise15Example();
// Lesson16Example();
// Exercise16Example();
Lesson17Example();






// Lesson 17
void Lesson17Example()
{
    Lesson17 myLesson17 = new Lesson17();
    House testHouse = null;
    // myLesson17.MyThrowExample(testHouse);
    // myLesson17.MyExceptionExample(testHouse);
    myLesson17.MyArrayException();
}


// Lesson 16 Lab Exercise
void Exercise16Example()
{
    Exercise16 myExercise16 = new Exercise16();
    myExercise16.HorseList();
    myExercise16.MovieDictionary();
}


// Lesson 16
void Lesson16Example()
{
    Lesson16 myLesson16 = new Lesson16();
    myLesson16.MyListExample();
    myLesson16.MyDictionaryExample();
}


// Lesson 15 Lab Exercise
void Exercise15Example()
{
    Exercise15 myExercise15 = new Exercise15();
    string favorite = myExercise15.BestMovies(FavoriteMovies.The_Grand_Budapest_Hotel);
    Console.WriteLine(favorite);
    (int value, string movie) = myExercise15.GreatestMovies(FavoriteMovies.The_Grand_Budapest_Hotel);
    Console.WriteLine($"{movie} is number {value} on my enum list.");
}


// Lesson 15
void Lesson15Example()
{
    Lesson15 myLesson15 = new Lesson15();
    myLesson15.EnumExample();
    string flavor = myLesson15.FavoriteIceCream(IceCreamFlavors.Chocolate);
    Console.WriteLine(flavor);
    myLesson15.TupleExample();
    (int val1, int val2, int val3) = myLesson15.TupleReturnExample(11, 35);
    Console.WriteLine($"Answers are {val1} {val2} {val3}");

}


// Lesson 14 Lab Exercise
void Exercise14Example()
{
    Exercise14 myExercise14 = new Exercise14();
    myExercise14.IceCreamFlavors();
    myExercise14.RegularScores();
}


// Lesson 14
void Lesson14Example()
{
    Lesson14 myLesson14 = new Lesson14();
    myLesson14.SingleIntArray();
    myLesson14.SingleHouseArray();
    myLesson14.MultiIntArray();
    myLesson14.MultiStringArray();
    myLesson14.JaggedArraySample();
}


// Lesson 13 Lab Exercise
void Exercise13Example()
{
    Pelican myPelican = new Pelican(15);
    Console.WriteLine(myPelican.Speed);
    myPelican.EatFish();
    myPelican.FlyAway();
}


// Lesson 13
void Lesson13Example()
{
    Lesson13Derived myLesson13 = new Lesson13Derived(3);
    int total1 = myLesson13.ConvertFeetToInches();
    int total2 = myLesson13.ConvertYardsToFeet();
    
    Console.WriteLine($"Converting feet to inches {total1}");
    Console.WriteLine($"Converting yards to feet {total2}");

    // These are from the interface
    int total3 = myLesson13.ConvertMilesToYards();
    Console.WriteLine($"Converting miles to yards {total3}");
}


// Lesson 12 Lab Exercise
void Exercise12Example()
{
    Horse myHorse = new Horse();
    Zebra myZebra = new Zebra();
    Boat2 myBoat = new Boat2();
    Raft myRaft = new Raft();
    myHorse.Neigh("large");
    myZebra.Neigh();
    myBoat.PropellerForwardBackward(25);
    myRaft.PropellerForwardBackward();
}


void CondoExample()
{
    Condo myCondo = new Condo();
    myCondo.Maintenance();
    myCondo.DoorOpenClose();
    Console.WriteLine(myCondo.RoofType);
}


// Lesson 12
void Lesson12Example()
{
    Fruit myFruit = new Fruit();
    myFruit.EatFruit();
    myFruit.EatFruit(3);

    Apple myApple = new Apple();
    myApple.EatFruit();
}



// Lesson 11 Lab Exercise
void Exercise11Example()
{
    Zebra myZebra = new Zebra();
    Console.WriteLine(myZebra.CoatColor);
    Console.WriteLine(myZebra.ShoeSize);
    Console.WriteLine(myZebra.SaddleMaterial);
    Console.WriteLine(myZebra.Stripes);
    myZebra.Bray();

    Raft myRaft = new Raft();
    Console.WriteLine(myRaft.hullColor);
    Console.WriteLine(myRaft.helmSize);
    Console.WriteLine(myRaft.sailMaterial);
    Console.WriteLine(myRaft.seatNumber);
    myRaft.InflateDeflate();

}


// Lesson 11
void Lesson11Example()
{
    Square square = new Square();
    double total = square.CalculateInteriorAngle();
    Console.WriteLine(total);

    Triangle triangle = new Triangle();
    double total2 = triangle.CalculateInteriorAngle();
    Console.WriteLine(total2);

}



// Lesson 10 Lab Exercise
void Exercise10Example()
{
    Horse myHorse = new Horse();
    Console.WriteLine(myHorse.CoatColor);
    Console.WriteLine(myHorse.ShoeSize);
    Console.WriteLine(myHorse.SaddleMaterial);
    myHorse.Neigh();

    Boat2 myBoat2 = new Boat2();
    Console.WriteLine(myBoat2.HullColor);
    Console.WriteLine(myBoat2.HelmSize);
    Console.WriteLine(myBoat2.SailMaterial);
}


void HouseUpdated()
{
    // Calling Default
    House myHouse = new House();
    Console.WriteLine(myHouse.RoofType);
    myHouse.DoorOpenClose();

    // Calling Constructor with 2 parameters
    House mySecond = new House("straw", "bamboo");
    Console.WriteLine(mySecond.WindowSize);
    mySecond.DoorOpenClose();

    // Calling Constructor with 4 parameters
    House myThird = new House("dirt", "plastic", "green", 40);
    Console.WriteLine(myThird.Foundation);
    myThird.DoorOpenClose();
}


// Lesson 10
void Lesson10Example()
{
    Lesson10 myLesson10 = new Lesson10();
    // Using this to call another constructor
    Console.WriteLine(myLesson10.FirstName);

    // Normal property
    myLesson10.FirstName = "Paul";
    Console.WriteLine(myLesson10.FirstName);

    // Calling Auto Property
    // myLesson10.LastName = "Smith"; // only works in Lesson 10 constructor
    Console.WriteLine(myLesson10.Id); // default value
    myLesson10.Id = 1500;
    Console.WriteLine(myLesson10.Id); // get 1500

    // Expression Body Property
    myLesson10.Address = "123 Main St.";
    Console.WriteLine(myLesson10.Address);

    // Second constructor 
    Lesson10 myOther10 = new Lesson10("Ben", "Franklin", 64119);
    Console.WriteLine(myOther10.Zipcode);
}


// Lesson 9
void Lesson9Example()
{
    Lesson9 myLesson9 = new Lesson9();
    Lesson9.Nested nested = new Lesson9.Nested(myLesson9);

    // Access Modifiers
    myLesson9.SampleInternal();
    myLesson9.SampleProtectedInternal();
}


/* This is a program that will run a song */
void BadgerBadger()
{
    BadgerMushroomSong mySong = new BadgerMushroomSong();
    mySong.BadgerSong();
}


// Lesson 8 Lab Exercise
void Exercise8Example()
{
    Exercise8 myExercise8 = new Exercise8();
    myExercise8.FeetToInches(3);

    Exercise8.CalcLengthWidth(2, 3);
}


// Lesson 8 
void Lesson8Example()
{
    Lesson8 myLesson8 = new Lesson8(3);
    // Calling constant directly
    Console.WriteLine(Lesson8.DaysPerMonth);

    // Calculate temperature
    Console.WriteLine(Lesson8Static.CelsiusToFahrenheit(45.6));

    // Static Methods
    Lesson8.DayCount = 10;
    myLesson8.CalculateHours();
    Lesson8.CalculateDayCount();
    Console.WriteLine($"The calculation has been done {Lesson8.DayCount} times.");

    // Static Lambda
    myLesson8.CalculateHoursV2();
}

// Lesson 7 Lab Exercise
void Exercise7Example()
{
    Employee myEmployee = new Employee(3, "Sami");
    Console.WriteLine(myEmployee);
    Console.WriteLine(myEmployee.Id);
    Console.WriteLine(myEmployee.Name);

    Boat myBoat = new Boat("forward");
    Console.WriteLine(myBoat);
    Console.WriteLine(myBoat.direction);
}

// Lesson 7
void Lesson7Example()
{
    Location myLocation = new Location(34.5, 47.8);
    Console.WriteLine(myLocation.Latitude);
    Console.WriteLine(myLocation);

    // Readonly Struct
    Student myStudent = new Student(10, "Roger");
    Console.WriteLine(myStudent);
    Console.WriteLine(myStudent.StudentName);

    // Record
    Person person = new Person("Nancy", "Drew");
    Console.WriteLine(person);
    Console.WriteLine(person.lastName);

    // Struct Record
    Resolution res = new Resolution(1920, 1080);
    res.CalculateRes();
    Console.WriteLine(res);
}


// Lesson 6 Lab Exercise
void Exercise6Example()
{
    Exercise6 myShoes = new Exercise6(8, "Converse");
    Exercise6.TryOn theShoe = myShoes.TryOnShoe;
    theShoe($"I tried on a {myShoes.ShowSize} size shoe that was made by {myShoes.ShoeType}");
}


// Bottles of Beer Song
BottlesOfBeer bottles = new BottlesOfBeer();
// bottles.LetsSing();


// Lesson 6 
void Lesson6Examples()
{
    // default constructor
    Lesson6 myLesson6 = new Lesson6();
    Lesson6 myLessonHats = new Lesson6("Cowboy", 7);
    Lesson6.TryOn theHat = myLessonHats.TryOnHat;
    theHat($"I tried on a {myLessonHats.HatType} hat that was size {myLessonHats.HatSize}");

    Console.WriteLine();

    // Constructor with 1 parameter
    Lesson6 myOther6 = new Lesson6(22);

    // Constructor with 2 parameters
    Lesson6 myHats = new Lesson6("Cowboy", 7);
    Console.WriteLine(myHats.HatSize); // getting value
    myHats.HatSize = 6; // setting value

    // Method Parameter Modifiers
    int able = 33, beta = 22, charlie;
    myLesson6.InExample(able);
    myLesson6.RefExample(ref beta);
    Console.WriteLine(beta);
    myLesson6.OutExample(out charlie);
    Console.WriteLine(charlie);

    Console.WriteLine();

    // Multi-cast Delegate
    Lesson6.TryOn theNewHat, hangTheHat, multiHat;

    theNewHat = myLesson6.TryOnHat;
    hangTheHat = myLesson6.HangUpHat;
    multiHat = theNewHat + hangTheHat;

    theNewHat($"Trying a {myLessonHats.HatType} hat");
    hangTheHat($"Hanging up my {myLessonHats.HatType} hat");
    multiHat($"My {myLessonHats.HatType} hat");

}


// Lesson 5 Lab Exercise
void Exercise5Example()
{
    Exercise5 myExercise5 = new Exercise5();
    Console.WriteLine(myExercise5.Exercise5Method1(23, 23));
    Console.WriteLine(myExercise5.Exercise5Method2('v'));
    myExercise5.Exercise5Method3(32);
}


// Lesson 5 Expressions & Pattern Matching
void Lesson5Example()
{
    Lesson5 myLesson5 = new Lesson5();

    // Call method of myLesson5
    myLesson5.IsOperatorExample(34);

    Lesson5.Del handler = myLesson5.DelegateMethod;
    handler("Hello CSharp");

    // Func delegate
    Func<int, int> add = myLesson5.Sum;
    Console.WriteLine($"Func example = {add(23)}");

    // Lambda Expression
    myLesson5.LambdaSquare();
    myLesson5.LambdaGreeting();

    // Switch Expressions
    string value1 = myLesson5.BasicSwitch("red");
    Console.WriteLine(value1);
    string value2 = myLesson5.FavoriteColor("green");
    Console.WriteLine(value2);

    // Relational Pattern
    myLesson5.DrinkSize(33);

    // Logical Patterns
    myLesson5.TemperatureGuide(48.6);
    myLesson5.NumberChoice(3);
}



// Lesson 4 Lab Exercise
void Exercise4Example()
{
    Exercise4 myExercise4 = new Exercise4();
    myExercise4.Exercise4Method1("cupcake", "poptarts");
    Console.WriteLine(myExercise4.Exercise4Method2('Z'));
    myExercise4.Exercise4Method3();
}



// Lesson 4 Control FLow
void Lesson4Example()
{
    Lesson4 myLesson4 = new Lesson4();
    // myLesson4.BasicIfStatement(11);
    // myLesson4.BasicIfElseStatement(12);
    // myLesson4.BasicIfElseChainStatement(5);
    // myLesson4.BasicAndOrCondition(20, 20);
    // Console.WriteLine(myLesson4.BasicTernaryExample(35));
    // myLesson4.BasicSwitchStatement(3);
    myLesson4.BasicWhileStatement();
    // myLesson4.BasicDoStatement();
    // myLesson4.BasicForStatement();
    // myLesson4.BasicForeachStatement();
    // myLesson4.BasicJumpStatement();
}


// Lesson 3 Lab Exercise
void Exercise3Example()
{
    Exercise3 myExercise3 = new Exercise3();
    Console.WriteLine(myExercise3.Exercise3Method1(2));
    myExercise3.Exercise3Method2();
    myExercise3.Exercise3Method3(10, 100);
    myExercise3.Exercise3Method4(false, true);
}



// Lesson 3 Operators and Overflow Checking
void Lesson3Example()
{
    Lesson3 myLesson3 = new Lesson3();
    myLesson3.BasicCheckedOperator(14);
    myLesson3.BasicCheckedExample2();
    int alpha = 2147483647;
    int total = alpha + 10;
    Console.WriteLine(total);
    // -2147483639
    myLesson3.BasicUncheckedExample();
    myLesson3.BasicMath();
    myLesson3.BasicModulus(783);
    myLesson3.BasicBooleanLogical(true, false);
    myLesson3.BasicCompoundExample(12, 35, 9);
    myLesson3.BasicRelationalExample("Tom", "Tim");
    myLesson3.MyIncDecrExample();
}


// Lesson 2 Lab Exercise
void Exercise2Example()
{
    Exercise2 myExercise2 = new Exercise2();
    myExercise2.Exercise2Method1(" EXERCISE two Lab");
    myExercise2.Exercise2Method2();
    myExercise2.Exercise2Method3();
    Console.WriteLine(myExercise2.Exercise2Method4());
}



// Lesson 2 Strings
void Lesson2Example()
{
    Lesson2 myLesson2 = new Lesson2();
    myLesson2.MyTrimExample();
    int able = myLesson2.MyStringLength();
    Console.WriteLine(able);
    myLesson2.MyEqualsExample("Hello World");
    myLesson2.MyExampleChar();
    Console.WriteLine(myLesson2.MyEscapeExample());
    myLesson2.MyJoinedStrings("CSharp", "Rules");
    Console.WriteLine(myLesson2.MyInterpolationExample("sushi", 3));
    myLesson2.MyOtherInterpolation();
}


// Lesson 1 Lab Exercise
void Exercise1Example()
{
    Exercise1 myExercise = new Exercise1();
    myExercise.Exercise1Method1();
    myExercise.Exercise1Method2(36, 3600, 3600000);
    myExercise.Exercise1Method3(42.2D, 45.0F, -8000L);
    myExercise.Exercise1Method4();
}


// Lesson 1 Value Types
void Lesson1Example()
{
    Lesson1 myLesson = new Lesson1();
    myLesson.IntMinMax();
    myLesson.IntegralExample();
    myLesson.ConvertFloatToInt();
    myLesson.LongFromInt();
}

/*
 This local function is for my first exercise lab.
 */
void MyLocalFunction()
{
    Console.WriteLine("This is my first sentence");
    Console.WriteLine("I am new to CSharp");
    Console.WriteLine("This CSharp course is cool");
    Console.WriteLine("I am learning stuff everyday.");
}

/*
 Multi-line comment
The below statement is a local function. Local functions are
inside members and are private by default. This means
they are specific to that member and can only be called
inside that member.
 */
void HouseExample()
{
    House myHouse = new House();
    myHouse.DoorOpenClose();
}