using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Common.Popup;
using BLL.BLL;
using Common.Message;
using DAL.BLL;

namespace PayrollSystem
{
    public partial class Main : Form
    {
        Timer timer = new Timer();

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            StartTime();
        }

        private void StartTime()
        {
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Enabled = true;
            lblCurrentDate.Text = DateTime.Now.ToLongDateString();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblCurrentTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void newUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserPopup userForm = new UserPopup();

            try
            {
                userForm.ShowDialog();

                if (userForm.DialogResult == DialogResult.OK)
                {
                    UserBLL.Save(userForm.GetUser());
                    MessageBox.Show(ErrorMessage.SUCCESSFULLY_SAVE, "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void newPositionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PositionPopup positionForm = new PositionPopup();

            try
            {
                positionForm.ShowDialog();

                if (positionForm.DialogResult == DialogResult.OK)
                {
                    PositionBLL.Save(positionForm.GetData());
                    MessageBox.Show(ErrorMessage.SUCCESSFULLY_SAVE, "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
