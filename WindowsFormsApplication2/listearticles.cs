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
    public partial class listearticles : Form

    {
        public Operations opr = new Operations();
        public Informations info = new Informations();
        public int ID = 0;

        public listearticles()
        {
            InitializeComponent();
        }
        private void DisplayData()
        {
            DataTable dt = new DataTable();
            dt = opr.Employees(info);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            {


                if (ID != 0)
                {


                    info.nomart = textBox1.Text;
                    info.refart = textBox6.Text;
                    info.prixunit = textBox2.Text;
                    info.Qte = textBox3.Text;
                    info.marque = textBox4.Text;
                    info.tva = comboBox1.Text;
                    info.f = ID.ToString();
                    int rows = opr.modifiearticle(info);

                }

                else
                {
                    MessageBox.Show("veiullez selectionner un enregistrement pour afficher");
                }

            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            {

                ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());


                info.nomart = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                info.refart = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                info.prixunit = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                info.Qte = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                info.marque = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                info.tva = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (ID != 0)
            {


                textBox1.Text = info.nomart;
                textBox6.Text = info.refart;
                textBox2.Text = info.prixunit;
                textBox3.Text = info.Qte;
                textBox4.Text = info.marque;
                comboBox1.Text = info.tva;



            }

            else
            {
                MessageBox.Show("veiullez selectionner un enregistrement pour afficher");
            }




        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                if (ID != 0)
                {
                    info.f = ID.ToString();
                    int rows = opr.Supprimerarticle(info);
                    if (rows > 0)
                    {
                        MessageBox.Show("Données supprimés avec succés");
                        //  DisplayData();

                    }
                }
                else
                {
                    MessageBox.Show("veuillez selectionner l'enregistrement à supprimer");

                }
            }
        }

        private void listearticles_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = opr.articles(info);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Visible = false;
          
        }
    }
}
        
    
        
    
