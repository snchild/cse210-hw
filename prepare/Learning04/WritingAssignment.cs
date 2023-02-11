public class WritingAssignment : Assignment
{
    private string _title;
    
    public WritingAssignment(string name, string topic, string title) : base(name,topic)
    {
        _title = title;
    }
    public List<string> GetWritingInformation()
    {
        List<string> nameAndTopic = GetSummary(); //list of {name,topic}
        List<string> writingInfo = new List<string>{_title,nameAndTopic[0]};
        return writingInfo;
    }

}