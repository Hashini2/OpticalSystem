using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace opticalmanagementsystem
{
    public partial class report : Form
    {
        SqlConnection Con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\aysha\\Desktop\\system\\opticalmanagementsystem\\optical.mdf;Integrated Security=True;Connect Timeout=30");
        public void populate()
        {
            Con.Open();
            string myquery = "select * from reporttbl";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(myquery, Con);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = ds.Tables[0];
            Con.Close();
        }
        public report()
        {
            InitializeComponent();
            populate();
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            if ( lense.Text == "" ||  resph.Text == "" || tester.Text == "" || cylright.Text == ""|| axisright.Text == "" || addright.Text == "" || lesph.Text == "" || cylleft.Text == "" || axisleft.Text == "" || addleft.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into reporttbl values( '" + lense.Text + "',  '" + resph.Text + "', '" + cylright.Text + "','" + axisright.Text + "','" + addright.Text + "','" + lesph.Text + "','" + cylleft.Text + "','" + axisleft.Text + "','" + addleft.Text + "','" + tester.Text + "')", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Lense Details Successfully Added");
                    Con.Close();
                    populate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "Update reporttbl set resph ='" + resph.Text + "', cylright='" + cylright.Text + "',axisright= '" + axisright.Text + "', addright= '" + addright.Text + "' , lesph= '" + lesph.Text + "' , cylleft= '" + cylleft.Text + "', axisleft= '" + axisleft.Text + "', addleft= '" + addleft.Text + "', test= '" + tester.Text + "'   where lense='" + lense.Text + "';";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Lense Details Updated Successfully");
            Con.Close();
            populate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (lense.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from reporttbl where lense='" + lense.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Lense Details Deleted Successfully");
                    Con.Close();
                    populate();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            home home = new home();
            home.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lense.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            resph.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            cylright.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            axisright.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            addright.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            lesph.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            cylleft.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            axisleft.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            addleft.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            tester.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
        }

        private void report_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            balancebill balancebill = new balancebill();
            balancebill.Show();
            this.Hide();
        }

        private void resph_TextChanged(object sender, EventArgs e)
        {

        }

        private void addright_TextChanged(object sender, EventArgs e)
        {

        }

        private void tester_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
