namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee("Chamil", "Jeewantha", 250000.00);
            Employee employee2 = new Employee("Umashini", "Sureshkumar", 40000.25);
            employee1.print(employee1.FirstName, employee1.LastName,employee1.BasaicSalary);
        }
    }
}
