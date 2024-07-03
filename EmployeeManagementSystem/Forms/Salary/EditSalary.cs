using EmployeeManagementSystem.Services;
using System.Linq;
using System.Windows.Forms;

namespace EmployeeManagementSystem.Forms.Salary
{
    public partial class EditSalary : Form
    {
        public EditSalary()
        {
            InitializeComponent();
        }

        SalaryService salaryService = new SalaryService();

        private void EditSalary_Load(object sender, System.EventArgs e)
        {

            LoadData();

        }

        private void btn_update_Click(object sender, System.EventArgs e)
        {
            Salary s = Application.OpenForms.OfType<Salary>().FirstOrDefault();

            var email = Salary.Email;

            if (string.IsNullOrEmpty(txt_salary.Text))
            {
                MessageBox.Show("Lương không được để trống.");
                return;
            }

            if (!decimal.TryParse(txt_salary.Text, out decimal salary))
            {
                MessageBox.Show("Lương không hợp lệ, vui lòng nhập một số hợp lệ.");
                return;
            }

            salaryService.updateSalary(email, txt_salary.Text);

            MessageBox.Show("Update successfully");

            s.LoadData(1);
        }

        public void LoadData()
        {
            txt_email.ReadOnly = true;
            txt_name.ReadOnly = true;
            txt_pos.ReadOnly = true;
            txt_dep.ReadOnly = true;

            var email = Salary.Email;

            var query = salaryService.GetEmployeebyEmail(email);

            txt_email.Text = query.email;

            txt_name.Text = query.name;

            txt_pos.Text = query.posname;

            txt_dep.Text = query.depname;

            txt_salary.Text = query.salary.ToString();
        }
    }
}
