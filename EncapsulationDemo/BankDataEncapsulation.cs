using System;

namespace EncapsulationDemo;

public class BankDataEncapsulation
{
    // Hiding class data by declaring the variable as private
    private double balance;

    // Creating public Setter and Getter methods

    // Public Getter Method
    // This method is used to return the data stored in the balance variable
    public double GetBalance()
    {
        // Add validation logic if needed
        if(balance > 1000000)
            throw new Exception("You are not allowed to check balance because you are too rich");
        
        return balance;
    }

    // Public Setter Method
    // This method is used to stored the data  in the balance variable
    public void SetBalance(double balance)
    {
        if(balance < 0)
            throw new Exception("Balance cannot be negative");
            
        // Add validation logic to check whether data is correct or not
        this.balance = balance;
    }

}
