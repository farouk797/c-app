using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using entity;
using bussiness;


namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Informations info = new Informations();
        public Operations opr = new Operations();

        public Form1()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender , EventArgs e)
        {
            info.name = tbName.Text;
            info.prenom = prenom.Text;
            info.datnais = dateTimePicker2.Value.ToShortDateString();
            info.Adresse = tbAdrs.Text;
            info.education = cbEdu.Text;
            info.username= tbUname.Text;
            info.password = tbPass.Text;
            int rows = opr.insertEmp(info);
            if ( rows >0)
            {
                MessageBox.Show("donnes enregistrés avec succes ");

            }

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login mda = new Login();
            mda.Show();
        }
    }
}
