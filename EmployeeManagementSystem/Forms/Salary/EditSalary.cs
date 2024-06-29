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

            var email = Utils.Salary.Email;

            salaryService.updateSalary(email, txt_salary.Text);

            MessageBox.Show("Update successfully");

            s.LoadData();
        }

        public void LoadData()
        {
            txt_email.ReadOnly = true;
            txt_name.ReadOnly = true;

            var email = Utils.Salary.Email;

            var query = salaryService.GetEmployeebyEmail(email);

            txt_email.Text = query.email;

            txt_name.Text = query.name;

            cbx_position.Text = query.posname;

            cbx_dep.Text = query.depname;

            txt_salary.Text = query.salary.ToString();
        }
    }
}
