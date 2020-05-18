using dip;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dipTests
{
    public class EmployeeBuilder
    {
        private string _firstName = "John";
        private string _lastName = "Doe";
        private DateTime _dateOfBirth = new DateTime(1980, 9, 10);
        private string _email = "john.doe@foobar.com";

        public static EmployeeBuilder anEmployee()
        {
            return new EmployeeBuilder();
        }

        public EmployeeBuilder withEmail(string email)
        {
            _email = email;
            return this;
        }

        public EmployeeBuilder withFirstName(string firstName)
        {
            _firstName = firstName;
            return this;
        }


        public EmployeeBuilder withLastName(string lastName)
        {
            _lastName = lastName;
            return this;
        }

        public EmployeeBuilder withDateOfBirth(DateTime dateOfBirth)
        {
            _dateOfBirth = dateOfBirth;
            return this;
        }

        public Employee build()
        {
            return new Employee(_firstName, _lastName, _dateOfBirth, _email);
        }
    }
}
