using EmployeeManagementSystem.Interfaces;
using EmployeeManagementSystem.Models;
using EmployeeManagementSystem.Services;
using System;
using System.Windows.Forms;

namespace EmployeeManagementSystem.Forms.Positons
{
    public partial class PositionForm : Form
    {
        private readonly string _positionId;
        private readonly IPositions _positionsService;
        public PositionForm(string positionId = null)
        {
            InitializeComponent();
            _positionsService = new PositionsService();
            _positionId = positionId;
            if (_positionId != null)
            {
                this.Text = "Edit Position";
                LoadPositionDetails();
            }
            else
            {
                this.Text = "Add Position";
            }
        }

        private void Btn_Submit_Click(object sender, EventArgs e)
        {
            var positionName = Txt_PositionName.Text.Trim();
            ValidateForm();
            var position = new Positon
            {
                PositionName = positionName
            };

            try
            {
                if (_positionId != null)
                {
                    position.PositionID = _positionId;
                    _positionsService.UpdatePosition(position);
                    MessageBox.Show("Position updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    _positionsService.AddPosition(position);
                    MessageBox.Show("Position added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadPositionDetails()
        {
            var position = _positionsService.GetPositionById(_positionId);
            Txt_PositionName.Text = position.PositionName;
        }

        private void ValidateForm()
        {
            bool isFormValid = true;
            if (string.IsNullOrEmpty(Txt_PositionName.Text.Trim()))
            {
                PositionNameError.Text = "Position name is required";
                isFormValid = false;
            }
            else
            {
                PositionNameError.Text = string.Empty;
            }

            Btn_Submit.Enabled = isFormValid;
        }
    }
}
