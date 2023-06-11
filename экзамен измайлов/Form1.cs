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

namespace экзамен_измайлов
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-7QJGE9S\SQLEXPRESS;Initial Catalog=shop; Integrated Security=True;");

            con.Open();

            try 
            {
                string comand = ("SELECT * FROM User$ WHERE Login = '" + textBox1.Text + "' AND Password = '" + textBox2.Text + "';");
                SqlCommand check = new SqlCommand(comand, con);

                if (check.ExecuteScalar() != null)
                {
                    MessageBox.Show("Вы успешно вошли");
                    Form2 f = new Form2();
                    f.Show();
                    this.Hide();
                }

                else
                {
                    MessageBox.Show("Ввели не верные данные");
                }

            }
            finally 
            {
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
