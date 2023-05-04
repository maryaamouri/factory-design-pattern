namespace RefactoringGuru.DesignPatterns.FactoryMethod.Conceptual
{
    class WindowsDialogFactory : FactoryDialog
    {
        public override IButton CreateButton()
        {
            return new WindowsButton();
        }
    }
}