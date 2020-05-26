using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NSubstitute;
using srp;
using srp.Interfaces;

namespace srpTests
{
    [TestFixture]
    public class AccountServiceShould
    {
        private static readonly int POSITIVE_AMOUNT = 100;
        private static readonly int NEGATIVE_AMOUNT = -POSITIVE_AMOUNT;
        private static readonly DateTime TODAY = new DateTime(2017, 9, 6);
        private static readonly List<Transaction> TRANSACTIONS = new List<Transaction>()
        {
            new Transaction(new DateTime(2014, 4, 1), 1000),
            new Transaction(new DateTime(2014, 4, 2), -100),
            new Transaction(new DateTime(2014, 4, 10), 500)
        };

        private IClock clock;

        private ITransactionRepository transactionRepository;

        private IConsole console;

        private AccountService accountService;

        [SetUp]
        public void setUp()
        {
            console = Substitute.For<IConsole>();
            clock = Substitute.For<IClock>();
            clock.Today().Returns(TODAY);
            transactionRepository = Substitute.For<ITransactionRepository>();
            accountService = new AccountService(transactionRepository, clock, console);
        }
        [Test]
        public void deposit_amount_into_the_account()
        {
            accountService.deposit(POSITIVE_AMOUNT);
            Assert.That(transactionRepository.all().Contains(new Transaction(TODAY, POSITIVE_AMOUNT)));
        }
        [Test]
        public void withdraw_amount_from_the_account()
        {
            accountService.withdraw(POSITIVE_AMOUNT);
            Assert.That(transactionRepository.all().Contains(new Transaction(TODAY, NEGATIVE_AMOUNT)));
        }

        [Test]
        public void print_statement()
        {
            transactionRepository.all().Returns(TRANSACTIONS);

            accountService.printStatement();

            console.PrintLine("DATE | AMOUNT | BALANCE");
            console.PrintLine("10/04/2014 | 500.00 | 1400.00");
            console.PrintLine("02/04/2014 | -100.00 | 900.00");
            console.PrintLine("01/04/2014 | 1000.00 | 1000.00");
        }
    }
}
