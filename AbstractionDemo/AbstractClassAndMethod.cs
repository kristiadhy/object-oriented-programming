using System;

namespace AbstractionDemo;

public abstract class IBank
{
    public abstract void ValidateCard();
    public abstract void WithdrawMoney();
    public abstract void CheckBalanace();
    public abstract void BankTransfer();
    public abstract void MiniStatement();
}
public class SBI : IBank
{
    public override void BankTransfer()
    {
        Console.WriteLine("SBI Bank Bank Transfer");
    }
    public override void CheckBalanace()
    {
        Console.WriteLine("SBI Bank Check Balanace");
    }
    public override void MiniStatement()
    {
        Console.WriteLine("SBI Bank Mini Statement");
    }
    public override void ValidateCard()
    {
        Console.WriteLine("SBI Bank Validate Card");
    }
    public override void WithdrawMoney()
    {
        Console.WriteLine("SBI Bank Withdraw Money");
    }
}
public class AXIX : IBank
{
    public override void BankTransfer()
    {
        Console.WriteLine("AXIX Bank Bank Transfer");
    }
    public override void CheckBalanace()
    {
        Console.WriteLine("AXIX Bank Check Balanace");
    }
    public override void MiniStatement()
    {
        Console.WriteLine("AXIX Bank Mini Statement");
    }
    public override void ValidateCard()
    {
        Console.WriteLine("AXIX Bank Validate Card");
    }
    public override void WithdrawMoney()
    {
        Console.WriteLine("AXIX Bank Withdraw Money");
    }
}

// public class BankFactory
// {
//     public static IBank GetBankObject(string bankType)
//     {
//         IBank BankObject = null;
//         if (bankType == "SBI")
//         {
//             BankObject = new SBI();
//         }
//         else if (bankType == "AXIX")
//         {
//             BankObject = new AXIX();
//         }
//         return BankObject;
//     }
// }
