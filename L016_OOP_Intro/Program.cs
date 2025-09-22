
Cat myCat = new Cat() { name = "Pelle", age = 2 };
Cat myOtherCat = new Cat() { name = "Måns", age = 5 };

myCat.Greet();
myOtherCat.Greet(myCat);

myCat.Greet(myOtherCat);
myOtherCat.Greet("Sebbi");
// Console.WriteLine($"myCat.GetDoubleAge() -> {myCat.GetDoubleAge()}"); - funkar inte om method är private
Console.WriteLine(Cat.numberOfLives);


class Cat
{
    public string name = "default name";
    public int age = 5;
    public static int numberOfLives = 9;

    public void Greet()
    {
        Console.WriteLine($"Hej, jag heter {name} och jag är {age} år gammal.");
    }

    public void Greet(string name)
    {
        Console.WriteLine($"Hej {name}, jag heter {this.name}");
    }

    public void Greet(Cat otherCat)
    {
        Console.WriteLine($"Hej {otherCat.name}, jag heter {this.name} och min dubbla ålder är {this.GetDoubleAge()} år gammal.");
    }

    private int GetDoubleAge()
    {
        return age * 2;
    }
}























//Cat myCat = new Cat() { name = "Pelle" };
//Cat myOtherCat = new Cat() { name = "Måns" };
//Cat myThirdCat = new Cat() { name = "Bill", age = 2};
//Cat myFourthCat = new Cat() { name = "Bull", age = 2};

//Cat[] cats = new Cat[] { myCat, myOtherCat, myThirdCat, myFourthCat, new Cat() { name = "Maja"} };

//Cat[] cats = new Cat[] {
//    new Cat() {name = "Pelle", age = 4 },
//    new Cat() {name = "Måns", age = 5 },
//    new Cat() {name = "Bill", age = 2 },
//    new Cat() {name = "Bull", age = 2 },
//    new Cat() {name = "Maja"},
//};

//cats[2].name = "Emsis";

//foreach (var cat in cats)
//{
//    Console.WriteLine($"{cat.name} är {cat.age} år gammal.");
//}