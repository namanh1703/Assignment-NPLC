namespace TPBank.Presentation
{
    class Program
    {
        static void Main()
        {
            //display title
             Console.WriteLine("**************TPBank**************");

            //display heading
             Console.WriteLine("::Login Page::");

            //declare variables to store username and password
            string userName = null, password = null;

            //read userName from keyboard
             Console.Write("Username: ");
            userName =  Console.ReadLine();


            //read password from keyboard only if username is entered
            if (userName != "")
            {
                 Console.Write("Password: ");
                password =  Console.ReadLine();
            }

            //check username and password
            if (userName == "admin" && password == "123456")
            {
                //declare variable to store menu choice
                int mainMenuChoice = -1;

                do
                {
                    //show main menu
                     Console.WriteLine("\n:::Main menu:::");
                     Console.WriteLine("1. Customer");
                     Console.WriteLine("2. Accounts");
                     Console.WriteLine("3. Funds Transfer");
                     Console.WriteLine("4, Funds Transfer Statement");
                     Console.WriteLine("5. Account Statement");
                     Console.WriteLine("0. Exit");

                    //accept menu choice from keyboard
                     Console.Write("Enter choice: ");
                    mainMenuChoice = int.Parse( Console.ReadLine());

                    //switch-case to check choice
                    switch (mainMenuChoice)
                    {
                        case 1: CustomerMenu(); break;
                        case 2: AccountsMenu(); break;
                        case 3: FundsTransferMenu(); break;
                        case 4: FundsTransferStatementMenu(); break;
                        case 5: AccountStatementMenu(); break;
                    }
                } while (mainMenuChoice != 0);

            }
            else
            {
                 Console.WriteLine("Invalid username or password");
            }

            //about to exit
             Console.WriteLine("Thank you! Visit again");
             Console.ReadKey();


        }

        static void CustomerMenu()
        {
            //variable to store customers menu choice
            int customerMenuChoice = -1;

            //do-while
            do
            {
                //print customers menu
                 Console.WriteLine("\n:::Customer menu:::");
                 Console.WriteLine("1. Add Customer");
                 Console.WriteLine("2. Delete Customer");
                 Console.WriteLine("3. Update Customer");
                 Console.WriteLine("4. Search Customers");
                 Console.WriteLine("5. View Customers");
                 Console.WriteLine("0. Back to Main Menu");

                //accept customer menu choice
                 Console.Write("Enter choice: ");
                customerMenuChoice =  Convert.ToInt32( Console.ReadLine());

                //create switch case
                switch (customerMenuChoice)
                {
                    case 1: CustomersPresentation.AddCustomer(); break;
                    case 2: CustomersPresentation.DeleteCustomer(); break;
                    case 3: CustomersPresentation.UpdateCustomer(); break;
                    case 4: CustomersPresentation.SearchCustomer(); break;
                    case 5: CustomersPresentation.ViewCustomer(); break;
                }

            } while (customerMenuChoice != 0);
        }

        static void AccountsMenu()
        {
            //variable to store customers menu choice
            int accountsMenuChoice = -1;

            //do-while
            do
            {
                //print customers menu
                 Console.WriteLine("\n:::Accounts menu:::");
                 Console.WriteLine("1. Add Account");
                 Console.WriteLine("2. Delete Account");
                 Console.WriteLine("3. Update Account");
                 Console.WriteLine("4. View Accounts");
                 Console.WriteLine("0. Back to Main Menu");

                //accept customer menu choice
                 Console.Write("Enter choice: ");
                accountsMenuChoice =  Convert.ToInt32( Console.ReadLine());

            } while (accountsMenuChoice != 0);
        }

        static void FundsTransferMenu()
        {
            //variable to store customers menu choice
            int accountsMenuChoice = -1;

            //do-while
            do
            {
                //print customers menu
                 Console.WriteLine("\n:::Funds Transfer menu:::");
                 Console.WriteLine("1. Transfer Between Bank Accounts");
                 Console.WriteLine("0. Back to Main Menu");

                //accept customer menu choice
                 Console.Write("Enter choice: ");
                accountsMenuChoice =  Convert.ToInt32( Console.ReadLine());

            } while (accountsMenuChoice != 0);
        }

        static void FundsTransferStatementMenu()
        {
            //variable to store customers menu choice
            int accountsMenuChoice = -1;

            //do-while
            do
            {
                //print customers menu
                 Console.WriteLine("\n:::Funds Transfer Statement menu:::");
                 Console.WriteLine("1. View List of Funds Transfer");
                 Console.WriteLine("0. Back to Main Menu");

                //accept customer menu choice
                 Console.Write("Enter choice: ");
                accountsMenuChoice =  Convert.ToInt32( Console.ReadLine());

            } while (accountsMenuChoice != 0);
        }

        static void AccountStatementMenu()
        {
            //variable to store customers menu choice
            int accountsMenuChoice = -1;

            //do-while
            do
            {
                //print customers menu
                 Console.WriteLine("\n:::Accounts Statement Menu:::");
                 Console.WriteLine("1. View Debit Transactions");
                 Console.WriteLine("2. View Credit Transaction");
                 Console.WriteLine("3. View All Transaction");
                 Console.WriteLine("0. Back to Main Menu");

                //accept customer menu choice
                 Console.Write("Enter choice: ");
                accountsMenuChoice =  Convert.ToInt32( Console.ReadLine());

            } while (accountsMenuChoice != 0);
        }

    }
}
