namespace EmployeeManagementSystem.Interfaces
{
    public interface IDashboard
    {
        (int totalProjects, int totalEmployees) GetSummary();
    }
}
