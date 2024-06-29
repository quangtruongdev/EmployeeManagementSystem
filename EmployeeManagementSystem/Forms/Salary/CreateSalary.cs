using EmployeeManagementSystem.Services;
using System;
using System.Linq;
using System.Windows.Forms;

namespace EmployeeManagementSystem.Forms.Salary
{
    public partial class CreateSalary : Form
    {
        public CreateSalary()
        {
            InitializeComponent();
            LoadData();
        }

        SalaryService salaryService = new SalaryService();

        void LoadData()
        {
            txt_dep.ReadOnly = true;
            txt_email.ReadOnly = true;
            txt_name.ReadOnly = true;
            txt_pos.ReadOnly = true;

            string search = txt_search.Text;

            dataGridView1.AutoGenerateColumns = false;

            dataGridView1.DataSource = null;

            var query = salaryService.loadEmployee(search, 5);

            if (query == null)
            {
                MessageBox.Show("No data found");
                return;
            }

            dataGridView1.DataSource = query;
        }

        private void btn_search_Click(object sender, System.EventArgs e)
        {
            LoadData();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var emp = dataGridView1.Rows[e.RowIndex];

            string name = emp.Cells[0].Value.ToString() + " " + emp.Cells[1].Value.ToString();

            txt_name.Text = name;

            txt_email.Text = emp.Cells[2].Value.ToString();

            txt_pos.Text = emp.Cells[3].Value.ToString();

            txt_dep.Text = emp.Cells[4].Value.ToString();
        }

        private void btn_update_Click(object sender, System.EventArgs e)
        {
            string salary = txt_salary.Text;

            double? salaryAmout = TryParseNullableDouble(salary);

            string email = txt_email.Text;

            if (salaryAmout == null)
            {
                MessageBox.Show("Invalid salary amount");
                return;
            }

            salaryService.addSalary(email, salaryAmout);

            MessageBox.Show("Added successfully");

            Salary s = Application.OpenForms.OfType<Salary>().FirstOrDefault();

            s.LoadData();
        }

        public double? TryParseNullableDouble(string s)
        {
            double result;
            bool success = Double.TryParse(s, out result);
            if (success)
            {
                return result;
            }
            else
            {
                return null;
            }
        }
    }
}
