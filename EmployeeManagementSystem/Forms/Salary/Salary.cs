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

        public static string Email = "";

        public static int crrPage = 1;

        public Salary()
        {
            InitializeComponent();
        }

        private void Salary_Load(object sender, EventArgs e)
        {
            LoadData(1);
        }

        public void LoadData(int crrPage)
        {
            dataGridView1.DataSource = null;

            string search = txt_search.Text;

            dataGridView1.AutoGenerateColumns = false;

            var query = salaryService.LoadData(search, crrPage, 5);

            dataGridView1.DataSource = query;

            var pages = Math.Ceiling((double)salaryService.getTotalEmployeeHasSalary() / 5);


            lb_page.Text = crrPage + "/" + pages;

            if (crrPage == 1)
            {
                btn_previous.Enabled = false;
            }
            else
            {
                btn_previous.Enabled = true;
            }

            if (crrPage == pages)
            {
                btn_next.Enabled = false;
            }
            else
            {
                btn_next.Enabled = true;
            }

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

                    Email = email;

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

                        LoadData(1);
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

            LoadData(1);
        }

        private void btn_previous_Click(object sender, EventArgs e)
        {
            crrPage--;

            LoadData(crrPage);
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            crrPage++;

            LoadData(crrPage);
        }

    }
}
