using Common.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Common.Popup
{
    public partial class PositionPopup : Form
    {

        private string _positionName = string.Empty;
        private decimal _rate = 0m;

        PositionEntity _positionEntity = null;

        public PositionPopup()
        {
            InitializeComponent();
        }

        public PositionEntity GetData()
        {
            return _positionEntity;
        }

        private void txtBoxRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            //-- sinearch ko lng to code sa baba.. kaya wag k mamangha.. hahaa
            //-- Keyword searh: Windows form number only in textbox
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            PositionEntity entity = new PositionEntity(txtBoxPositionName.Text,
                   Convert.ToDecimal(txtBoxRate.Text));

            if (entity.Validate())
            {
                this.DialogResult = DialogResult.OK;
                _positionEntity = entity;
            }
            else
            {
                MessageBox.Show(entity.GetErrorMessage(), "Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
