using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Problem._1.test
{
    internal class Class1


    {
        public class BankAccount
        {
            private int id;
            private double balance;
            public int ID
            {
                get { return id; }
                set { id = value; }
            }
            public double Balance
            {
                get { return balance; }
            }
            public void Deposit(double amount)
            {
                balance += amount;
            }
            public void Withdraw(double amount)
            { 
            if (amount<=amount)
                {
                    balance -= amount;
                }
                else
                {
                    Console.WriteLine(" Nedostupna licnost");
                }
            }
            public override string ToString() 
            { 
               return$"ID:{id}, Balance:{balance:F2}";
            }
        }
    }
}
