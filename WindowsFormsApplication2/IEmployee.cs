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
    public partial class IEmployee : Form
    {
        public Operations opr = new Operations();
        public Informations info = new Informations();
        public int ID = 0;
        //public int f = 0;    {
        public IEmployee()
        {
            InitializeComponent();
        }
        private void DisplayData()
        {
            DataTable dt = new DataTable();
            dt = opr.Employees(info);
            dgvEmployee.DataSource = dt;
            dgvEmployee.Columns[0].Visible = false;
            dgvEmployee.Columns[7].Visible = false;
            dgvEmployee.Columns[8].Visible = false;
        }
        private void IEmployee_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = opr.Employees(info);
            dgvEmployee.DataSource = dt;
            dgvEmployee.Columns[0].Visible = false;
            dgvEmployee.Columns[7].Visible = false;
            dgvEmployee.Columns[8].Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                if (ID != 0)
                {
                    info.f = ID.ToString();
                    int rows = opr.Supprimeremp(info);
                    if (rows > 0)
                    {
                        MessageBox.Show("Données supprimés avec succés");
                        DisplayData();

                    }
                }
                else
                {
                    MessageBox.Show("veuillez selectionner l'enregistrement à supprimer");

                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                 info.name = textBox1.Text;
                 info.prenom = textBox2.Text;
                info.datnais = textBox3.Text;
                info.Adresse = textBox4.Text;
                info.education = textBox5.Text;
                info.username= textBox6.Text;
                info.f = ID.ToString();
                int rows = opr.modifieremp(info);
                if (rows > 0)
                {
                    MessageBox.Show("Modification de donnés avec succés");
                    DisplayData();
                }
            }
            else
            {
                MessageBox.Show("veiullez selectionner un enregistrement");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {

                 textBox1.Text = info.name;
                 textBox2.Text = info.prenom;
                textBox3.Text = info.datnais;
                textBox4.Text = info.Adresse;
                textBox5.Text = info.education;
                textBox6.Text = info.username;

            }

            else
            {
                MessageBox.Show("veiullez selectionner un enregistrement pour afficher");
            }

        }

        private void dgvEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            ID = Convert.ToInt32(dgvEmployee.Rows[e.RowIndex].Cells[0].Value.ToString());

            
            info.name = dgvEmployee.Rows[e.RowIndex].Cells[1].Value.ToString();
            info.prenom = dgvEmployee.Rows[e.RowIndex].Cells[2].Value.ToString();
            info.datnais = dgvEmployee.Rows[e.RowIndex].Cells[3].Value.ToString();
            info.Adresse = dgvEmployee.Rows[e.RowIndex].Cells[4].Value.ToString();
            info.education = dgvEmployee.Rows[e.RowIndex].Cells[5].Value.ToString();
            info.username = dgvEmployee.Rows[e.RowIndex].Cells[6].Value.ToString();

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
    


