public abstract class School: Event
{
    //attributes here
    private string _location;
    private List<string> _materialsNeeded = new List<string>();

    public School(List<string> info, string where, List<string> materials) : base(info)//wip
    {
        _location = where;
        _materialsNeeded = materials;
    }

    //methods here
    public List<string> GetLocationAndMaterials() //wip
    {
        List<string> locationAndMaterials = new List<string>();
        
        locationAndMaterials.Add(_location);
        for(int j=0; j < _materialsNeeded.Count; j++)
        {
            locationAndMaterials.Add(_materialsNeeded[j]);
        }

        return locationAndMaterials;
    }

}