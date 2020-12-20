using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using bussiness;
using entity; 
namespace WindowsFormsApplication2
{
    public partial class Login : Form
    {
        public Informations info = new Informations();
        public Operations opr = new  Operations();
        public string utype;
        DataTable dt = new DataTable();
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
           
}

        private void button1_Click(object sender, EventArgs e)
        {
            info.username = tbUname.Text;
            info.password = tbPass.Text;
            dt = opr.login(info);
            if (dt.Rows.Count > 0)
            {
                utype = dt.Rows[0][8].ToString().Trim();
                if (utype == "A")
                {
                    this.Hide();
                    IAdmin mda = new IAdmin();
                    mda.Show();

                }
                else
                {



                    this.Hide();
                    IEmployee mde = new IEmployee();
                    mde.Show();

                }

            }
            else
            {
                MessageBox.Show("Invalid username ou password !");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 mda = new Form1 ();
            mda.Show();
        }
    }
}