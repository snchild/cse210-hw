public class FiveThingsActivity : Activity
{ 
    private List<string> _responses = new List<string>();

    public FiveThingsActivity(string name) : base(name)
    {
        _description = "This activity will help ground you by focusing on things that correspond to your five senses.";
        _prompts = new List<string>{"List 5 things you can see: ","List 4 things you can feel: ","List 3 things you can hear: ","List 2 things you can smell: ", "List 1 thing you can taste: "}; 
    } 

    private void RecieveInputs(int length) 
    {
        //will have a for loop to recieve the number of inputs that correspond to the prompt
        for(int i = 0; i < length; i++){

            Console.Write("> ");
            string oneResponse = Console.ReadLine();
            _responses.Add(oneResponse);
        }
    }
    public void PromptResponses()
    {    
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        DateTime currentTime = startTime;

        Console.WriteLine(" "); //makes spacing better

        do{
            //have a for loop to loop through the prompts in order
            for (int j = 0; (j < 5 && currentTime < futureTime); j++)
            {
                //show the current prompt
                Console.WriteLine(_prompts[j]);
                RecieveInputs(5 - j); //for each prompt, have the corresponding number of inputs that it accepts

                currentTime = DateTime.Now;//update currentTime
            }
            
            currentTime = DateTime.Now;//update currentTime

        } while (currentTime < futureTime); //time hasn't run out yet

        
        
    }

}