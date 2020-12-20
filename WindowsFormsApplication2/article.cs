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
    public partial class article : Form
    {
        public Operations opr = new Operations();
        public Informations info = new Informations();
        public int ID = 0;

        public article()
        {
            InitializeComponent();
        }
        private void DisplayData()
        {
            DataTable dt = new DataTable();

            dt = opr.articles(info);

            dataGridView1.DataSource = dt;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "") || (textBox5.Text == "") || (textBox7.Text == "") || (textBox6.Text == "") || (textBox2.Text == "") || (Box1.Text == ""))
            {

                MessageBox.Show("veuillez remplissez tous les champs !");

            }
            else if (((textBox1.Text.GetType()==typeof(int)) && (textBox6.Text.GetType() == typeof(float)) && (textBox7.Text.GetType() == typeof(char)) && (textBox5.Text.GetType() == typeof(char)) && (Box1.Text.GetType()==typeof(int))))
                {
                MessageBox.Show("veuillez remplissez tous les champs correctement !");

            }
            else
                {
                info.nomart = textBox1.Text;
                info.refart = textBox7.Text;
                info.prixunit = textBox6.Text;
                info.Qte = textBox2.Text;
                info.tva = Box1.Text;
                int rows = opr.insertarticle(info);
                if (rows > 0)
                {
                    MessageBox.Show("validation de donnés avec succés");

                    DisplayData();


                }

            }
        } 
        

       
        private void article_Load(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            dt = opr.articles(info);
            dataGridView1.DataSource = dt;


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
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

        private void label7_Click(object sender, EventArgs e)
        {

        }
        
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

         
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void recherchez_TextChanged(object sender, EventArgs e)
        {

            info.recherche = recherche.Text;
            DataTable dt = new DataTable();

            dt = opr.rechercher(info);
            dataGridView1.DataSource = dt;


        }
    }
}
