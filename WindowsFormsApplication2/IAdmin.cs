using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class IAdmin : Form
    {
        public IAdmin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        
        }

        private void employeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            IEmployee mda = new IEmployee();
            mda.Show();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void IAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
