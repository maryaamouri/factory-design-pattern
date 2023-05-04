namespace RefactoringGuru.DesignPatterns.FactoryMethod.Conceptual
{
    class WebDialogFactory : FactoryDialog
    {
        public override IButton CreateButton()
        {
            return new HTMLButton();
        }
    }
}