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
Lesson9Example();


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