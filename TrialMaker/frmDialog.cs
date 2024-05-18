using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SoftwareLocker
{
    public partial class frmDialog : Form
    {
        private string _Pass;

        public frmDialog(string BaseString,
            string Password,int DaysToEnd,int Runed, string info)
        {
            InitializeComponent();
            sebBaseString.Text = BaseString;
            _Pass = Password;
            lbldays.Text = DaysToEnd.ToString();
            //lblTimes.Text = Runed.ToString() + " Time(s)";
            //lblText.Text = info;
            if (DaysToEnd <= 0 /*|| Runed <= 0*/)
            {
                lbldays.Text = "ÇäÊåÊ";
                //lblTimes.Text = "Finished";
                btnTrial.Enabled = false;
            }

            sebPassword.Select();
        }

        private void btnOK_Click_1(object sender, EventArgs e)
        {
            if (_Pass == sebPassword.Text)
            {
                MessageBox.Show("Êã ÇáÊÝÚíá", "ÊÃßíÏ",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
            }
            else
                MessageBox.Show("ÎØÃ Ýí ÇáÊÝÚíá", "ÎØÃ",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void groupControl3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnTrial_Click_1(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Retry;
        }
    }
}