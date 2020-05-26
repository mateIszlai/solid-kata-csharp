using srp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace srp
{
    public class AccountService
    {
        private static readonly string STATEMENT_HEADER = "DATE | AMOUNT | BALANCE";
        private static readonly string DATE_FORMAT = "dd/MM/yyyy";
        private static readonly string AMOUNT_FORMAT = "#.00";

        private ITransactionRepository transactionRepository;
        private IClock clock;
        private IConsole console;

        public AccountService(ITransactionRepository transactionRepository, IClock clock, IConsole console)
        {
            this.transactionRepository = transactionRepository;
            this.clock = clock;
            this.console = console;
        }

        public void deposit(int amount)
        {
            transactionRepository.Add(transactionWith(amount));
        }


        public void withdraw(int amount)
        {
            transactionRepository.Add(transactionWith(-amount));
        }

        public void printStatement()
        {
            printHeader();
            printTransactions();
        }


        private void printHeader()
        {
            printLine(STATEMENT_HEADER);
        }


        private void printTransactions()
        {
            List<Transaction> transactions = transactionRepository.all();
            int balance = 0;
            List<string> lines = new List<string>();
            foreach (var tran in transactions)
            {
                balance += tran.Amount();
                var line = statementLine(tran, balance);
                printLine(line);
                lines.Add(line);

            }
        }


        private Transaction transactionWith(int amount)
        {
            return new Transaction(clock.Today(), amount);
        }


        private string statementLine(Transaction transaction, int balance)
        {
            return ($"{formatDate(transaction.Date())} | {formatNumber(transaction.Amount())} | {formatNumber(balance)}");
        }

        private string formatDate(DateTime date)
        {
            return date.ToString(DATE_FORMAT);
        }

        private string formatNumber(int amount)
        {
            return amount.ToString(AMOUNT_FORMAT);
        }


        private void printLine(string line)
        {
            console.PrintLine(line);
        }
    }
}
