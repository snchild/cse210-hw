using System;

class Program
{
    static void Main(string[] args)
    {
        //order: name, topic, section, problem(s)
        MathAssignment assign1 = new MathAssignment("Samuel Bennett","Multiplication","7.3","6-10, 12, 19");

        List<string> nameAndTopic1 = assign1.GetSummary();
        List<string> sectionAndProblems = assign1.GetHomeworkList();
        Console.WriteLine($"\n{nameAndTopic1[0]} - {nameAndTopic1[1]}");
        Console.WriteLine($"Section {sectionAndProblems[0]} Problems {sectionAndProblems[1]}");

        //order: name, topic, title
        WritingAssignment assign2 = new WritingAssignment("Mary Waters","European History","The Causes of World War II");

        List<string> nameAndTopic2 = assign2.GetSummary();
        List<string> titleAndAuthor = assign2.GetWritingInformation();
        Console.WriteLine($"\n{nameAndTopic2[0]} - {nameAndTopic2[1]}");
        Console.WriteLine($"{titleAndAuthor[0]} by {titleAndAuthor[1]}\n");
    }
}