using AbstractionDemo;

// -- Abstract class with abstract methods
Console.WriteLine("Transaction doing SBI Bank");
// IBank sbi = BankFactory.GetBankObject("SBI");
IBank sbi = new SBI();
sbi.ValidateCard();
sbi.WithdrawMoney();
sbi.CheckBalanace();
sbi.BankTransfer();
sbi.MiniStatement();

Console.WriteLine("\nTransaction doing AXIX Bank");
// IBank AXIX = BankFactory.GetBankObject("AXIX");
AXIX AXIX = new AXIX();
AXIX.ValidateCard();
AXIX.WithdrawMoney();
AXIX.CheckBalanace();
AXIX.BankTransfer();
AXIX.MiniStatement();
Console.Read();

// -- Abstract class with non-abstract methods
Sparrow sparrow = new Sparrow();
sparrow.Fly();
sparrow.LayEggs(); // This method is already implemented in the abstract class

// -- Interface
Dog dog = new Dog();
dog.Speak();
dog.Move();

ISpeakable speakableDog = new Dog();
speakableDog.Speak();

IMoveable moveableDog = new Dog();
moveableDog.Move();

Console.Read();