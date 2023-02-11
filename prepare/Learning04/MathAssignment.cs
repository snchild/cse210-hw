public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;
    public MathAssignment(string name, string topic, string txt, string prob) : base(name,topic)
    {
        _textbookSection = txt;
        _problems = prob;
    }
    public List<string> GetHomeworkList()
    {
        List<string> homeworkList = new List<string>{_textbookSection,_problems};
        return homeworkList;
    }

}