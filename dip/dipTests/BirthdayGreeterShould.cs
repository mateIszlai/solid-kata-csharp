using System;
using System.Text;
using dip;
using NUnit.Framework;
using NSubstitute;
using System.IO;
using System.Collections.Generic;

namespace dipTests
{
    [TestFixture]
    public class BirthdayGreeterShould
    {
        private const int CURRENT_MONTH = 7;
        private const int CURRENT_DAY_OF_MONTH = 9;
        private readonly MonthDay TODAY = new MonthDay { Month = CURRENT_MONTH, Day = CURRENT_DAY_OF_MONTH };
        private IEmployeeRepository _employeeRepository;    
        private IClock _clock;
        private BirthdayGreeter _birthdayGreeter;
        private StringBuilder _consoleContent = new StringBuilder();


        [SetUp]
        public void SetUp()
        {
            _employeeRepository = Substitute.For<IEmployeeRepository>();
            _clock = Substitute.For<IClock>();
            _birthdayGreeter = new BirthdayGreeter(_employeeRepository, (Clock) _clock); //TODO
        }


        [TearDown]
        public void TearDown()
        {
            _consoleContent.Clear();
            _employeeRepository = null;
            _clock = null;
            _birthdayGreeter = null;
        }

        [Test]
        public void should_send_greeting_email_to_employee()
        {
            Console.SetOut(new StringWriter(_consoleContent));
            _clock.MonthDay().Returns(TODAY);
            //given(_clock.monthDay()).willReturn(TODAY);
            Employee employee = EmployeeBuilder.anEmployee().build();
            _employeeRepository.findEmployeesBornOn(new MonthDay { Month = CURRENT_MONTH, Day = CURRENT_DAY_OF_MONTH }).Returns(new List<Employee> { employee });
            //given(employeeRepository.findEmployeesBornOn(MonthDay.of(CURRENT_MONTH, CURRENT_DAY_OF_MONTH))).willReturn(Collections.singletonList(employee));

            _birthdayGreeter.sendGreetings();

            string actual = _consoleContent.ToString();
            Assert.AreEqual($"To:{employee.Email}, Subject: Happy birthday!, Message: Happy birthday, dear {employee.FirstName}!", actual);
            //assertThat(actual)
              //      .isEqualTo("To:" + employee.getEmail() + ", Subject: Happy birthday!, Message: Happy birthday, dear " + employee.getFirstName() + "!");

        }
    }
}
