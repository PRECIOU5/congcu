using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace congcuphattrien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtlogin_Click(object sender, EventArgs e)
        {
            string user = "admin";
            string pass = "admin";
            if (user.Equals(txtUserName.Text) && pass.Equals(txtMatKhau.Text))
            {
                this.Hide();
                Form2 form2 = new Form2();
                form2.ShowDialog();
                this.Close();
            }
            else
                MessageBox.Show("Sai tai khoan hoac mat khau");
        }
    }
}
