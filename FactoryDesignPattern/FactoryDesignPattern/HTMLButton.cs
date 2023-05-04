namespace RefactoringGuru.DesignPatterns.FactoryMethod.Conceptual
{
    class HTMLButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("Web Button is working..");
        }
    }
}