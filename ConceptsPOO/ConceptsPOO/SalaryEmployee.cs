namespace ConceptsPOO
{
    public class SalaryEmployee : Employee
    {
        public decimal Salary { get; set; }
        public override decimal GetValueToPay()
        {
            return Salary;
        }

        public override string ToString()
        {
            return $"\n{base.ToString()}\n\tValue To Pay.......: {$"{GetValueToPay():C2}",18}\n";
        }
    }
}
