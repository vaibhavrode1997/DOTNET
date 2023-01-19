using Banking;
    
    int choice=0;
    Account account=null;
    double Balance=0;
    do{
        Console.WriteLine("Welcome To HDFC BANK!!!!!!");
        Console.WriteLine("Enter your Choice:");
         Console.WriteLine("1.Create Account\n2.Deposit Amount\n3.Withdraw Amount\n4.Mini Statement\n5.Exit");
         choice=Convert.ToInt32(Console.ReadLine());
         switch(choice)
         {
            case 1:
            account.CreateAccount();
            break;
             case 2:
             Console.WriteLine("Enter deposit Amounr:");
               Balance=Convert.ToDouble(Console.ReadLine());
               account.Deposit(Balance);
            break;
             case 3:
              Console.WriteLine("Enter Withdraw Amounr:");
                Balance=Convert.ToDouble(Console.ReadLine());
                account.Withdraw(Balance);
            break;
             case 4:
             
            break;
             case 5:
              Console.WriteLine("Thank You Visit Again!!!!");
            break;
            default:
            Console.WriteLine("Enter valid Choice...");
            break;  
         }
    }while(choice!=5);




