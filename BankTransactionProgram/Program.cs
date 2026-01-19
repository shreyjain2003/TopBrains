using System;

namespace BankTransactionProgram
{
    /// <summary>
    /// A simple program to calculate the final account balance after a series of transactions.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Calculates the final account balance after processing a series of transactions.
        /// </summary>
        /// <param name="initialBalance">The initial balance of the account before transactions.</param>
        /// <param name="transaction">An array of transaction amounts, where positive values represent deposits and negative values represent withdrawals.</param>
        /// <returns>The final account balance after all valid transactions have been processed.</returns>
        public static int AccountBalance(int initialBalance, int[] transaction)
        {

            int balance =initialBalance;

            for(int i=0;i<transaction.Length;i++)
            {
                if(transaction[i]>=0)
            {
                balance+=transaction[i];
            }
            else if(transaction[i]<0)
            {
                if(balance>=(-transaction[i]))
                {
                    balance+=transaction[i];
                }
            }
            }
            return balance;
             
            
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter initial Balance: ");
            int initialBalance=int.Parse(Console.ReadLine());

            Console.WriteLine("Enter transaction amount (positive to deposite and negative to withdraw): ");
            //int[] transaction=new int[Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse).Length];
            int[] transaction = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            int finalBalance=AccountBalance(initialBalance,transaction);
            Console.WriteLine("Final Account Balance: "+finalBalance);
        }
    }
}