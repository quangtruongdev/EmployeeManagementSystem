using EmployeeManagementSystem.Models;
using EmployeeManagementSystem.Services;
using System;
using System.Data;
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
            dataGridView1.DataSource = null;

            string search = txt_search.Text;

            dataGridView1.AutoGenerateColumns = false;

            var query = salaryService.LoadData(search, 1, 5);

            dataGridView1.DataSource = query;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            EditSalary edit = new EditSalary();

            if (e.RowIndex >= 0)
            {
                // Kiểm tra nếu cột được click là cột "col_Action"
                if (dataGridView1.Columns[e.ColumnIndex].Name == "col_Action")
                {
                    // lấy giá trị từ cột thứ 2 (index 2) của hàng được click

                    string email = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();

                    Utils.Salary.Email = email;

                    edit.ShowDialog();
                }

                if (dataGridView1.Columns[e.ColumnIndex].Name == "col_pay")
                {
                    string email = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();

                    double? salary = Convert.ToDouble(dataGridView1.Rows[e.RowIndex].Cells[3].Value);

                    DialogResult result = MessageBox.Show("Do you want to continue?", "Confirmation", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {

                        salaryService.Payment(email);

                        MessageBox.Show("Payment for " + salary);

                        LoadData();
                    }
                }
            }
        }

        public void UpdateDataGridView(DataTable newData)
        {
            dataGridView1.DataSource = newData;
        }

        public void removeTest()
        {
            dataGridView1.DataSource = null;
        }

        private void btn__Click(object sender, EventArgs e)
        {
            CreateSalary c = new CreateSalary();
            c.ShowDialog();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string search = txt_search.Text;

            LoadData();
        }
    }
}
