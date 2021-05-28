using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Common.Entity;

namespace Common.Popup
{
    public partial class UserPopup : Form
    {
        private string _firstName = string.Empty;
        private string _lastName = string.Empty;
        private string _middleName = string.Empty;
        private byte _positionType = 0;
        UserEntity _userEntity = null;

        public UserPopup()
        {
            InitializeComponent();
        }

        public UserEntity GetUser()
        {
            return _userEntity;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            UserEntity entity = new UserEntity(Guid.Empty,
                1,
                txtBoxFirstName.Text,
                txtBoxMiddleName.Text,
                txtBoxLastName.Text);

            if (entity.Validate())
            {
                this.DialogResult = DialogResult.OK;
                _userEntity = entity;
            }
            else
            {
                MessageBox.Show(entity.GetErrorMessage(), "Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
