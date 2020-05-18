using System;

namespace dip
{
    public class Employee
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public DateTime DateOfBirth { get; private set; }
        public string Email { get; private set; }

        Employee(string firstName, string lastName, DateTime dateOfBirth, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            Email = email;
        }
    }
}
