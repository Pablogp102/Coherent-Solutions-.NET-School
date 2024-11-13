using Task_2._3.Entities;

public class Program
{
    public static void Main()
    {
        Training training = new Training("Basic C# Training");

        training.AddSession(new Lecture("Intro to C#", "C# Basics"));
        training.AddSession(new PracticalLesson("Hands-on C#", "link_to_task", "link_to_solution"));

        Console.WriteLine($"Is training practical? {training.IsPractical()}");

        Console.WriteLine("\nOriginal Training Sessions:");
        Console.WriteLine($"\nOriginal Training Session Type: {training.GetType().Name}");
        PrintSessions(training);

        Training clonedTraining = training.Clone();

        Console.WriteLine("\nCloned Training Sessions:");
        Console.WriteLine($"\nCloned Training Session Type: {clonedTraining.GetType().Name}:");
        PrintSessions(clonedTraining);

    }

    private static void PrintSessions(Training training)
    {
        foreach (var session in training.GetSessions())
        {
            if (session is Lecture lecture)
            {
                Console.WriteLine($"Lecture - Description: {lecture.Description}, Topic: {lecture.Topic}");
            }
            else if (session is PracticalLesson practicalLesson)
            {
                Console.WriteLine($"Practical Lesson - Description: {practicalLesson.Description}, Task Condition Link: {practicalLesson.TaskConditionLink}, Solution Link: {practicalLesson.SolutionLink}");
            }
        }
    }
}

