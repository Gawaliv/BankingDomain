class Program
{
    static void Main()
    {
        // Display title
        System.Console.WriteLine("Bank");
        System.Console.WriteLine("LOGIN PAGE");

        // declare variable to store username and password
        string userName = null, password = null;

        // read username from keyboard
        System.Console.Write("username:");
        userName = System.Console.ReadLine();
        if (userName != "")
        {

            // read password from keyboard
            System.Console.Write("password:");
            password = System.Console.ReadLine();
        }
        // check username and password 
        if (userName == "system" && password == "manager")
        {


            int mainMenuChoice = -1;
            do
            {
                System.Console.WriteLine("\n Main menu");
                System.Console.WriteLine("1.Customer");
                System.Console.WriteLine("2.Account");
                System.Console.WriteLine("3.Fund Transfer");
                System.Console.WriteLine("4.Fund Transfer Statement");
                System.Console.WriteLine("5.Account Statement");
                System.Console.WriteLine("0.Exit");

                System.Console.Write("enter choice:");
                mainMenuChoice = int.Parse(System.Console.ReadLine());

                switch (mainMenuChoice)

                {
                    case 1:
                        CustomersMenu();
                        break;
                    case 2:
                        AccountsMenu();
                        break;
                    case 3:

                        break;
                    case 4:

                        break;
                    case 5:

                        break;

                }


            } while (mainMenuChoice != 0);
        }
        else
        {
            System.Console.WriteLine("Invalid username and password");

        }

        // about to exit
        System.Console.WriteLine("Thank you! visit again");
        System.Console.ReadKey();
    }

    static void CustomersMenu()
    {
        int customerMenuChoice = -1;

        // do-while
        do
        {
            System.Console.WriteLine("\n customers menu ");
            System.Console.WriteLine("1.Add customer ");
            System.Console.WriteLine("2.Delete customer ");
            System.Console.WriteLine("3.Update customer ");
            System.Console.WriteLine("4.View customer ");
            System.Console.WriteLine("0.Back to Main Menu");

            System.Console.WriteLine("Enter Choice:");
            customerMenuChoice = System.Convert.ToInt32(System.Console.ReadLine());


        } while (customerMenuChoice != 0);
    }
    static void AccountsMenu()
    {
        int accountsMenuChoice = -1;

        do
        {
            System.Console.WriteLine("\n Accounts menu ");
            System.Console.WriteLine("1.Add account ");
            System.Console.WriteLine("2.Delete account");
            System.Console.WriteLine("3.Update account ");
            System.Console.WriteLine("4.View account ");
            System.Console.WriteLine("0.Back to Main Menu");

            System.Console.WriteLine("Enter Choice:");
            accountsMenuChoice = System.Convert.ToInt32(System.Console.ReadLine());


        } while (accountsMenuChoice != 0);
    }

}
