
Person myPerson = new("Mel");
Console.WriteLine(myPerson.Name);

myPerson.Name = "Seb";
Console.WriteLine(myPerson.Name);
//Console.WriteLine(myPerson.name);
//myPerson.name = "Melvin Edlund"; // fungerar inte om myPerson.name är private
//Console.WriteLine(myPerson.GetName());

//myPerson.SetName("Melvin");
//Console.WriteLine(myPerson.name);

//myPerson.Name = "Sebbe";
//Console.WriteLine(myPerson.Name);

class Person
{
    private string name = string.Empty;
    
    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            if (value.Length > 10)
            {
                throw new ArgumentException();
            }
            this.name = value;
        }
    }

    public Person(string name)
    {
        this.name = name;
    }
    
    public string GetName()
    {
        return this.name;
    }
    public void SetName(string newName)
    {
        if (newName.Length>10)
        {
            throw new ArgumentException();
        }
        this.name = newName;

    }
}

