public class Entry
{
    public List<string> _promptsList = new List<string>(){"What is your \"high\" of the day?","What is your \"low\" of the day?","What was something crazy that happened today?","What was the funniest part of your day?","What were your goals? Did you achieve them?"};
    //public int _listLength = 5;
    public string _prompt = "";
    public string _response = "";
    public string _date = "";
    public string _phoneTime = "";
    public Random rnd = new Random();
    public void DisplayPrompt()
    {
        ChoosePropmt();
        //display the prompt
        Console.WriteLine($"\n{_prompt}");
    }
    public void ChoosePropmt()
    {
        //generates a random number
        int i = rnd.Next(_promptsList.Count);
        //chooses prompt based on the random number
        _prompt = _promptsList[i];
    }
    public void GetResponse()
    {
        //get the response
        _response = Console.ReadLine();

        //gets the date
        DateTime currentTime = DateTime.Now;
        _date = currentTime.ToShortDateString();
    }
    public void GetPhoneTime()
    {
        //get the amount of phone time
        Console.Write("How long did you spend on your phone today? ");
        _phoneTime = Console.ReadLine();
    }
}