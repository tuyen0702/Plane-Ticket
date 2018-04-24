using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlaneTicketGUI
{
    public partial class SignInGUI : Form
    {
        public SignInGUI()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frm = new PlaneTicketGUI();
            frm.Show();
            this.Hide();
        }
    }
}
