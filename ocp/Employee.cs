namespace ocp
{
    public class Employee
    {
        private int _salary;
        private int _bonus;
        private EmployeeType _type;

        Employee(int salary, int bonus, EmployeeType type)
        {
            this._salary = salary;
            this._bonus = bonus;
            this._type = type;
        }

        public int payAmount()
        {
            switch (_type)
            {
                case EmployeeType.ENGINEER:
                    return _salary;
                case EmployeeType.MANAGER:
                    return _salary + _bonus;
                default:
                    return 0;
            }
        }
    }
}
