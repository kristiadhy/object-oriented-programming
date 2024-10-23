using EncapsulationDemo;

// --- Basic Encapsulation Concept ---
Bank bank = new Bank();
bank.AccountNumber = 12345678;
bank.Name = "Kristiadhy";
bank.GetBalance();
bank.WithdrawAmount();

// --- Data Encapsulation ---

BankDataEncapsulation bankEncapsulation = new BankDataEncapsulation();
//You cannot access the Private Variable
//bank.balance; //Compile Time Error

//You can access the private variable via public setter and getter methods
bankEncapsulation.SetBalance(500);
Console.WriteLine(bankEncapsulation.GetBalance());
Console.ReadKey();