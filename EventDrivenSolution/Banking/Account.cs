namespace Banking;
using Utility;
public class Account
{
    private static int AccountNo=0;
    public string FirstName{get;set;}
    public string LastName{get;set;}
    public double Balance{get;set;}

//parameterless constructor
    public Account(){
        this.FirstName="vaibhav";
        this.LastName="rode";
        this.Balance=5000;
        AccountNo++;
    }  
    //parameterized constructor
     public Account(string FirstName,string LastName,double Balance){
        this.FirstName=FirstName;
        this.LastName=LastName;
        this.Balance=Balance;
        AccountNo++;
    }  
    // deposit method
     public void Deposit(double amount){

        this.Balance+=amount;
        if(this.Balance >=250000){
            //call an event
           
        }
    }
    //Withdraw method
    public void Withdraw(double amount){
        this.Balance-=amount;
        if(this.Balance <=5000){
        }
    }
    //CreateAccount method
    public void CreateAccount(){
       Console.WriteLine("Enter your FirstName:");
       string FirstName=Console.ReadLine();
        Console.WriteLine("Enter your LastName:");
        string LastName=Console.ReadLine();
        Console.WriteLine("Enter Balance :");
        double Balance=Convert.ToDouble(Console.ReadLine());
        Account User=new Account(FirstName,LastName,Balance);
        Console.WriteLine("Account is Created...\n Account Number : "+AccountNo);
    }
}
