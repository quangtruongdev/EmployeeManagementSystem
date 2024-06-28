using EmployeeManagementSystem.Models;
using EmployeeManagementSystem.Services;
using System;
using System.Windows.Forms;

namespace EmployeeManagementSystem.Forms.Salary
{
    public partial class Salary : Form
    {
        DatabaseDataContext db = new DatabaseDataContext();

        SalaryService salaryService = new SalaryService();

        public Salary()
        {
            InitializeComponent();
        }

        private void Salary_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            string search = txt_search.Text;

            var query = salaryService.LoadData(search);

            dataGridView1.DataSource = query;
        }
    }
}
