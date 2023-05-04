namespace RefactoringGuru.DesignPatterns.FactoryMethod.Conceptual
{
    class HTMLButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("HTML Button is working..");
        }
    }
}