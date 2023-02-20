using TestConsoleApp.AdditionalFiles;

namespace TestConsoleApp;


public class MainClass
{
    static void Main()
    {
        Execution execution= new Execution();
        execution.Execute();
    }
}

public class Execution
{
    TestClass2 test = new TestClass2();
    public void Execute()
    {
        Console.WriteLine("Hello world!");
        test.DisplayName("Мужик", "Таджик");
    }
}