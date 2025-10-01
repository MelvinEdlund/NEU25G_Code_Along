
////string myString = null;
////string myOtherString = myString?.ToUpper();


//Car myCar = new Car();
//myCar.Engine = new Engine();
//myCar.Engine = null;

////Null conditional ?
////Console.WriteLine(myCar?.Engine?.numberOfCylinders);

//// Null coalescsing operator ?? (Cäljer den vänstra operander om den inte är null, annars den högra)
//Engine myEngine = myCar.Engine ?? new Engine() { numberOfCylinders = 8 };

//Console.WriteLine(myEngine.numberOfCylinders);

//// Arv - "Is A"-relationship

//// Komposition - "Has A"-relationship

//class Car
//{
//    // konstruktor
//    //public Car()
//    //{
//    //    this.Engine = new Engine();
//    //}
//    public string Brand { get; set; }
//    public Engine Engine { get; set; } // = new Engine();
//}

//class Engine
//{
//    public int numberOfCylinders { get; set; } = 6;
//}

