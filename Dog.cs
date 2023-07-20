public class Dog
{
    string _name;
    string _owner;

    public string Name { get; set; }
    public string Owner { get; set; }   

    public Dog(string name)
    {
        Name = name;
    }
}