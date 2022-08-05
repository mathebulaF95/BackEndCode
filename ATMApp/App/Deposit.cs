using System;

public class Deposit
{
	public Deposit()
	{
            IBankAccount newAccount = new BankAccount(false);

            newAccount.Deposit(200);

            Assert.AreEqual(newAccount.GetBalance(), 200);
    }
    public void MaxWithDrawalTest()
    {
            IBankAccount newAccount = new BankAccount(true);
            newAccount.Deposit(1000);
            newAccount.WithDraw(10002);

            Assert.AreEqual(newAccount.GetBalance(), -1);
    }

        [TestMethod]
        public void WithDrawalTest()
        {
            IBankAccount newAccount = new BankAccount(false);
            newAccount.Deposit(100);
            newAccount.WithDraw(90);

            Assert.AreEqual(newAccount.GetBalance(), 10);
        }

}