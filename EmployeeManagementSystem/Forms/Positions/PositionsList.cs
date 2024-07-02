using EmployeeManagementSystem.Interfaces;
using EmployeeManagementSystem.Services;
using System;
using System.Windows.Forms;

namespace EmployeeManagementSystem.Forms.Positons
{
    public partial class PositionsList : Form
    {
        private readonly IPositions _positionsService;
        private int currentPage = 1;
        private int pageSize = 2;
        public PositionsList()
        {
            InitializeComponent();
            _positionsService = new PositionsService();
            LoadPositions();
        }

        private void LoadPositions()
        {
            //var positions = _positionsService.GetPositions();
            var results = _positionsService.GetPositions(currentPage, pageSize);
            var positions = results.Positions;
            var totalPages = results.TotalPages;

            Tbl_Positions.AutoGenerateColumns = false;

            Tbl_Positions.DataSource = positions;

            PageOnPage.Text = $"Page {currentPage}/{totalPages}";
            Btn_Pre.Enabled = currentPage > 1;
            Btn_Next.Enabled = currentPage < totalPages;
        }

        private void Btn_AddPosition_Click(object sender, EventArgs e)
        {
            PositionForm positionForm = new PositionForm();
            if (positionForm.ShowDialog() == DialogResult.OK)
            {
                LoadPositions();
            }
        }

        private void EditPositionForm(string positionId)
        {
            PositionForm positionForm = new PositionForm(positionId);
            if (positionForm.ShowDialog() == DialogResult.OK)
            {
                LoadPositions();
            }
        }

        private void DeletePosition(string positionId)
        {
            var dialogResult = MessageBox.Show("Are you sure you want to delete this position?", "Delete Position", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                _positionsService.DeletePosition(positionId);
                LoadPositions();
            }
        }

        private void Tbl_Positions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string positionId = Tbl_Positions.Rows[e.RowIndex].Cells[1].Value.ToString();

                if (Tbl_Positions.Columns[e.ColumnIndex].Name == "Btn_Edit")
                {

                    EditPositionForm(positionId);
                }
                else if (Tbl_Positions.Columns[e.ColumnIndex].Name == "Btn_Delete")
                {
                    DeletePosition(positionId);
                }
            }
        }

        private void Btn_Pre_Click(object sender, System.EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                LoadPositions();
            }
        }

        private void Btn_Next_Click(object sender, System.EventArgs e)
        {
            currentPage++;
            LoadPositions();
        }
    }
}
