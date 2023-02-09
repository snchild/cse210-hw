public class MyClass
{
    public string _name;
    private string _otherName = "My Other Name"; 
    //this attribute is private, so it can only be referenced inside of this file (MyClass.cs)
    public void DisplayName()
    {
        Console.WriteLine(_name);
        Console.WriteLine(_otherName); //notice how this private attribute can be refenced here
    }
}