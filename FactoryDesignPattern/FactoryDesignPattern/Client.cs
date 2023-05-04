using System;

namespace RefactoringGuru.DesignPatterns.FactoryMethod.Conceptual
{

    class Client
    {
        static FactoryDialog dialog;

        public static void Initialize()
        {

            Console.WriteLine("App: Launched with the WindowsDialog.");
            ClientCode(new WindowsDialogFactory());

            Console.WriteLine("");

            Console.WriteLine("App: Launched with the WebDialog.");
            ClientCode(new WindowsDialogFactory());

        }

        public static void ClientCode(FactoryDialog dialog)
        {

            Console.WriteLine("Client: I'm not aware of the creator's class," +
                "but it still works.\n" + dialog.CreateButton());

        }

        public static void Main(string[] args)
        {
            Initialize();
                        
        }

    }
}