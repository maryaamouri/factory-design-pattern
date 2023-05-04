﻿using System;

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
            ClientCode(new WebDialogFactory());

        }

        public static void ClientCode(FactoryDialog dialog)
        {
            // using web
            IButton myButton = dialog.CreateButton();
            myButton.Render();
            // using windows
            

        }

        public static void Main(string[] args)
        {
            Initialize();
                        
        }

    }
}