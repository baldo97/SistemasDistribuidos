using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatApp
{
    public partial class Login : Form
    {
        public String UserName = "";
        public Login()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.txtUsername.Text))
            {
                this.UserName = this.txtUsername.Text;
                this.DialogResult = DialogResult.OK;
            }
            //else TODO Implementar validacion username vacio
                 

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
