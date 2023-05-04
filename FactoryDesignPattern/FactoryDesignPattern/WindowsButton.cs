namespace RefactoringGuru.DesignPatterns.FactoryMethod.Conceptual
{
    class WindowsButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("Windows Button is working..");
        }
    }
}