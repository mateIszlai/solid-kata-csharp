using System;
using NUnit.Framework;
using ocp;

namespace ocpTests
{
    [TestFixture]
    public class EmployeeShould
    {
        private const int BONUS = 100;
        private const int SALARY = 1000;

        [Test]
        public void not_add_bonus_to_the_engineer_pay_amount()
        {
            Employee employee = new Employee(SALARY, BONUS, EmployeeType.ENGINEER);
            Assert.AreEqual(SALARY, employee.payAmount());
        }

        [Test]
        public void add_bonus_to_the_manager_pay_amount()
        {
            Employee employee = new Employee(SALARY, BONUS, EmployeeType.MANAGER);
            Assert.AreEqual(SALARY + BONUS, employee.payAmount());
        }
    }
}
