Dictionary<int, Employee> employees = new Dictionary<int, Employee>();

employees.Add(100, new Employee()
{
    FirstName = "Marcin",
    LastName = "Jamro",
    PhoneNumber = "000-000-000"
});

employees.Add(210, new Employee()
{
    FirstName = "Mary",
    LastName = "Fox",
    PhoneNumber = "111-111-111"
});

employees.Add(303, new Employee()
{
    FirstName = "John",
    LastName = "Smith",
    PhoneNumber = "222-222-222"
});

bool isCorrect = true;

do
{
    Console.Write("Coloque o identificador do funcionário: ");
    string idString = Console.ReadLine();

    isCorrect = int.TryParse(idString, out int id);

    if (isCorrect)
    {
        Console.ForegroundColor = ConsoleColor.White;

        if (employees.TryGetValue(id, out Employee employee))
        {
            Console.WriteLine(
                "Primeiro Nome: {1}{0}Segundo Nome: {2}{0}Número de telefone: {3}",
                Environment.NewLine,
                employee.FirstName,
                employee.LastName,
                employee.PhoneNumber);
        }
        else
        {
            Console.WriteLine(
                "O funcionário com esse identificador não existe.");
        }

        Console.ForegroundColor = ConsoleColor.Gray;
    }
}
while (isCorrect);

public class Employee
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }
}