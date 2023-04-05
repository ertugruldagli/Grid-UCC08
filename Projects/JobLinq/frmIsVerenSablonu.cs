using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobLinq
{
    public partial class frmIsVerenSablonu : Form
    {
        public frmIsVerenSablonu()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            label4.BackColor = Color.LightBlue;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
