public class FiveThingsActivity : Activity
{ 
    private List<string> _responses = new List<string>();

    public FiveThingsActivity(string name) : base(name)
    {
        _description = "This activity will help ground you by focusing on things that correspond to your five senses.";
        _prompts = new List<string>{"prompt1","prompt2","prompt3","prompt4", "prompt5"}; 
    } 

    private void RecieveInputs(int length) //wip
    {
        //will have a for loop to recieve the number of inputs that correspond to the prompt
        for(int i = 0; i < length; i++){

            Console.WriteLine("> ");
            string oneResponse = Console.ReadLine();
            _responses.Add(oneResponse);
        }
    }
    public void PromptResponses()//wip
    {
        Console.WriteLine("running PromptResponses from five things activity");
    
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        DateTime currentTime;

        do{
            //have a for loop to loop through the prompts in order
            //for each prompt, have the corresponding number of inputs that it accepts
            //also have some logic to stop when the time is up

            currentTime = DateTime.Now;//update currentTime

        } while (currentTime < futureTime); //time hasn't run out yet

        
        
    }

}