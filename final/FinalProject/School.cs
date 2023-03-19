public abstract class School: Event
{
    //attributes here
    private string _location;
    private List<string> _materialsNeeded = new List<string>();

    public School(List<string> info, string where, List<string> materials) : base(info)//constructor here
    {
        _location = where;
        _materialsNeeded = materials;
    }

    //methods here
    public List<string> GetLocationAndMaterials() //wip
    {
        Console.WriteLine("running GetLocationandMaterials from School");
        List<string> locationAndMaterials = new List<string>();
        return locationAndMaterials;
    }

}