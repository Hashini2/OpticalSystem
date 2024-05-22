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
    public partial class balancebill : Form
    {
        public balancebill()
        {
            InitializeComponent();
            populate();
            displaycustomer();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\aysha\Desktop\system\opticalmanagementsystem\optical.mdf;Integrated Security=True;Connect Timeout=30");
        public void populate()
        {
            Con.Open();
            string myquery = "select * from itemtbl";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(myquery, Con);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridView3.ReadOnly = true;
            dataGridView3.DataSource = ds.Tables[0];
            Con.Close();
        }
        public void displaycustomer()
        {
            Con.Open();
            string myquery = "select * from patienttbl";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(myquery, Con);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridView2.ReadOnly = true;
            dataGridView2.DataSource = ds.Tables[0];
            Con.Close();
        }
       

        private void label5_Click(object sender, EventArgs e)
        {

        }
        int key = 0, stock = 0;
        int n = 0,grdtotal=0;
        int custkey = 0;
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
            textBox4.Text = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
            if (textBox1.Text == "")
            {
                custkey = 0;
                
            }
            else
            {
                custkey = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells[0].Value.ToString());
                
            }
        }

        private void balancebill_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            home home = new home();
            home.Show();
            this.Hide();
        }
        private void reset()
        {

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }
        Bitmap bitmap;
        private void button4_Click(object sender, EventArgs e)
        {
            Panel panel = new Panel();
            this.Controls.Add(panel);
            Graphics graphics = panel.CreateGraphics();
            Size size = this.ClientSize;
            bitmap = new Bitmap(size.Width, size.Height, graphics);
            graphics = Graphics.FromImage(bitmap);
            Point point = PointToScreen(panel.Location);
            graphics.CopyFromScreen(point.X, point.Y, 0, 0, size);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            reset();
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

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox2.Text == "" || Convert.ToInt32(textBox2.Text)>stock)
            {
                MessageBox.Show("No Stock");
            }
            else
            {
                int total = Convert.ToInt32(textBox2.Text) * Convert.ToInt32(textBox3.Text);
                DataGridViewRow newrow = new DataGridViewRow();
               
                newrow.CreateCells(dataGridView1);
                
                newrow.Cells[0].Value = textBox4.Text;
                newrow.Cells[1].Value = textBox1.Text;
                newrow.Cells[2].Value = textBox3.Text;
                newrow.Cells[3].Value = textBox2.Text;
                newrow.Cells[4].Value = total;
                dataGridView1.Rows.Add(newrow);
                grdtotal = grdtotal + total;
                label7.Text = "Rs" + grdtotal;
                n++;

            }
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            textBox1.Text = dataGridView3.SelectedRows[0].Cells[1].Value.ToString();
            
            textBox3.Text = dataGridView3.SelectedRows[0].Cells[4].Value.ToString();
            
            if(textBox1.Text== "")
            {
                key = 0;
                stock = 0;
            }
            else
            {
                key = Convert.ToInt32(  dataGridView3.SelectedRows[0].Cells[0].Value.ToString());
                stock = Convert.ToInt32(dataGridView3.SelectedRows[0].Cells[3].Value.ToString());
            }
            
        }
    }
}
