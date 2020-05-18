namespace dip
{
    public class BirthdayGreeter
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly Clock _clock;

        public BirthdayGreeter(IEmployeeRepository employeeRepository, Clock clock)
        {
            _employeeRepository = employeeRepository;
            _clock = clock;
        }

        public void sendGreetings()
        {
            MonthDay today = _clock.MonthDay;
            _employeeRepository.findEmployeesBornOn(today)
                .ConvertAll(employee => emailFor(employee))
                .ForEach(email => new EmailSender().send(email));

            /*      .map(employee->emailFor(employee))
                    .forEach(email-> new EmailSender().send(email));
            */
        }

        private Email emailFor(Employee employee)
        {
            string message = $"Happy birthday, dear {employee.FirstName}!";
            return new Email(employee.Email, "Happy birthday!", message);
        }
    }
}
